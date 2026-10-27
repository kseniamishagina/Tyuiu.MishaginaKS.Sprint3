using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint3.Task2.V6.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task2.V6.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidGetMultiplySeries()

    {
        DataService ds = new DataService();
        double a = 0.25;
        int start = 1;
        int stop = 10;

        double res = ds.GetMultiplySeries(a, start, stop);

        Assert.AreNotEqual(0, res);
    }
}