using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CommandLineParser;

namespace SqlExec
{
    public class ExecuteSqlScripts
    {
        private ILogWrapper Logger { get; set; }
        public ExecuteSqlScripts(ILogWrapper aLogger)
        {
            Logger = aLogger;
        }

        public void ExecuteScripts(string connectionString, IEnumerable<string> aSqlFiles, string databaseName)
        {
            Logger.Info("**********************************************************************");
            Logger.Info("* Starting Database Setup on " + databaseName + " - " + DateTime.Now.ToString("dd/MM/yyyy (HH:mm:ss)"));
            Logger.Info("**********************************************************************");
            Logger.Info("Start of ExecuteScripts");
            Logger.Debug("\tConnection string = " + connectionString);

            try
            {
                foreach (string file in aSqlFiles)
                {
                    Logger.Debug($"\t\tExecute this SQL script file : {file}");
                    string fileName = Path.GetFileName(file);
                    // For each file execute the SQL script
                    RunOneSQLScript(file, connectionString);
                }
            }
            finally
            {
                Logger.Info("End of ExecuteScripts");
            }
        }

        private const string SQL_GO_SPLIT_REGEX = "^\\s*GO\\s*$"; 

        /// <summary>
        /// Run 1 SQL file script
        /// </summary>
        /// <param name="filename">File to execute</param>
        /// <param name="connectionString">Connection string of the database to run the script</param>
        /// <param name="componentName">The current component name</param>
        private void RunOneSQLScript(string filename, string connectionString)
        {
            //string prefixLog = "\t\t\t";
            string prefixLog = "";

            Logger.Debug(prefixLog + "Starting executing SQL file: ");
            Logger.Info(prefixLog + filename);

            string script = File.ReadAllText(filename);

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, SQL_GO_SPLIT_REGEX, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            Logger.Debug(prefixLog + "\tScript splitted in : " + commandStrings.Count().ToString() + " blocks separated with 'GO' sequence.");

            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                Connection.Open();

                Connection.InfoMessage += SqlInfoMessageEventHandlerBase;
                int commandStringIndex = 0;
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() == "") // if empty, ignore it
                    {
                        commandStringIndex++;
                        continue;
                    }
                    Stopwatch chrono = Stopwatch.StartNew();
                    try
                    {
                        SqlCommand sqlcmd = new SqlCommand(commandString, Connection);
                        sqlcmd.CommandTimeout = 300; // Five minutes should be more than enough for any acceptable script
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(ex, string.Format("SQL Script named \"{0}\" execution failed", filename));
                        Logger.Error("SQL part that raised the exception : ");
                        Logger.Error(commandString);
                        throw;
                    }
                    finally
                    {
                        string logMessage = prefixLog + "\tBlock of script number " + (++commandStringIndex).ToString() + " executed in " + chrono.ElapsedMilliseconds.ToString() + " ms";
                        if (chrono.ElapsedMilliseconds > 300000)
                        {
                            Logger.Warn(logMessage);
                            Logger.Warn(commandString);
                        }
                        else
                            Logger.Debug(logMessage);

                    }
                }
            }
            Logger.Debug(prefixLog + "End of SQL File execution");
        }

        private void SqlInfoMessageEventHandlerBase(object sender, SqlInfoMessageEventArgs e)
        {
            // SqlInfoMessageEventHandler return all log in 1 block separated by line breaks
            string[] lines = Regex.Split(e.Message, "\r\n");
            foreach (string line in lines)
            {
                string lineUpper = line.ToUpper();
                if (lineUpper.Contains("[WARNING]"))
                    Logger.Warn(line);
                else if (lineUpper.Contains("[ERROR]"))
                    Logger.Error(line);
                else if (lineUpper.Contains("[SUCCESS]") || lineUpper.Contains("[INFO]"))
                    Logger.Info(line);
                else
                    Logger.Debug(line);
            }
        }

    }
}
