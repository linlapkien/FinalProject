
namespace FinalProject
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
            this.btnSaveQuestionBank = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxQuestionBank = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInputQuestionBank = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnDeleteQuiz = new System.Windows.Forms.Button();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxCreateQuiz = new System.Windows.Forms.ListBox();
            this.btnSaveQuiz = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveQuestionBank
            // 
            this.btnSaveQuestionBank.Location = new System.Drawing.Point(278, 156);
            this.btnSaveQuestionBank.Name = "btnSaveQuestionBank";
            this.btnSaveQuestionBank.Size = new System.Drawing.Size(190, 23);
            this.btnSaveQuestionBank.TabIndex = 10;
            this.btnSaveQuestionBank.Text = "Save";
            this.btnSaveQuestionBank.UseVisualStyleBackColor = true;
            this.btnSaveQuestionBank.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(353, 83);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(115, 23);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(95, 53);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(160, 20);
            this.txtCorrectAnswer.TabIndex = 1;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(95, 156);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(160, 20);
            this.txtTopic.TabIndex = 5;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(95, 131);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(160, 20);
            this.txtAnswer3.TabIndex = 4;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(95, 79);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(160, 20);
            this.txtAnswer1.TabIndex = 2;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(95, 105);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(160, 20);
            this.txtAnswer2.TabIndex = 3;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(95, 27);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(252, 20);
            this.txtContent.TabIndex = 0;
            this.txtContent.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soạn Đề";
            // 
            // lbxQuestionBank
            // 
            this.lbxQuestionBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxQuestionBank.FormattingEnabled = true;
            this.lbxQuestionBank.Location = new System.Drawing.Point(15, 186);
            this.lbxQuestionBank.Name = "lbxQuestionBank";
            this.lbxQuestionBank.Size = new System.Drawing.Size(453, 238);
            this.lbxQuestionBank.TabIndex = 11;
            this.lbxQuestionBank.SelectedIndexChanged += new System.EventHandler(this.lbxQuestionBank_SelectedIndexChanged);
            this.lbxQuestionBank.DoubleClick += new System.EventHandler(this.lbxQuestionBank_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Correct Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Answer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Topic";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInputQuestionBank);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 424);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // btnInputQuestionBank
            // 
            this.btnInputQuestionBank.Location = new System.Drawing.Point(270, 103);
            this.btnInputQuestionBank.Name = "btnInputQuestionBank";
            this.btnInputQuestionBank.Size = new System.Drawing.Size(190, 40);
            this.btnInputQuestionBank.TabIndex = 0;
            this.btnInputQuestionBank.Text = "Open Question Bank";
            this.btnInputQuestionBank.UseVisualStyleBackColor = true;
            this.btnInputQuestionBank.Click += new System.EventHandler(this.btnInputQuestionBank_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbAmount);
            this.groupBox2.Controls.Add(this.btnDeleteQuiz);
            this.groupBox2.Controls.Add(this.btnAddQuiz);
            this.groupBox2.Controls.Add(this.labelAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbxCreateQuiz);
            this.groupBox2.Controls.Add(this.btnSaveQuiz);
            this.groupBox2.Controls.Add(this.btnScore);
            this.groupBox2.Controls.Add(this.btnCreateQuiz);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(493, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 424);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(184, 118);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(73, 20);
            this.txtCode.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Code: ";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(53, 122);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(13, 13);
            this.lbAmount.TabIndex = 43;
            this.lbAmount.Text = "0";
            // 
            // btnDeleteQuiz
            // 
            this.btnDeleteQuiz.Location = new System.Drawing.Point(91, 96);
            this.btnDeleteQuiz.Name = "btnDeleteQuiz";
            this.btnDeleteQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuiz.TabIndex = 42;
            this.btnDeleteQuiz.Text = "Delete";
            this.btnDeleteQuiz.UseVisualStyleBackColor = true;
            this.btnDeleteQuiz.Click += new System.EventHandler(this.btnDeleteQuiz_Click);
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Location = new System.Drawing.Point(6, 96);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuiz.TabIndex = 42;
            this.btnAddQuiz.Text = "Add";
            this.btnAddQuiz.UseVisualStyleBackColor = true;
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(53, 121);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(0, 13);
            this.labelAmount.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Amount: ";
            // 
            // lbxCreateQuiz
            // 
            this.lbxCreateQuiz.FormattingEnabled = true;
            this.lbxCreateQuiz.Location = new System.Drawing.Point(6, 141);
            this.lbxCreateQuiz.Name = "lbxCreateQuiz";
            this.lbxCreateQuiz.Size = new System.Drawing.Size(409, 277);
            this.lbxCreateQuiz.TabIndex = 39;
            this.lbxCreateQuiz.SelectedIndexChanged += new System.EventHandler(this.lbxCreateQuiz_SelectedIndexChanged);
            this.lbxCreateQuiz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxCreateQuiz_KeyDown);
            // 
            // btnSaveQuiz
            // 
            this.btnSaveQuiz.Enabled = false;
            this.btnSaveQuiz.Location = new System.Drawing.Point(263, 103);
            this.btnSaveQuiz.Name = "btnSaveQuiz";
            this.btnSaveQuiz.Size = new System.Drawing.Size(152, 31);
            this.btnSaveQuiz.TabIndex = 38;
            this.btnSaveQuiz.Text = "Save Quiz";
            this.btnSaveQuiz.UseVisualStyleBackColor = true;
            this.btnSaveQuiz.Click += new System.EventHandler(this.btnSaveQuiz_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(263, 62);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(152, 35);
            this.btnScore.TabIndex = 38;
            this.btnScore.Text = "Score the quiz";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.Enabled = false;
            this.btnCreateQuiz.Location = new System.Drawing.Point(263, 18);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(152, 30);
            this.btnCreateQuiz.TabIndex = 0;
            this.btnCreateQuiz.Text = "Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = true;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(161, 24);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(82, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Amount of question: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveQuestionBank);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxQuestionBank);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " Module Soạn Đề";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveQuestionBank;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxQuestionBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnAddQuiz;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxCreateQuiz;
        private System.Windows.Forms.Button btnDeleteQuiz;
        private System.Windows.Forms.Button btnSaveQuiz;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInputQuestionBank;
    }
}

