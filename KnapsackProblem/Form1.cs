using System;
using System.Windows.Forms;
using KnapsackProblemLibrary;
using static KnapsackProblemLibrary.KnapsackProblemSolver;

namespace KnapsackProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //solveBtn.Enabled = false;

            InitializeTable();

            UpdateTable();
            ClearTable();
        }

        public void InitializeTable ()
        {
            inputDG.Columns.Add("header", "");
            var rowHeaders = new string[]{ "Номер", "масса", "стоимость" };

            foreach (var headerText in rowHeaders)
            {
                var row = new DataGridViewRow();
                var headerCell = new DataGridViewRowHeaderCell();

                headerCell.Value = headerText;
                row.HeaderCell = headerCell;

                inputDG.Rows.Add(row);
            }

            string[] vals = new string[thingsNumber];
            for (int i = 0; i < thingsNumber; i++)
            {
                vals[i] = (i + 1).ToString();
            }
            inputDG.Rows[0].SetValues(vals);
        }

        // Ёмкость
        public int capacity
        {
            get => (int)capacityInput.Value;
            set => capacityInput.Value = value;
        }

        // Число предметов
        public int thingsNumber
        {
            get => (int)thingsNumberInput.Value;
            set => thingsNumberInput.Value = value;
        }


        // True  = заполнены все ячейки таблицы
        // False = хотя бы одна не заполнена
        public bool IsDataFilled
        {
            get
            {
                foreach (DataGridViewRow row in inputDG.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null) return false;
                    }
                }

                return true;
            }
        }

        // Данные из таблицы -> двумерный массив интов
        public int[,] ParseData()
        {
            if (!IsDataFilled) throw new Exception("Данные не заполнены");

            var matrix = new int[3, thingsNumber];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < thingsNumber; j++)
                {
                    var cell = inputDG.Rows[i].Cells[j];

                    matrix[i, j] = int.Parse(cell.Value.ToString());
                }
            }

            return matrix;
        }

        // Подстраивает таблицу под новое число вершин, добавляя или удаляя столбцы
        public void UpdateTable()
        {
            int prevColsNumber = inputDG.Columns.Count;

            int delta = thingsNumber - prevColsNumber;

            if (delta > 0)
            {
                for (int i = prevColsNumber; i < thingsNumber; i++)
                {
                    inputDG.Columns.Add("col" + (i+1).ToString(), (i+1).ToString());
                    inputDG.Columns[i].Width = 50;

                    var numberCell = inputDG[i, 0];
                    numberCell.Value = (i + 1).ToString();

                }
            }
            else
            {
                for (int i = prevColsNumber - 1; i >= thingsNumber; i--)
                {
                    inputDG.Columns.RemoveAt(i);
                }

            }

            // Возможно, что при уменьшении размера таблицы не осталось незаполненных вершин
            // тогда кнопка должна стать активной
            //solveBtn.Enabled = IsDataFilled;
        }

        public void ClearTable()
        {
            for (int i = 0; i < inputDG.Columns.Count; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    inputDG[i,j].Value = 0;
                }
            }

            //solveBtn.Enabled = false;
        }

        // Изменение числа вершин
        private void VerticesNumberInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        // На каждую ячейку вешается фильтрующий ввод обработчик события
        private void InputDG_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
            }
        }

        // Фильтрация ввода текста в ячейку таблицы (только цифры)
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            var activeCell = inputDG.SelectedCells[0];

            if (activeCell.RowIndex == 0 ||                             // строка с номером - readOnly
                !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // только цифры
            {
                e.Handled = true;
                return;
            }
        }

        // Проверка заполненности формы по завершение редактирования ячейки таблицы
        private void InputDG_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //solveBtn.Enabled = IsDataFilled;
        }



        private void SolveBtn_Click(object sender, EventArgs e)
        {
            int[,] matrix = ParseData();
            Item[] items = new Item[thingsNumber];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                items[i] = new Item(matrix[0, i], matrix[1, i], matrix[2, i]);
            }

            Item[] result = KnapsackProblemSolver.FindOptimalSet(items, capacity);

            ShowResult(result);
        }

        private void ShowResult(Item[] items)
        {
            string text = "Берём предметы с номерами: ";
            for (int i = 0; i < items.Length; i++)
            {
                text += items[i].Id + " ";
            }
            MessageBox.Show(text, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void thingsNumberInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
