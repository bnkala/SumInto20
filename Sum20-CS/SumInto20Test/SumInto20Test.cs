
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

        [TestMethod]
        public void TestNumLengthTrue()
        {
            SumInto20 sum = new SumInto20();
            string number = "873";
            Assert.AreEqual(3, number.Length);
            //Assert.IsTrue(sum.IsInputValid(number));
        }

        [TestMethod]
        public void TestNumLengthFalse()
        {
            SumInto20 sum = new SumInto20();
            string number = "8762";
            Assert.AreNotEqual(3, number.Length);
            //Assert.IsFalse(sum.IsInputValid(number));
        }

        [TestMethod]
        public void TestSum20True()
        {
            SumInto20 sum = new SumInto20();
            Assert.AreEqual(20, sum.Total20("839"));
        }

        [TestMethod]
        public void TestSum20False()
        {
            SumInto20 sum = new SumInto20();
            Assert.AreNotEqual(20, sum.Total20("765"));
        }

        [TestMethod]
        public void TestCheck20True()
        {
            SumInto20 sum = new SumInto20();
            string number = "785";
            int total = sum.Total20(number);
            Assert.AreEqual("785 sum up 20", sum.Check20OrNot(number, total));
        }

        [TestMethod]
        public void TestCheck20False()
        {
            SumInto20 sum = new SumInto20();
            string number = "765";
            int total = sum.Total20(number);
            Assert.AreEqual("765 don't sum up 20", sum.Check20OrNot(number, total));
        }
    }
}