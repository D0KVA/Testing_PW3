using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ComputationalOperations.Tests
{
    [TestClass]
    public class ComputationalOpTests
    {
        private static ComputationalOp op;
        private static List<double> expectedRootsMoreThanZero;
        private static List<double> expectedRootsZero;
        private static List<double> expectedRootsLessThanZero;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            op = new ComputationalOp();
            expectedRootsMoreThanZero = new List<double> { 1, 4 };
            expectedRootsZero = new List<double> { -1/3};
            expectedRootsLessThanZero = new List<double> { 1, 52, 14 };
        }

        [TestMethod]
        public void Root_Discr_is_more_than_0_ReturnTrue()
        {
            CollectionAssert.Equals(expectedRootsMoreThanZero, op.Root_Combing(1, -5, 4));
        }

        [TestMethod]
        public void Root_Discr_is_0_ReturnTrue()
        {
            CollectionAssert.AreEquivalent(expectedRootsZero, op.Root_Combing(9, -6, 1));
        }

        [TestMethod]
        public void Root_Discr_is_less_than_0_ReturnTrue()
        {
            CollectionAssert.AreNotEqual(expectedRootsLessThanZero, op.Root_Combing(1, 1, 4));
        }

        [TestMethod]
        public void Calculate_200poin2_15point1_ReturnTrue()
        {
            double number = 200.2;
            double percentage = 15.1;
            double expected = 30.0;
            double delta = 0.3;

            double result = op.CalculatePercentage(number, percentage);

            Assert.AreEqual(expected, result, delta, $"Ошибка: {percentage}% от {number} должно быть {expected}, но получено {result}.");
        }
    }
}
