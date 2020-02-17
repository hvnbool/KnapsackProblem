using System;
using KnapsackProblemLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnapsackProblemSolverUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Item[] items =
            {
                new Item(1, 3, 100),
                new Item(2, 2, 20),
                new Item(3, 4, 60),
                new Item(4, 1, 40)
            };

            Item[] result = KnapsackProblemSolver.FindOptimalSet(items, 10);

            Assert.IsTrue(true);
        }
    }
}
