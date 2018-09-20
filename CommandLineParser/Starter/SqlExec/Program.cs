using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLineParser;

namespace SqlExec
{
    /// <summary>
    /// The goal of this program is to execute several Sql scripts that contains GO instructions.
    /// For this we need to parse command line arguments. And we will use C# attributes for that.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create a logger to write message on screen or on a log file.
            ILogWrapper Logger = new LogWrapper();
            
            // Create a parser to parse command line
            var parser = new Parser<CommandLineOptions>(Logger);
            if (args.Length <= 0)
            {
                // In case of no arguments, display help
                parser.DisplayHelp();
            }
            else
                try
                {
                    // We have some arguments, so parse them
                    CommandLineOptions commandLineOptions = parser.ParseArguments(args);

                    // Retreive needed data to launch the execution
                    string databaseName = commandLineOptions.DatabaseName;
                    string connectionString = GetConnectionStringAndCheckArguments(commandLineOptions);
                    string folderSQLScripts = commandLineOptions.FolderSQLScripts;
                    IEnumerable<string> sqlFiles = GetSqlFiles(folderSQLScripts);

                    // Display input data
                    Logger.Info("Parsing of command line done : ");
                    Logger.Info("  Server = " + commandLineOptions.Server);
                    Logger.Info("  UserName = " + commandLineOptions.UserName);
                    Logger.Info("  Password = " + commandLineOptions.Password);
                    Logger.Info("  DatabaseName = " + commandLineOptions.DatabaseName);
                    Logger.Info("  TrustedConnection = " + commandLineOptions.TrustedConnection);
                    Logger.Info("  ConnectionString = " + commandLineOptions.ConnectionString);
                    Logger.Info("  FolderSQLScripts = " + commandLineOptions.FolderSQLScripts);
                    Logger.Info("The connection string that will be used : ");
                    Logger.Info("  " + connectionString);
                    Logger.Info($"  {sqlFiles.Count()} files found.");

                    ConsoleColor currentColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parsing of command line is done");
                    Console.ForegroundColor = currentColor;

                    // Execution of the SQL scripts
                    // Note for formation, you can comment the 2 following lines :
                    //ExecuteSqlScripts executeSqlScripts = new ExecuteSqlScripts(Logger);
                    //executeSqlScripts.ExecuteScripts(connectionString, sqlFiles, databaseName);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "An error has occurs during execution of the program : ");
                    parser.DisplayHelp();
                }

            // Only for debug, when launched with Visual Studio 
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to terminate");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Get the list of sql files to be executed.
        /// </summary>
        /// <param name="folderSQLScripts">Folder or directory where the files are stored.</param>
        /// <returns></returns>
        private static IEnumerable<string> GetSqlFiles(string folderSQLScripts)
        {
            return Directory.GetFiles(folderSQLScripts, "*.sql", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// The goal of this method is to get a correct connection string from command line arguments
        /// </summary>
        /// <param name="options">Parsed command line arguments</param>
        /// <returns>string that represent the connection string</returns>
        private static string GetConnectionStringAndCheckArguments(CommandLineOptions options)
        {
            // Case we have already a connection string
            if (!string.IsNullOrEmpty(options.ConnectionString))
            {

                if (!string.IsNullOrEmpty(options.Server))
                    throw new Exception($"The ConnectionString argument is not compatible with Server argument.");

                if (!string.IsNullOrEmpty(options.UserName))
                    throw new Exception($"The ConnectionString argument is not compatible with UserName argument.");

                if (!string.IsNullOrEmpty(options.Password))
                    throw new Exception($"The ConnectionString argument is not compatible with Password argument.");

                if (options.TrustedConnection)
                    throw new Exception($"The ConnectionString argument is not compatible with TrustedConnection argument.");
                return options.ConnectionString;
            }
            else // Case we don't have a connection string, we have to build it
            {
                if (string.IsNullOrEmpty(options.Server))
                    throw new Exception($"You have to specify a ConnectionString or a Server argument.");

                if (options.TrustedConnection)
                {
                    if (!string.IsNullOrEmpty(options.UserName))
                        throw new Exception($"The TrustedConnection argument is not compatible with UserName argument.");

                    if (!string.IsNullOrEmpty(options.Password))
                        throw new Exception($"The TrustedConnection argument is not compatible with Password argument.");

                    return $"Server={options.Server};Database={options.DatabaseName};Trusted_Connection=True;";
                }
                else // Not a trusted connection
                {
                    // We do not need to test options.Server and options.DatabaseName because they are marked as required

                    if (string.IsNullOrEmpty(options.UserName))
                        throw new Exception($"You have to specify a UserName argument.");

                    if (string.IsNullOrEmpty(options.Password))
                        throw new Exception($"You have to specify a Password argument.");
                    return $"Server={options.Server};Database={options.DatabaseName};User Id = {options.UserName};Password = {options.Password};";
                }
            }
        }
    }
}
