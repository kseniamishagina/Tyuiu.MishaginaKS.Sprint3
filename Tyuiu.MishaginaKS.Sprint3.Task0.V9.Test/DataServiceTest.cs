using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint3.Task0.V9.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task0.V9.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double x = 0.5;
            int start = 1;
            int stop = 15;

            double res = ds.GetSumSeries(x, start, stop);

            Assert.AreEqual(0.334, res);
        }
    }
}
    