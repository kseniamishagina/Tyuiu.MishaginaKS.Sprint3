using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint3.Task7.V7.Lib;
namespace Tyuiu.MishaginaKS.Sprint3.Task7.V7.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidGetMassFunction()

    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        int len = stopValue - startValue + 1;
        double[] wait = new double[len];

        wait[0] = 15.31;
        wait[1] = 11.53;
        wait[2] = 0.0;
        wait[3] = 2.46;
        wait[4] = 0.54;
        wait[5] = 1.50;
        wait[6] = -2.42;
        wait[7] = -5.87;
        wait[8] = -9.14;
        wait[9] = -11.41;
        wait[10] = -14.72;

        double[] res = ds.GetMassFunction(startValue, stopValue);

        CollectionAssert.AreEqual(wait, res);
    }
}

