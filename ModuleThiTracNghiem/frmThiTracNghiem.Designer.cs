
namespace ModuleThiTracNghiem
{
    partial class frmThiTracNghiem
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
            this.btnInputQuiz = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.questionTable = new ModuleThiTracNghiem.QuestionTable();
            this.uscClock = new ModuleThiTracNghiem.uscClock();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInputQuiz
            // 
            this.btnInputQuiz.Location = new System.Drawing.Point(443, 5);
            this.btnInputQuiz.Name = "btnInputQuiz";
            this.btnInputQuiz.Size = new System.Drawing.Size(147, 32);
            this.btnInputQuiz.TabIndex = 2;
            this.btnInputQuiz.Text = "Open the exam";
            this.btnInputQuiz.UseVisualStyleBackColor = true;
            this.btnInputQuiz.Click += new System.EventHandler(this.btnInputQuiz_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(443, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(443, 81);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 32);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(91, 5);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 17);
            this.lblHello.TabIndex = 3;
            // 
            // questionTable
            // 
            this.questionTable.Location = new System.Drawing.Point(13, 119);
            this.questionTable.Name = "questionTable";
            this.questionTable.Size = new System.Drawing.Size(582, 290);
            this.questionTable.TabIndex = 4;
            // 
            // uscClock
            // 
            this.uscClock._mm = 0;
            this.uscClock._ss = 0;
            this.uscClock.Location = new System.Drawing.Point(156, 58);
            this.uscClock.Name = "uscClock";
            this.uscClock.Size = new System.Drawing.Size(210, 33);
            this.uscClock.TabIndex = 1;
            // 
            // frmThiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 420);
            this.Controls.Add(this.questionTable);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnInputQuiz);
            this.Controls.Add(this.uscClock);
            this.Controls.Add(this.btnBack);
            this.Name = "frmThiTracNghiem";
            this.Text = "Thi Trắc Nghiệm";
            this.Load += new System.EventHandler(this.frmThiTracNghiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private uscClock uscClock;
        private System.Windows.Forms.Button btnInputQuiz;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblHello;
        private QuestionTable questionTable;
    }
}