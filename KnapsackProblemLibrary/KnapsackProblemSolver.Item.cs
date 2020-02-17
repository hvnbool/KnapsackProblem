namespace KnapsackProblemLibrary
{
    public static partial class KnapsackProblemSolver
    {
        /// <summary>
        /// Class that represents an item for knapsack problem
        /// </summary>
        public class Item
        {
            public int Id { get; protected set; }
            public int Weight { get; protected set; }
            public int Value { get; protected set; }
            public double UnitValue { get; protected set; }

            public Item(int id, int weight, int value)
            {
                Id = id;
                Weight = weight;
                Value = value;
                UnitValue = (double) value / weight;
            }
        }
    }
}