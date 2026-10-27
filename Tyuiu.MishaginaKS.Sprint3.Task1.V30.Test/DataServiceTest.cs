using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint3.Task1.V30.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.5;
            int start = 1;
            int stop = 12;

            double res = ds.GetSumSeries(t, start, stop);

            Assert.AreEqual(3.344, res);
        }
    }
}
