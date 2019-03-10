using System;
using System.Collections.Generic;
using CommandLineParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SqlExec.UnitTests
{
    [TestClass]
    public class CommandLineOptionsTest
    {
   
        [TestMethod]
        public void DisplayHelpTest()
        {
            List<string> expectedMessage = new List<string>();
            expectedMessage.Add(@"Tool to execute SQL scripts using Command Line.
Version 1.0.0.0
Copyright (c) Formation.  All rights reserved.

Help display
Usage : SqlExec");
            expectedMessage.Add("-S or --Server             : Database server or IP adress with instance name");
            expectedMessage.Add("-U or --User               : Login");
            expectedMessage.Add("-P or --Password           : Password");
            expectedMessage.Add("-D or --DatabaseName       : Use this database");
            expectedMessage.Add("-E or --TrustedConnection  : Trusted Connection");
            expectedMessage.Add("-C or --ConnectionString   : Connection String");
            expectedMessage.Add("-F or --Folder             : Folder where versionned SQL script are stored");

            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);
            parser.DisplayHelp();
            //CommandLineOptions commandLineOptions = parser.ParseArguments(new string[] { });

            Logger.CheckLogMessages(expectedMessage);
        }

        [TestMethod]
        public void ParsingOK_Test1()
        {
            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);

            CommandLineOptions commandLineOptions = parser.ParseArguments("-S localhost -U sa -P password -D MyDb -F .\\SqlFiles\\".Split(' '));
            Assert.AreEqual(null, commandLineOptions.ConnectionString);
            Assert.AreEqual("MyDb", commandLineOptions.DatabaseName);
            Assert.AreEqual(".\\SqlFiles\\", commandLineOptions.FolderSQLScripts);
            Assert.AreEqual("password", commandLineOptions.Password);
            Assert.AreEqual("localhost", commandLineOptions.Server);
            Assert.AreEqual(false, commandLineOptions.TrustedConnection);
            Assert.AreEqual("sa", commandLineOptions.UserName);
        }

        [TestMethod]
        public void ParsingOK_Test2()
        {
            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);

            CommandLineOptions commandLineOptions = parser.ParseArguments("--Server localhost --User sa --Password password --DatabaseName MyDb --Folder .\\SqlFiles\\".Split(' '));
            Assert.AreEqual(null, commandLineOptions.ConnectionString);
            Assert.AreEqual("MyDb", commandLineOptions.DatabaseName);
            Assert.AreEqual(".\\SqlFiles\\", commandLineOptions.FolderSQLScripts);
            Assert.AreEqual("password", commandLineOptions.Password);
            Assert.AreEqual("localhost", commandLineOptions.Server);
            Assert.AreEqual(false, commandLineOptions.TrustedConnection);
            Assert.AreEqual("sa", commandLineOptions.UserName);
        }

        [TestMethod]
        public void ParsingOK_Test3()
        {
            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);

            CommandLineOptions commandLineOptions = parser.ParseArguments("-S localhost -U sa --Password password --DatabaseName MyDb --Folder .\\SqlFiles\\".Split(' '));
            Assert.AreEqual(null, commandLineOptions.ConnectionString);
            Assert.AreEqual("MyDb", commandLineOptions.DatabaseName);
            Assert.AreEqual(".\\SqlFiles\\", commandLineOptions.FolderSQLScripts);
            Assert.AreEqual("password", commandLineOptions.Password);
            Assert.AreEqual("localhost", commandLineOptions.Server);
            Assert.AreEqual(false, commandLineOptions.TrustedConnection);
            Assert.AreEqual("sa", commandLineOptions.UserName);
        }

        [TestMethod]
        public void ParsingException_Test1()
        {
            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);
            try
            {
                CommandLineOptions commandLineOptions = parser.ParseArguments("-S localhost -U sa -P password -D MyDb -F".Split(' '));
                Assert.Fail("Expected exception, but no exception was catched.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Missing a value for the parameter 'F' or Folder", ex.Message);
            }
        }

        [TestMethod]
        public void ParsingException_Test2()
        {
            LoggerUnitTest Logger = new LoggerUnitTest();
            var parser = new Parser<CommandLineOptions>(Logger);
            try
            {
                CommandLineOptions commandLineOptions = parser.ParseArguments("-S localhost -U sa -P password -F.\\SqlFiles\\".Split(' '));
                Assert.Fail("Expected exception, but no exception was catched.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("The required parameter -D or --DatabaseName is missing.", ex.Message);
            }
        }


    }
}
