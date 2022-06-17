using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            int size = (int)numericUpDownSize.Value;

            dataGridViewMatrix.RowCount = size;
            dataGridViewMatrix.ColumnCount = size;

            dataGridViewFreeTerms.RowCount = size;
            dataGridViewFreeTerms.ColumnCount = 1;

            dataGridViewVector.RowCount = size;
            dataGridViewVector.ColumnCount = 1;
        }

        public double[,] dataGridViewInMassive(DataGridView dataGridView)
        {
            double[,] dArr = new double[dataGridView.RowCount, dataGridView.ColumnCount];
            for (int i = 0; i < dataGridView.RowCount; i++)
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    dArr[i, j] = double.Parse(dataGridView[j, i].Value.ToString());

            return dArr;
        }

        public double[] dataGridViewInMassive(DataGridView dataGridView, int numberColumn)
        {
            double[] dArr = new double[dataGridView.RowCount];
            for (int i = 0; i < dataGridView.RowCount; i++)
                dArr[i] = double.Parse(dataGridView[numberColumn, i].Value.ToString());

            return dArr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            Initialize();
        }

        private void buttonSolveJacobi_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDownSize.Value;
            double eps = (double)numericUpDownEps.Value;

            // Начальная матрицы
            double[,] Matrix = dataGridViewInMassive(dataGridViewMatrix);
            double [] FreeTerms = dataGridViewInMassive(dataGridViewFreeTerms, 0);

            LinearSystem linearSystem = new LinearSystem(size, eps, Matrix, FreeTerms);

            if (!linearSystem.diagonal())
            {
                MessageBox.Show("Не выполняется условие диагонального преобладания матрицы заданной системы");
                return;
            }

            linearSystem.Jacobi();

            for (int i = 0; i < size; i++)
            {
                dataGridViewVector.Rows[i].Cells[0].Value = string.Format("{0:f5}", linearSystem.X[i]);
            }

            labelCountIter.Text = linearSystem.counterIter.ToString();
        }

        private void buttonSolveZeidel_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDownSize.Value;
            double eps = (double)numericUpDownEps.Value;

            // Начальная матрицы
            double[,] Matrix = dataGridViewInMassive(dataGridViewMatrix);
            double[] FreeTerms = dataGridViewInMassive(dataGridViewFreeTerms, 0);

            LinearSystem linearSystem = new LinearSystem(size, eps, Matrix, FreeTerms);

            if (!linearSystem.diagonal())
            {
                MessageBox.Show("Не выполняется условие диагонального преобладания матрицы заданной системы");
                return;
            }

            double norma = linearSystem.norma();
            if (norma > 1)
            {
                MessageBox.Show("Не выполняется условие сходимости метода Зейделя/");
                return;
            }

            linearSystem.Zeidel();

            for (int i = 0; i < size; i++)
            {
                dataGridViewVector.Rows[i].Cells[0].Value = string.Format("{0:f5}", linearSystem.X[i]);
            }

            labelCountIter.Text = linearSystem.counterIter.ToString();
        }
    }
}
