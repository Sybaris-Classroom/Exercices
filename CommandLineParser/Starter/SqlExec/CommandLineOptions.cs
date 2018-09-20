using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLineParser;

namespace SqlExec
{
    /// <summary>
    /// This class define a strong type view of a valid command line argument.
    /// The parsing of the command line argument must return an instance of this class.
    /// Furthermore, this class will provide auto documentation to display help, and check of
    /// required parameters.
    /// </summary>
    [Doc(HelpText =
@"Tool to execute SQL scripts using Command Line.
Version 1.0.0.0
Copyright (c) Formation.  All rights reserved.

Help display
Usage : SqlExec")]

    // The "Doc" attribute will provide the header of the help/documentation will the user will run the tool without parameters
    // For each property, an Option attribute is define with the following parameters :
    //  - A single char (ShortName), witch is a shortcut of the word that define the Option 
    //  - A word (LongName) that define the option name
    //  - An optional parameter HelpText of this option to be displayed when user want to see the help 
    //  - An optional parameter Required (false by default) to tell the parser to check if parameter is mandatory or not. 
    //    If Required=true and the parameter is not provided on command line, parser will raise an error.
    public class CommandLineOptions
    {
        [Option('S', "Server", HelpText = "Database server or IP adress with instance name")]
        public string Server { get; set; }

        [Option('U', "User", HelpText = "Login")]
        public string UserName { get; set; }

        [Option('P', "Password", HelpText = "Password")]
        public string Password { get; set; }

        [Option('D', "DatabaseName", HelpText = "Use this database", Required = true)]
        public string DatabaseName { get; set; }

        [Option('E', "TrustedConnection", HelpText = "Trusted Connection")]
        public bool TrustedConnection { get; set; }

        [Option('C', "ConnectionString", HelpText = "Connection String")]
        public string ConnectionString { get; set; }

        [Option('F', "Folder", HelpText = "Folder where versionned SQL script are stored", Required = true)]
        public string FolderSQLScripts { get; set; }

    }
}
