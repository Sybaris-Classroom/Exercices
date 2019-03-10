using System;

namespace CommandLineParser
{
    /// <summary>
    /// Class to define an Attribute "Option"
    /// </summary>
    public class OptionAttribute : Attribute
    {
        /// <summary>
        /// Constructor of the option attribute. 2 Mandatory value : Short and Long name
        /// </summary>
        /// <param name="aShortName">1 char to define the Option/Parameter</param>
        /// <param name="aLongName">a word that define the Option/Parameter</param>
        public OptionAttribute(char aShortName, string aLongName)
        {
            ShortName = aShortName;
            LongName = aLongName;
        }

        /// <summary>
        /// Short Name (1 char to define the Option/Parameter)
        /// </summary>
        public char ShortName { get; private set; }
        /// <summary>
        /// Long Name (string to define the Option/Parameter)
        /// </summary>
        public string LongName { get; private set; }

        /// <summary>
        /// The help to be displayed on this option
        /// </summary>
        public string HelpText { get; set; }
        /// <summary>
        /// If this option is required in the command line, use Required = true, and parser with check automatically that this option is Required or not.
        /// </summary>
        public bool Required { get; set; }

    }
}