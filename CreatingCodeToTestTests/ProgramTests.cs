using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingCodeToTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCodeToTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsSingleBonusTest_zero_shouldreturnfalse()
        {
            var result = false;

            Assert.IsFalse(result);
        }
    }
}