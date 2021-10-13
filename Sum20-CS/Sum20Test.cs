using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
//using Math;


namespace Sum20Test
{
    [TestClass]
    public class Sum20UnitTest
    {
        [Test]
        public void Test1(){
            Assert.IsTrue(Sum20.IsInputValid("973"));
        }
    }
}