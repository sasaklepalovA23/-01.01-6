using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СашаЛАБА6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCalc.Enabled = false;
        }

        private void bthCreate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRows.Text, out int n) && int.TryParse(txtCols.Text, out int m) && n > 0 && m > 0)
            {
                dgvMatrix.RowCount = n;
                dgvMatrix.ColumnCount = m;
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = rnd.Next(-50, 51);
                        dgvMatrix.Columns[j].Width = 40;
                    }
                }
                btnCalc.Enabled = true;
            }
            else MessageBox.Show("Введите корректные размеры матрицы!");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int rows = dgvMatrix.RowCount;
            int cols = dgvMatrix.ColumnCount;

            if (chkA.Checked)
            {
                int sumA = 0;
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        int val = Convert.ToInt32(dgvMatrix.Rows[i].Cells[j].Value);
                        if (val < 0 && val % 5 != 0) sumA += val;
                    }
                txtResA.Text = sumA.ToString();
            }


            if (chkB.Checked)
            {
                int countB = 0;
                int minDim = Math.Min(rows, cols);
                for (int i = 0; i < minDim; i++)
                {
                    int val = Convert.ToInt32(dgvMatrix.Rows[i].Cells[i].Value);
                    if (val % 2 == 0) countB++;
                }
                txtResB.Text = countB.ToString();
            }

            if (chkV.Checked)
            {

                if (cols >= 4 && rows >= 2)
                {
                    int sumPosCol4 = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        int val = Convert.ToInt32(dgvMatrix.Rows[i].Cells[3].Value);
                        if (val > 0) sumPosCol4 += val;
                    }

                    int countEvenRow2 = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        int val = Convert.ToInt32(dgvMatrix.Rows[1].Cells[j].Value);
                        if (val % 2 == 0) countEvenRow2++;
                    }

                    long resultV = (long)sumPosCol4 * countEvenRow2;
                    txtResV.Text = resultV.ToString();
                }
                else txtResV.Text = "Размер < 6x6";
            }
        }

        private void bthExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}