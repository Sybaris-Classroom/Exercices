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
    public class Parser<T> where T : new()
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
        /// Parse command line and return an instance on T filled with the values read from command line
        /// </summary>
        /// <param name="args">Command line arguments from main</param>
        /// <returns>An filled instance of T</returns>
        public T ParseArguments(string[] args)
        {
            // Create an instance of the result
            T result = new T();

            // Get all properties of T
            PropertyInfo[] pis = typeof(T).GetProperties();

            // Loop on each property
            foreach (PropertyInfo pi in pis)
            {
                // Search if there is an attribute on the property
                object[] attributes = pi.GetCustomAttributes(true);
                foreach (object attr in attributes)
                    if (attr is OptionAttribute)
                    {
                        // There is an attribute of type OptionAttribute
                        OptionAttribute cmdAttribute = (attr as OptionAttribute);
                        Debug.Assert(cmdAttribute != null);

                        // Retreive the value associated to the property/option
                        object value = GetValueFromCommandLine(args, cmdAttribute.ShortName, cmdAttribute.LongName, pi.PropertyType);

                        // Check if parameter is Required or not
                        if (cmdAttribute.Required && value == null)
                            throw new Exception("The required parameter -" + cmdAttribute.ShortName.ToString() + " or --" + cmdAttribute.LongName + " is missing.");

                        // Set the value in the correct result field
                        pi.SetValue(result, value);
                    }
            }

            // Return the result
            return result;
        }

        /// <summary>
        /// This method display help of the tool, using defined help in the CommandLineOptions class.
        /// It will display first the HelpText from the Doc attribute on the class
        /// Then for each option, it will display the HelpText of the option
        /// </summary>
        public void DisplayHelp()
        {
            // Get the attribute of the class
            object[] classAttributes = typeof(T).GetCustomAttributes(typeof(DocAttribute), true);
            Debug.Assert(classAttributes != null, "You must have a Doc Attribute on the class");
            Debug.Assert(classAttributes.Length == 1);
            DocAttribute doc = classAttributes[0] as DocAttribute;

            // Display the header (Helptext of Doc attribute on the class)
            m_logger.Info(doc.HelpText);

            // List all the properties of T
            PropertyInfo[] pis = typeof(T).GetProperties();

            // Loop on all properties
            foreach (PropertyInfo pi in pis)
            {
                // Check the custom attributes of the property
                object[] attributes = pi.GetCustomAttributes(true);

                // If there is several attribute, take the OptionAttribute
                foreach (object attr in attributes)
                    if (attr is OptionAttribute)
                    {
                        // Retreive the OptionAttribute
                        OptionAttribute cmdAttribute = attr as OptionAttribute;
                        Debug.Assert(cmdAttribute != null);

                        // Display the message
                        string message = "-" + cmdAttribute.ShortName.ToString() + " or --" + cmdAttribute.LongName;
                        m_logger.Info(message.PadRight(25) + "  : " + cmdAttribute.HelpText);
                    }
            }
        }

    }
}