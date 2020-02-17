using System;
using System.Windows.Forms;
using static KnapsackProblemLibrary.KnapsackProblemSolver;

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
                new Item(1, 3, 100),
                new Item(2, 2, 20),
                new Item(3, 4, 60),
                new Item(4, 1, 40)
            };

            Item[] result = FindOptimalSet(items, 10);

            Console.WriteLine();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
