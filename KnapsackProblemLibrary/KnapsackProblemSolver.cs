using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblemLibrary
{
    /// <summary>
    /// Class with a method that solves knapsack problem using "branch and bound" method
    /// For that it uses 
    /// </summary>
    public static partial class KnapsackProblemSolver
    {
        public static Item[] FindOptimalSet(Item[] items, int capacity)
        {
            // Clone to keep original array unedited
            items = (Item[])items.Clone();

            // First we sort given items by their unit values
            items = items.OrderBy(c => c.UnitValue).Reverse().ToArray();


            MaxHeap<Leaf> leafs = new MaxHeap<Leaf>((int)Math.Pow(2, items.Length));
            leafs.Add(new Leaf(-1, 0, 0, new int[] { }, items[0].UnitValue * capacity));

            // Best leaf will eventually reference to the leaf of the last level with the most possible total value
            Leaf bestLeaf;

            // Cycle until best leaf is of the last level (which means we made our decisions about each item)
            while (true)
            {
                // Take the best leaf
                bestLeaf = leafs.Pop();

                // Finish if last leaf was for the case where all items have been checked
                if (bestLeaf.Level == items.Length - 1)
                    break;

                // If didn't break there still are items to decide about
                int currentLevel = bestLeaf.Level + 1;

                // Take next item UnitValue (which is 0 if current item is the last)
                double nextItemUnitValue = currentLevel + 1 < items.Length ? items[currentLevel + 1].UnitValue : 0;

                // Add leaf where we don't take current item
                leafs.Add(new Leaf(level: currentLevel,
                    weightSum: bestLeaf.WeightSum,
                    valueSum: bestLeaf.ValueSum,
                    itemsTaken: bestLeaf.ItemsTaken,
                    bestCaseValue: bestLeaf.ValueSum + (capacity - bestLeaf.WeightSum) * nextItemUnitValue));

                // If have enough capacity to put next item
                if (bestLeaf.WeightSum + items[currentLevel].Weight <= capacity)
                {
                    // Add index of new item
                    List<int> newItemsTaken = new List<int>(bestLeaf.ItemsTaken);
                    newItemsTaken.Add(currentLevel);

                    int newWeight = bestLeaf.WeightSum + items[currentLevel].Weight;
                    int newValue = bestLeaf.ValueSum + items[currentLevel].Value;

                    // Add the leaf
                    leafs.Add(new Leaf(
                        level: currentLevel,
                        weightSum: newWeight,
                        valueSum: newValue,
                        itemsTaken: newItemsTaken.ToArray(),
                        bestCaseValue: newValue + (capacity - newWeight) * nextItemUnitValue));
                }
            }

            // For each index in bestLeaf.takenItems take corresponding item and return the array
            return bestLeaf.ItemsTaken.Select(index => items[index]).ToArray();


        }
    }
}
