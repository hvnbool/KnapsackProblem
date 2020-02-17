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
                new Item(1, 2, 3),
                new Item(2, 2, 4)
            };

            Item[] copyItems = KnapsackProblemSolver.FindOptimalSet(items, 10);
            Assert.IsFalse(items == copyItems);
            for (int i = 0; i < items.Length; i++)
                Assert.IsTrue(items[i].Equals(copyItems[i]));
        }
    }
}
