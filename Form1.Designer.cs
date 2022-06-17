
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFreeTerms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVector = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSolveJacobi = new System.Windows.Forms.Button();
            this.labelEpsilon = new System.Windows.Forms.Label();
            this.numericUpDownEps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountIter = new System.Windows.Forms.Label();
            this.buttonSolveZeidel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEps)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(78, 15);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Размерность";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewFreeTerms);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewMatrix);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 289);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Свободные \r\nчлены:";
            // 
            // dataGridViewFreeTerms
            // 
            this.dataGridViewFreeTerms.AllowUserToAddRows = false;
            this.dataGridViewFreeTerms.AllowUserToDeleteRows = false;
            this.dataGridViewFreeTerms.AllowUserToResizeColumns = false;
            this.dataGridViewFreeTerms.AllowUserToResizeRows = false;
            this.dataGridViewFreeTerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFreeTerms.ColumnHeadersVisible = false;
            this.dataGridViewFreeTerms.Location = new System.Drawing.Point(432, 38);
            this.dataGridViewFreeTerms.Name = "dataGridViewFreeTerms";
            this.dataGridViewFreeTerms.RowHeadersVisible = false;
            this.dataGridViewFreeTerms.RowHeadersWidth = 20;
            this.dataGridViewFreeTerms.RowTemplate.Height = 20;
            this.dataGridViewFreeTerms.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFreeTerms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewFreeTerms.Size = new System.Drawing.Size(73, 227);
            this.dataGridViewFreeTerms.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Матрица:";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.RowHeadersWidth = 20;
            this.dataGridViewMatrix.RowTemplate.Height = 20;
            this.dataGridViewMatrix.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(423, 227);
            this.dataGridViewMatrix.TabIndex = 8;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(96, 7);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownSize.TabIndex = 2;
            this.numericUpDownSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridViewVector);
            this.panel2.Location = new System.Drawing.Point(554, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 289);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Вектор столбец \r\nнеизвестных:";
            // 
            // dataGridViewVector
            // 
            this.dataGridViewVector.AllowUserToAddRows = false;
            this.dataGridViewVector.AllowUserToDeleteRows = false;
            this.dataGridViewVector.AllowUserToResizeColumns = false;
            this.dataGridViewVector.AllowUserToResizeRows = false;
            this.dataGridViewVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVector.ColumnHeadersVisible = false;
            this.dataGridViewVector.Enabled = false;
            this.dataGridViewVector.Location = new System.Drawing.Point(18, 38);
            this.dataGridViewVector.Name = "dataGridViewVector";
            this.dataGridViewVector.RowHeadersVisible = false;
            this.dataGridViewVector.RowHeadersWidth = 20;
            this.dataGridViewVector.RowTemplate.Height = 20;
            this.dataGridViewVector.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewVector.Size = new System.Drawing.Size(96, 227);
            this.dataGridViewVector.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Входные данные:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 15;
            // 
            // buttonSolveJacobi
            // 
            this.buttonSolveJacobi.Location = new System.Drawing.Point(12, 358);
            this.buttonSolveJacobi.Name = "buttonSolveJacobi";
            this.buttonSolveJacobi.Size = new System.Drawing.Size(141, 30);
            this.buttonSolveJacobi.TabIndex = 16;
            this.buttonSolveJacobi.Text = "Якоби";
            this.buttonSolveJacobi.UseVisualStyleBackColor = true;
            this.buttonSolveJacobi.Click += new System.EventHandler(this.buttonSolveJacobi_Click);
            // 
            // labelEpsilon
            // 
            this.labelEpsilon.AutoSize = true;
            this.labelEpsilon.Location = new System.Drawing.Point(179, 9);
            this.labelEpsilon.Name = "labelEpsilon";
            this.labelEpsilon.Size = new System.Drawing.Size(58, 15);
            this.labelEpsilon.TabIndex = 18;
            this.labelEpsilon.Text = "Точность";
            // 
            // numericUpDownEps
            // 
            this.numericUpDownEps.DecimalPlaces = 3;
            this.numericUpDownEps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownEps.Location = new System.Drawing.Point(243, 9);
            this.numericUpDownEps.Name = "numericUpDownEps";
            this.numericUpDownEps.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownEps.TabIndex = 17;
            this.numericUpDownEps.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество итераций:";
            // 
            // labelCountIter
            // 
            this.labelCountIter.AutoSize = true;
            this.labelCountIter.Location = new System.Drawing.Point(686, 35);
            this.labelCountIter.Name = "labelCountIter";
            this.labelCountIter.Size = new System.Drawing.Size(0, 15);
            this.labelCountIter.TabIndex = 19;
            // 
            // buttonSolveZeidel
            // 
            this.buttonSolveZeidel.Location = new System.Drawing.Point(164, 358);
            this.buttonSolveZeidel.Name = "buttonSolveZeidel";
            this.buttonSolveZeidel.Size = new System.Drawing.Size(132, 30);
            this.buttonSolveZeidel.TabIndex = 20;
            this.buttonSolveZeidel.Text = "Зейделя";
            this.buttonSolveZeidel.UseVisualStyleBackColor = true;
            this.buttonSolveZeidel.Click += new System.EventHandler(this.buttonSolveZeidel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 412);
            this.Controls.Add(this.buttonSolveZeidel);
            this.Controls.Add(this.labelCountIter);
            this.Controls.Add(this.labelEpsilon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownEps);
            this.Controls.Add(this.buttonSolveJacobi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.numericUpDownSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFreeTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSolveJacobi;
        private System.Windows.Forms.Label labelEpsilon;
        private System.Windows.Forms.NumericUpDown numericUpDownEps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountIter;
        private System.Windows.Forms.Button buttonSolveZeidel;
    }
}

