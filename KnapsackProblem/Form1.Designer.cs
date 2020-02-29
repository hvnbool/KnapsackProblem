namespace KnapsackProblem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputDG = new System.Windows.Forms.DataGridView();
            this.thingsNumberInput = new System.Windows.Forms.NumericUpDown();
            this.solveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capacityInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDG
            // 
            this.inputDG.AllowUserToAddRows = false;
            this.inputDG.AllowUserToDeleteRows = false;
            this.inputDG.AllowUserToResizeColumns = false;
            this.inputDG.AllowUserToResizeRows = false;
            this.inputDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.inputDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDG.ColumnHeadersVisible = false;
            this.inputDG.Location = new System.Drawing.Point(9, 111);
            this.inputDG.Name = "inputDG";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inputDG.RowHeadersWidth = 100;
            this.inputDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.inputDG.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.inputDG.Size = new System.Drawing.Size(757, 109);
            this.inputDG.TabIndex = 0;
            this.inputDG.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InputDG_EditingControlShowing);
            // 
            // thingsNumberInput
            // 
            this.thingsNumberInput.Location = new System.Drawing.Point(264, 28);
            this.thingsNumberInput.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.thingsNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thingsNumberInput.Name = "thingsNumberInput";
            this.thingsNumberInput.Size = new System.Drawing.Size(120, 20);
            this.thingsNumberInput.TabIndex = 1;
            this.thingsNumberInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.thingsNumberInput.ValueChanged += new System.EventHandler(this.thingsNumberInput_ValueChanged);
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(480, 40);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(128, 42);
            this.solveBtn.TabIndex = 2;
            this.solveBtn.Text = "Get the answer!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // capacityInput
            // 
            this.capacityInput.Location = new System.Drawing.Point(264, 70);
            this.capacityInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacityInput.Name = "capacityInput";
            this.capacityInput.Size = new System.Drawing.Size(120, 20);
            this.capacityInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 229);
            this.Controls.Add(this.capacityInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.thingsNumberInput);
            this.Controls.Add(this.inputDG);
            this.Name = "Form1";
            this.Text = "Knapsack Problem Solver";
            ((System.ComponentModel.ISupportInitialize)(this.inputDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputDG;
        private System.Windows.Forms.NumericUpDown thingsNumberInput;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown capacityInput;
    }
}

