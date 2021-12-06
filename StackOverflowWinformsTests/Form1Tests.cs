using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackOverflowWinforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowWinforms.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void ScreenIsOnTest_ShouldReturnTrue()
        {
            System.Diagnostics.Debug.WriteLine("Test 1 is running now");

            var form1 = new Form1();
            var result = form1.ScreenIsOn();

            Assert.IsTrue(result);
            System.Diagnostics.Debug.WriteLine("Test 1 is finished now");
        }
    }
}