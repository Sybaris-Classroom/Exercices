using System;

namespace CommandLineParser
{
    /// <summary>
    /// Class to define a Doc "Option"
    /// </summary>
    public class DocAttribute : Attribute
    {
        /// <summary>
        /// The help to be displayed for this tool. This help text will be displayed as header of the documentation.
        /// </summary>
        public string HelpText { get; set; }
    }
}