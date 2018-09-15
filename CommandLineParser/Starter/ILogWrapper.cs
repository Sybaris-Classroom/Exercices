using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineParser
{
    /// <summary>
    /// An simple interface to a logger
    /// </summary>
    public interface ILogWrapper
    {
        void Error(string message);
        void Error(Exception ex, string message);
        void Warn(string message);
        void Info(string message);
        void Debug(string message);
    }
}
