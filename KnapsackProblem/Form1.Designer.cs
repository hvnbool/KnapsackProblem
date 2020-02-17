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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputDG = new System.Windows.Forms.DataGridView();
            this.thingsNumberInput = new System.Windows.Forms.NumericUpDown();
            this.solveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsNumberInput)).BeginInit();
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
            this.inputDG.Location = new System.Drawing.Point(59, 111);
            this.inputDG.Name = "inputDG";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.inputDG.RowHeadersWidth = 100;
            this.inputDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.inputDG.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.inputDG.Size = new System.Drawing.Size(643, 70);
            this.inputDG.TabIndex = 0;
            this.inputDG.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InputDG_EditingControlShowing);
            // 
            // thingsNumberInput
            // 
            this.thingsNumberInput.Location = new System.Drawing.Point(264, 28);
            this.thingsNumberInput.Maximum = new decimal(new int[] {
            20,
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
            this.solveBtn.Location = new System.Drawing.Point(627, 28);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 2;
            this.solveBtn.Text = "Решить";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.thingsNumberInput);
            this.Controls.Add(this.inputDG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsNumberInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inputDG;
        private System.Windows.Forms.NumericUpDown thingsNumberInput;
        private System.Windows.Forms.Button solveBtn;
    }
}

