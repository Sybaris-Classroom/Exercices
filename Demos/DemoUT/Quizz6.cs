using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.AsyncAwait
{
    [TestClass]
    public class Quizz6
    {
        [TestMethod]
        public void TestMethod1()
        {
            throw new Exception("JPP");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Task.Run(() => throw new Exception("JPP"));
        }

        [TestMethod]
        public async void TestMethod3()
        {
            await Task.Run(() => throw new Exception("JPP"));
        }

        [TestMethod]
        public async Task TestMethod4()
        {
            await Task.Run(() => throw new Exception("JPP"));
        }

    }
}
