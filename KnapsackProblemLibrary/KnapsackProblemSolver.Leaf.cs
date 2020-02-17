namespace KnapsackProblemLibrary
{
    public partial class KnapsackProblemSolver
    {
        private class Leaf
        {
            // Total weight of items taken so far
            private int WeightSum { get; }

            // Total value of items taken so far
            private int ValueSum { get; }

            // Index number of last item checked (in an array of items ordered by UnitValue from highest to lowest)
            private int Level { get; }

            // List of IDs of items taken so far
            private int[] ItemsTaken { get; }

            // Total value that can be achieved in the best case (if the next best item fills up the rest of knapsack capacity)
            private double BestCaseValue { get; }

            public Leaf(int level, int weightSum, int valueSum, int[] itemsTaken, double bestCaseValue)
            {
                Level = level;
                WeightSum = weightSum;
                ValueSum = valueSum;
                ItemsTaken = itemsTaken;
                BestCaseValue = bestCaseValue;
            }
        }
    }
}