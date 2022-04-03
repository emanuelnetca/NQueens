
namespace NQueens
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
            this.textBoxNoOfQueens = new System.Windows.Forms.TextBox();
            this.labelNumberOfQueens = new System.Windows.Forms.Label();
            this.buttonSolveNQueens = new System.Windows.Forms.Button();
            this.richTextBoxSolution = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxNoOfQueens
            // 
            this.textBoxNoOfQueens.Location = new System.Drawing.Point(147, 30);
            this.textBoxNoOfQueens.Name = "textBoxNoOfQueens";
            this.textBoxNoOfQueens.Size = new System.Drawing.Size(43, 27);
            this.textBoxNoOfQueens.TabIndex = 0;
            // 
            // labelNumberOfQueens
            // 
            this.labelNumberOfQueens.AutoSize = true;
            this.labelNumberOfQueens.Location = new System.Drawing.Point(118, 33);
            this.labelNumberOfQueens.Name = "labelNumberOfQueens";
            this.labelNumberOfQueens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumberOfQueens.Size = new System.Drawing.Size(23, 20);
            this.labelNumberOfQueens.TabIndex = 1;
            this.labelNumberOfQueens.Text = "N:";
            // 
            // buttonSolveNQueens
            // 
            this.buttonSolveNQueens.Location = new System.Drawing.Point(213, 27);
            this.buttonSolveNQueens.Name = "buttonSolveNQueens";
            this.buttonSolveNQueens.Size = new System.Drawing.Size(94, 29);
            this.buttonSolveNQueens.TabIndex = 2;
            this.buttonSolveNQueens.Text = "Solve";
            this.buttonSolveNQueens.UseVisualStyleBackColor = true;
            this.buttonSolveNQueens.Click += new System.EventHandler(this.buttonSolveNQueens_Click);
            // 
            // richTextBoxSolution
            // 
            this.richTextBoxSolution.Location = new System.Drawing.Point(118, 63);
            this.richTextBoxSolution.Name = "richTextBoxSolution";
            this.richTextBoxSolution.Size = new System.Drawing.Size(189, 304);
            this.richTextBoxSolution.TabIndex = 3;
            this.richTextBoxSolution.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 406);
            this.Controls.Add(this.richTextBoxSolution);
            this.Controls.Add(this.buttonSolveNQueens);
            this.Controls.Add(this.labelNumberOfQueens);
            this.Controls.Add(this.textBoxNoOfQueens);
            this.Name = "Form1";
            this.Text = "NQueens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNoOfQueens;
        private System.Windows.Forms.Label labelNumberOfQueens;
        private System.Windows.Forms.Button buttonSolveNQueens;
        private System.Windows.Forms.RichTextBox richTextBoxSolution;
    }
}

