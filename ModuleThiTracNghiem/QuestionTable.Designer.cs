
namespace ModuleThiTracNghiem
{
    partial class QuestionTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestionIndex = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Enabled = false;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(3, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(574, 81);
            this.txtContent.TabIndex = 0;
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Enabled = false;
            this.rbtnA.Location = new System.Drawing.Point(13, 108);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(32, 17);
            this.rbtnA.TabIndex = 1;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Enabled = false;
            this.rbtnB.Location = new System.Drawing.Point(304, 108);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(32, 17);
            this.rbtnB.TabIndex = 2;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Enabled = false;
            this.rbtnC.Location = new System.Drawing.Point(13, 180);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(32, 17);
            this.rbtnC.TabIndex = 1;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Enabled = false;
            this.rbtnD.Location = new System.Drawing.Point(304, 180);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(33, 17);
            this.rbtnD.TabIndex = 2;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(76, 238);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(142, 29);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(350, 238);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblQuestionIndex
            // 
            this.lblQuestionIndex.AutoSize = true;
            this.lblQuestionIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionIndex.Location = new System.Drawing.Point(264, 238);
            this.lblQuestionIndex.Name = "lblQuestionIndex";
            this.lblQuestionIndex.Size = new System.Drawing.Size(0, 29);
            this.lblQuestionIndex.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(49, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // QuestionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQuestionIndex);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.rbtnD);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuestionTable";
            this.Size = new System.Drawing.Size(580, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuestionIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
