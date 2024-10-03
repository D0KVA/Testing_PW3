using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ComputationalOperations.Tests
{
    [TestClass]
    public class ComputtationalOpTests
    {
        ComputationalOp op = new ComputationalOp();
        [TestMethod]
        public void Root_Discr_is_more_than_0_ReturnTrue()
        {
            ComputationalOp op = new ComputationalOp();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(4);
            CollectionAssert.Equals(op.Root_Combing(1, -5, 4), list);
        }

        [TestMethod]
        public void Root_Discr_is_0_ReturnTrue()
        {
            ComputationalOp op = new ComputationalOp();
            List<double> list = new List<double>();
            list.Add(-1 / 3);
            CollectionAssert.AreEquivalent(op.Root_Combing(9, -6, 1), list);
        }

        [TestMethod]
        public void Root_Discr_is_less_than_0_ReturnTrue()
        {
            ComputationalOp op = new ComputationalOp();
            List<double> list = new List<double>();
            list.Add(1);
            list.Add(52);
            list.Add(14);
            CollectionAssert.AreNotEqual(op.Root_Combing(1, 1, 4), list);
        }

        [TestMethod]
        public void Calculate_200poin2_15point1_ReturnTrue()
        {
            ComputationalOp op = new ComputationalOp();

            double number = 200.2; 
            double percentage = 15.1; 
            double expected = 30.0; 
            double delta = 0.3; 

            double result = op.CalculatePercentage(number, percentage);

            Assert.AreEqual(expected, result, delta, $"Ошибка: {percentage}% от {number} должно быть {expected}, но получено {result}.");
        }
    }
}
