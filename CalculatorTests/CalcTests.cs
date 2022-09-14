using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10plus20_expected30()
        {
            //Задаем входные данные arrange
            int a = 10, b = 20;
            int expected = 30;
            //вычисление актуального значения act
            //подключение ссылки, пространство имен namespace
            Calc calc = new Calc();//создали экземпляр класса, чтобы можно было к нему обратится и посчитать значение
            int actual= calc.Sum(a, b);
            //сравниваем ожидаемый и актуальный результат assert
            Assert.AreEqual(expected, actual);

                       
        }
        [TestMethod]
        public void Max_10and20_expected20()
        {
            int a= 10, b=20;
            double expected = 20;
            Calc calc = new Calc();
            double actual= calc.Max(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
