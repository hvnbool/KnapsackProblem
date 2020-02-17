using System;
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

            Leaf[] leafs =
            {
                new Leaf(0, 0, 0, new int[]{}, items[0].UnitValue * capacity)
            };


            return items;
        }
    }
}
