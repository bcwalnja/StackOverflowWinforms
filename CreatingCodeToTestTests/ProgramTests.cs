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
            var result = Program.IsSingleBonus(0);

            Assert.IsFalse(result);
        }
        
        [TestMethod()]
        public void IsSingleBonusTest_six_shouldreturnfalse()
        {
            var result = Program.IsSingleBonus(6);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsSingleBonusTest_seven_shouldreturntrue()
        {
            var result = Program.IsSingleBonus(7);

            Assert.IsTrue(result);
        }
    }
}