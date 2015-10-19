using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BSU.EPAM._1501.Day1.Bychkovksy.Task1;

namespace BSU.EPAM._1501.Day1.Bychkovsky.Task1.Test
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Newton_16pow4_2returned()
        {
            var ExpectedResult = Math.Pow(16,0.25);

            Assert.AreEqual(ExpectedResult, Math.Round(Method.Newton(16, 4, 0.00001), 3));
        }

        [TestMethod]
        public void Newton_minus100pow2_NANreturned()
        {
            double ExpectedResult = double.NaN;

            Assert.AreEqual(ExpectedResult, Method.Newton(-100, 2, 0.00001));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Newton_eps_errorreturned()
        {
            Exception error = new Exception();

            Assert.AreEqual(error, Method.Newton(100, 2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Newton_minuseps_errorreturned()
        {
            Exception error = new Exception();

            Assert.AreEqual(error, Method.Newton(100, 2, -5));
        }
    }
}
