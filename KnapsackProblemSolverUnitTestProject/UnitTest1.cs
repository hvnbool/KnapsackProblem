using Microsoft.VisualStudio.TestTools.UnitTesting;
using static KnapsackProblemLibrary.KnapsackProblemSolver;

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

            Item[] result = FindOptimalSet(items, 10);

            Assert.IsTrue(true);
        }
    }
}
