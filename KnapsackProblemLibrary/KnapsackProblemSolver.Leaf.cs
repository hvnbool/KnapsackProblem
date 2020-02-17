using System;

namespace KnapsackProblemLibrary
{
    public static partial class KnapsackProblemSolver
    {
        private class Leaf : IComparable<Leaf>
        {
            // Total weight of items taken so far
            public int WeightSum { get; }

            // Total value of items taken so far
            public int ValueSum { get; }

            // Index number of last item checked (in an array of items ordered by UnitValue from highest to lowest)
            public int Level { get; }

            // List of IDs of items taken so far
            public int[] ItemsTaken { get; }

            // Total value that can be achieved in the best case (if the next best item fills up the rest of knapsack capacity)
            public double BestCaseValue { get; }

            public Leaf(int level, int weightSum, int valueSum, int[] itemsTaken, double bestCaseValue)
            {
                Level = level;
                WeightSum = weightSum;
                ValueSum = valueSum;
                ItemsTaken = itemsTaken;
                BestCaseValue = bestCaseValue;
            }

            public int CompareTo(Leaf other)
            {
                if (ReferenceEquals(this, other)) return 0;
                if (ReferenceEquals(null, other)) return 1;
                return BestCaseValue.CompareTo(other.BestCaseValue);
            }
        }
    }
}