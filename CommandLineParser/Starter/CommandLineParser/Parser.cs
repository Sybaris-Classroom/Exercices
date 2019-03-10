using System;
using System.Diagnostics;
using System.Reflection;

namespace CommandLineParser
{
    /// <summary>
    /// The goal of this class is to provide a parser to parse command line, and to return a strong typed object of type T that will contains the 
    /// data of the command line parsed in each field of the T instance.
    /// </summary>
    /// <typeparam name="T">Type of the class we want to get after parsing the command line</typeparam>
    public class Parser<T> // TODO 4 bis : you will have to define some contraints on Generics : https://docs.microsoft.com/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    {
        /// <summary>
        /// A logger to log on screen or on log file
        /// </summary>
        private ILogWrapper m_logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">A logger</param>
        public Parser(ILogWrapper logger)
        {
            this.m_logger = logger;
        }

        /// <summary>
        /// This method return the value associated to an option.
        /// The short name is with '-'
        /// The long name is with "--"
        /// </summary>
        /// <param name="args">Arguments of the command line</param>
        /// <param name="aParameterShortName">Short name of the parameter (option in 1 letter)</param>
        /// <param name="aParameterLongName">Long name of the parameter (option in several letters)</param>
        /// <param name="aTypeOfTheProperty">Type of the parameter (option) ex : string, bool</param>
        /// <returns>The value associated to the parameter</returns>
        private object GetValueFromCommandLine(string[] args, char aParameterShortName, string aParameterLongName, Type aTypeOfTheProperty)
        {
            if (aTypeOfTheProperty == typeof(bool))
            { // In this case, we only want to check if parameter is present
                foreach (string arg in args)
                    if (arg.ToUpper() == "-" + aParameterShortName.ToString().ToUpper() ||
                        arg.ToUpper() == "--" + aParameterLongName.ToString().ToUpper())
                        return true;
                return false;
            }
            if (aTypeOfTheProperty == typeof(string))
            { // In this case, the next argument is the associated valeur
                int i = 0;
                foreach (string arg in args)
                {
                    if (arg.ToUpper() == "-" + aParameterShortName.ToString().ToUpper() ||
                        arg.ToUpper() == "--" + aParameterLongName.ToString().ToUpper())
                    {
                        if (args.Length <= i + 1)
                            throw new Exception("Missing a value for the parameter '" + aParameterShortName + "' or " + aParameterLongName);
                        return args[i + 1];
                    }
                    i++;
                }
            }

            return null;
        }

        /// <summary>
        /// This code is here to help you to display (and format) the helptext of the Doc attribute
        /// </summary>
        /// <param name="aHelpText">HelpText to display from Doc attribute</param>
        public void DisplayHelpDoc(string aHelpText)
        {
            m_logger.Info(aHelpText);
        }

        /// <summary>
        /// This code is here to help you to display (and format) the data from the Option attribute
        /// </summary>
        /// <param name="aShortName">Short Name to display from Option attribute (1 char to define the Option/Parameter)</param>
        /// <param name="aLongName">Long Name to display from Option attribute (string to define the Option/Parameter)</param>
        /// <param name="aHelpText">HelpText to display from Option attribute</param>
        public void DisplayHelpOption(char aShortName, string aLongName, string aHelpText)
        {
            string message = "-" + aShortName.ToString() + " or --" + aLongName;
            m_logger.Info(message.PadRight(25) + "  : " + aHelpText);
        }

        /// <summary>
        /// Parse command line and return an instance on T filled with the values read from command line
        /// </summary>
        /// <param name="args">Command line arguments from main</param>
        /// <returns>An filled instance of T</returns>
        public T ParseArguments(string[] args)
        {
            // TODO 4 : The goal of this method is to parse command line and return an instance of strong typed class T
            // To help you, you will use GetValueFromCommandLine that is defined in this class (C.F. doc of GetValueFromCommandLine)
            // You will found here the steps to do this :

            // Create an instance of the result --> At this step, first make the TODO 4 bis
            // Get all properties of T
            // Loop on each property
            //   Retreive the custom attribute (Option) of the property 
            //   If there is no attribute, continue the loop
            //   Retreive the value associated to the property/option and use the provided "GetValueFromCommandLine" method for that
            //   Check if parameter is Required or not
            //   Set the value in the correct result field
            // Return the result

            // The following line is here only to compile, and to make the step TODO 3 before the TODO 4.
            // To be removed when you begin TODO 4
            return default(T);

        }

        /// <summary>
        /// This method display help of the tool, using defined help in the CommandLineOptions class.
        /// It will display first the HelpText from the Doc attribute on the class
        /// Then for each option, it will display the HelpText of the option
        /// </summary>
        public void DisplayHelp()
        {
            // TODO 3 : The goal of this method is to display help using HelpText of Doc and Option attributes.
            // You will found here the steps to do this :

            // Get the attribute (Doc) of the class T (In our example T is CommandLineOptions)
            // Display the header (Helptext of Doc attribute on the class) using provided "DisplayHelpDoc" method
            // List all the properties of T
            // Loop on all these properties
            //   Retreive the custom attribute (Option) of the property 
            //   If there is no attribute, continue the loop
            //   Display the message using provided "DisplayHelpOption" method
        }

    }
}