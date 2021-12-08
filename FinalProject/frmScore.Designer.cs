
namespace FinalProject
{
    partial class frmScore
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnImportQB = new System.Windows.Forms.Button();
            this.btnImportQuiz = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblQB = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(323, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImportQB
            // 
            this.btnImportQB.Location = new System.Drawing.Point(267, 12);
            this.btnImportQB.Name = "btnImportQB";
            this.btnImportQB.Size = new System.Drawing.Size(138, 36);
            this.btnImportQB.TabIndex = 2;
            this.btnImportQB.Text = "Question Bank";
            this.btnImportQB.UseVisualStyleBackColor = true;
            this.btnImportQB.Click += new System.EventHandler(this.btnImportQB_Click);
            // 
            // btnImportQuiz
            // 
            this.btnImportQuiz.Location = new System.Drawing.Point(267, 81);
            this.btnImportQuiz.Name = "btnImportQuiz";
            this.btnImportQuiz.Size = new System.Drawing.Size(138, 36);
            this.btnImportQuiz.TabIndex = 2;
            this.btnImportQuiz.Text = "Import Answer Quiz";
            this.btnImportQuiz.UseVisualStyleBackColor = true;
            this.btnImportQuiz.Click += new System.EventHandler(this.btnImportQuiz_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(267, 154);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(138, 36);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblQB
            // 
            this.lblQB.AutoSize = true;
            this.lblQB.Location = new System.Drawing.Point(30, 59);
            this.lblQB.Name = "lblQB";
            this.lblQB.Size = new System.Drawing.Size(80, 13);
            this.lblQB.TabIndex = 3;
            this.lblQB.Text = "Question Bank:";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(30, 104);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(39, 13);
            this.lblImport.TabIndex = 4;
            this.lblImport.Text = "Import:";
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 250);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.lblQB);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnImportQuiz);
            this.Controls.Add(this.btnImportQB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmScore";
            this.Text = "Module Chấm Bài";
            this.Load += new System.EventHandler(this.frmScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnImportQB;
        private System.Windows.Forms.Button btnImportQuiz;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblQB;
        private System.Windows.Forms.Label lblImport;
    }
}