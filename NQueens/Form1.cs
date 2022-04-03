using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolveNQueens_Click(object sender, EventArgs e)
        {
            var solution = new ForwardChecking(Convert.ToInt32(textBoxNoOfQueens.Text));
            solution.solveNQueens();
            richTextBoxSolution.Text = "";
            var sol = solution.Solutions.Split("-");
            foreach (var queen in sol)
            {
                richTextBoxSolution.Text += queen.Replace(",", ", ") + "\n\n";
            }
        }
    }
}
