﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblemLibrary
{
    public partial class KnapsackProblemSolver
    {
        public static Item[] FindOptimalSet(Item[] items, int capacity)
        {
            // Clone to keep original array unedited
            items = (Item[])items.Clone();

            // First we sort given items by their unit values
            items = items.OrderBy(c => c.UnitValue).Reverse().ToArray();

            
            List<Leaf> leafs = new List<Leaf>()
            {
                new Leaf(-1, 0, 0, new int[]{}, items[0].UnitValue * capacity)
            };

            
            // Best leaf will eventually reference to the leaf of the last level with the most possible total value
            Leaf bestLeaf;

            // Cycle until best leaf is of the last level (which means we made our decisions about each item)
            while (true)
            {

                // Find the best leaf
                double maxBestCaseValue = -1;
                int bestLeafIndex = -1;
                for (int i = 0; i < leafs.Count(); i++)
                {
                    if (leafs[i].BestCaseValue > maxBestCaseValue)
                    {
                        maxBestCaseValue = leafs[i].BestCaseValue;
                        bestLeafIndex = i;
                    }
                }
                bestLeaf = leafs[bestLeafIndex];

                // Finish if this leaf is for the case where all items have been checked
                if (bestLeaf.Level == items.Length - 1)
                    break;

                // If didn't break there still are items to decide about
                leafs.RemoveAt(bestLeafIndex);
                int nextLevel = bestLeaf.Level + 1;

                // Add leaf where we don't take next item
                leafs.Append(new Leaf(bestLeaf.Level,
                    bestLeaf.WeightSum,
                    bestLeaf.ValueSum,
                    bestLeaf.ItemsTaken,
                    bestLeaf.ValueSum + (capacity - bestLeaf.WeightSum) * items[nextLevel].UnitValue));

                // If have enough capacity to put next item
                if (bestLeaf.WeightSum + items[nextLevel].Weight <= capacity)
                {
                    // Add index of new item
                    List<int> newItemsTaken = new List<int>(bestLeaf.ItemsTaken);
                    newItemsTaken.Add(nextLevel);

                    // Add the leaf
                    leafs.Append(new Leaf(bestLeaf.Level,
                        bestLeaf.WeightSum + items[nextLevel].Weight,
                        bestLeaf.ValueSum + items[nextLevel].Value,
                        newItemsTaken.ToArray(),
                        bestLeaf.ValueSum + (capacity - bestLeaf.WeightSum) * items[bestLeaf.Level + 1].UnitValue));
                }
            }

            // For each index in bestLeaf.takenItems take corresponding item and return the array
            return bestLeaf.ItemsTaken.Select(index => items[index]).ToArray();
        }
    }
}
