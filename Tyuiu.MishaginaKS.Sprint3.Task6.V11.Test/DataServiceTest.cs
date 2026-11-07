using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint3.Task6.V11.Lib;
namespace Tyuiu.MishaginaKS.Sprint3.Task6.V11.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidGetSumTheDivisors()

    {
        DataService ds = new DataService();

        int startValue = 10;
        int stopValue = 19;

        int res = ds.GetSumTheDivisors(startValue, stopValue);
        int wait = 9;

        Assert.AreEqual(wait, res);
    }
}
