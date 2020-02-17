using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnapsackProblemLibrary;

namespace KnapsackProblem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Item[] items =
            {
                new Item(1, 2, 3),
                new Item(2, 2, 4)
            };

            Item[] copyItems = KnapsackProblemSolver.FindOptimalSet(items, 10);
            Console.WriteLine(items == copyItems);
            Console.WriteLine(items.Equals(copyItems));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
