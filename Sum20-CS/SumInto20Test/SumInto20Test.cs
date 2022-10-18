
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumInto20NS;
namespace SumInto20Test
{
    [TestClass]
    public class SumInto20Test
    {
        [TestMethod]
        public void TestValidNumTrue()
        {
            SumInto20 sum = new SumInto20();
            string number= "974";
            Assert.IsTrue(sum.IsInputValid(number));
        }

        [TestMethod]
        public void TestValidNumFalse()
        {
            SumInto20 sum = new SumInto20();
            string number = "97q";
            Assert.IsFalse(sum.IsInputValid(number));
        }
    }
}