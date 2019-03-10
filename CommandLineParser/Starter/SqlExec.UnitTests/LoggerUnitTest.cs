using CommandLineParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExec.UnitTests
{
    public class LoggerUnitTest : ILogWrapper
    {
        List<string> actualMessages = new List<string>();
        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception ex, string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            actualMessages.Add(message);
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }

        public void CheckLogMessages(List<string> aExpectedMessages)
        {
            Assert.AreEqual(aExpectedMessages.Count, actualMessages.Count);
            for (int i = 0; i < actualMessages.Count; i++)
            {
                Assert.AreEqual(aExpectedMessages[i], actualMessages[i]);
            }
        }
    }

}
