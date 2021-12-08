using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private BindingList<Question> questionBank = new BindingList<Question>();
        private BindingList<Question> createQuiz = new BindingList<Question>();

        public Form1()
        {
            InitializeComponent();
            lbxQuestionBank.DataSource = questionBank;
            lbxCreateQuiz.DataSource = createQuiz;
        }

        //Function support Score the quiz
        private bool checkAllForm()
        {
            if (txtContent.Text == "")
                return false;
            if (txtCorrectAnswer.Text == "")
                return false;
            if (txtAnswer1.Text == "")
                return false;
            if (txtAnswer2.Text == "")
                return false;
            if (txtAnswer3.Text == "")
                return false;
            if (txtTopic.Text == "")
                return false;


            return true;
        }



        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "Luu tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin sẽ lưu
                string filePath = dlg.FileName;

                using (var w = XmlWriter.Create(filePath, new XmlWriterSettings() { Indent = true }))
                {
                    //Write the amount of question in bank
                    w.WriteStartElement("totalQuestion");
                    w.WriteAttributeString("Amount", questionBank.Count().ToString());

                    //loop and write list of question
                    foreach (var q in questionBank)
                    {
                        w.WriteStartElement("question");

                        w.WriteStartElement("content");
                        w.WriteValue(q._content);
                        w.WriteEndElement();

                        w.WriteStartElement("topic");
                        w.WriteValue(q._topic);
                        w.WriteEndElement();

                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[0]);
                        w.WriteEndElement();
                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[1]);
                        w.WriteEndElement();
                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[2]);
                        w.WriteEndElement();

                        w.WriteStartElement("correctAnswer");
                        w.WriteValue(q._correctAnswer);
                        w.WriteEndElement();
                        w.WriteEndElement();

                    }
                    //end of element: amount of question in bank
                    w.WriteEndElement();

                    w.Close();
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int index = lbxQuestionBank.SelectedIndex;

            if (!checkAllForm())
            {
                MessageBox.Show("Cau hoi nhap thieu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };


            if (index > -1)
            {
                questionBank[index].copyQuestion(txtContent.Text, txtCorrectAnswer.Text, txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text, txtTopic.Text);

                questionBank.ResetBindings();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (questionBank.Count > -1)
            {
                int index = lbxQuestionBank.SelectedIndex;
                questionBank.RemoveAt(index);
            }
        }

        //Add new question to question bank
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!checkAllForm())
            {
                MessageBox.Show("Cau hoi nhap thieu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            // Add to list questionBank
            Question q = new Question(txtContent.Text, txtCorrectAnswer.Text, txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text, txtTopic.Text);

            questionBank.Add(q);

            txtContent.Text = String.Empty;
            txtCorrectAnswer.Text = String.Empty;
            txtTopic.Text = String.Empty;
            txtAnswer1.Text = String.Empty;
            txtAnswer2.Text = String.Empty;
            txtAnswer3.Text = String.Empty;
        }

        //Event selected index changed by listBox
        private void lbxQuestionBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxQuestionBank.SelectedIndex;
            if (index > -1)
            {
                txtContent.Text = questionBank[index]._content;
                txtCorrectAnswer.Text = questionBank[index]._correctAnswer;
                txtAnswer1.Text = questionBank[index]._listAnswer[0];
                txtAnswer2.Text = questionBank[index]._listAnswer[1];
                txtAnswer3.Text = questionBank[index]._listAnswer[2];
                txtTopic.Text = questionBank[index]._topic;
            }
        }

        public void loadXMLToQuestionBank(string fileName)
        {
            using (var read = XmlReader.Create(fileName))
            {
                read.ReadToFollowing("totalQuestion");
                while (read.ReadToFollowing("question"))
                {
                    Question q = new Question();

                    read.ReadToFollowing("content");
                    q._content = read.ReadElementContentAsString();

                    read.ReadToFollowing("topic");
                    q._topic = read.ReadElementContentAsString();

                    for (int i = 0; i < 3; i++)
                    {
                        read.ReadToFollowing("answer");
                        q._listAnswer.Add(read.ReadElementContentAsString());
                    }

                    read.ReadToFollowing("correctAnswer");
                    string correctAnswer = read.ReadElementContentAsString();
                    q._listAnswer.Add(correctAnswer);
                    q._correctAnswer = correctAnswer;

                    questionBank.Add(q);
                }
                read.Close();
            }

            btnCreateQuiz.Enabled = true;
            btnSaveQuiz.Enabled = true;

            questionBank.ResetBindings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        // If duplicate question, warming!!
        private bool checkDuplicateQuestion(string question, BindingList<Question> bank)
        {
            foreach (var x in bank)
            {
                if (question == x._content)
                    return true;
            }

            return false;
        }

        //Add question to Quiz
        private void addQuestionToQuiz()
        {
            int index = lbxQuestionBank.SelectedIndex;

            if (checkDuplicateQuestion(questionBank[index]._content, createQuiz))
            {
                MessageBox.Show("Trùng câu hỏi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                createQuiz.Add(questionBank[index]);

            lbAmount.Text = createQuiz.Count().ToString();

            createQuiz.ResetBindings();
        }

        // Double click add question from bank to createTest
        private void lbxQuestionBank_DoubleClick(object sender, EventArgs e)
        {
            addQuestionToQuiz();
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            addQuestionToQuiz();
        }

        //Delete question from quiz
        private void deleteQuestionFromQuiz()
        {
            if (createQuiz.Count > 0)
            {
                int index = lbxCreateQuiz.SelectedIndex;
                createQuiz.RemoveAt(index);
            }
        }

        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {
            deleteQuestionFromQuiz();

            lbAmount.Text = createQuiz.Count().ToString();
        }

        //Press key Delete to delete question
        private void lbxCreateQuiz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteQuestionFromQuiz();
            }

            lbAmount.Text = createQuiz.Count().ToString();
        }


        private void lbxCreateQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxCreateQuiz.SelectedIndex;
            if (index > -1)
            {
                txtContent.Text = createQuiz[index]._content;
                txtCorrectAnswer.Text = createQuiz[index]._correctAnswer;
                txtAnswer1.Text = createQuiz[index]._listAnswer[0];
                txtAnswer2.Text = createQuiz[index]._listAnswer[1];
                txtAnswer3.Text = createQuiz[index]._listAnswer[2];
                txtTopic.Text = createQuiz[index]._topic;
            }
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Input Code of Quiz!", "Error", MessageBoxButtons.OK);
                return;
            }
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "Luu tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin sẽ lưu
                string filePath = dlg.FileName;

                using (var w = XmlWriter.Create(filePath, new XmlWriterSettings() { Indent = true }))
                {
                    //Write the amount of question in bank
                    w.WriteStartElement("totalQuestion");
                    w.WriteAttributeString("Amount", createQuiz.Count().ToString());
                    w.WriteAttributeString("Code", txtCode.Text);


                    //loop and write list of question
                    foreach (var q in createQuiz)
                    {
                        w.WriteStartElement("question");

                        w.WriteStartElement("content");
                        w.WriteValue(q._content);
                        w.WriteEndElement();

                        w.WriteStartElement("topic");
                        w.WriteValue(q._topic);
                        w.WriteEndElement();

                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[0]);
                        w.WriteEndElement();
                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[1]);
                        w.WriteEndElement();
                        w.WriteStartElement("answer");
                        w.WriteValue(q._listAnswer[2]);
                        w.WriteEndElement();

                        w.WriteStartElement("answer");
                        w.WriteValue(q._correctAnswer);
                        w.WriteEndElement();
                        w.WriteEndElement();

                    }
                    //end of amount of question in bank
                    w.WriteEndElement();

                    w.Close();

                    MessageBox.Show("Save quiz successful!", "Notification", MessageBoxButtons.OK);
                }
            }
        }


        //----------------------------------------------------------------------------------------------------
        //-----------------------------------------Module Create Quiz-----------------------------------------
        //----------------------------------------------------------------------------------------------------

        public List<int> indexRandom(int amount)
        {
            Random r = new Random();
            List<int> indexRandomList = new List<int>();

            // Create list of random index
            for (int i = 0; i < amount; i++)
            {
                int randomIndex = 0;
                randomIndex = r.Next(0, amount);

                while (indexRandomList.IndexOf(randomIndex) != -1)
                {
                    randomIndex = r.Next(0, amount);
                }
                indexRandomList.Add(randomIndex);
            }

            return indexRandomList;
        }


        private void removeAllElement(BindingList<Question> list)
        {
            for (int i = 0; i < int.Parse(lbAmount.Text); i++)
            {
                list.RemoveAt(0);
            }
            list.ResetBindings();
        }
         
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Input amount of quiz", "Error", MessageBoxButtons.OK);
                return;
            }

            if (int.Parse(txtAmount.Text) > questionBank.Count)
            {
                MessageBox.Show("Nhập số nhỏ hơn",  "Vượt quá giới hạn câu hỏi!!!", MessageBoxButtons.OK);
                return;
            }

            removeAllElement(createQuiz);

            List<int> randomIndexList = indexRandom(questionBank.Count());

            for (int i = 0; i < int.Parse(txtAmount.Text); i++)
            {
                createQuiz.Add(questionBank[randomIndexList[i]]);
            }

            createQuiz.ResetBindings();
            lbAmount.Text = createQuiz.Count().ToString();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore scoreForm = new frmScore();
            this.Visible = false;

            scoreForm.ShowDialog();

        }


        private void btnInputQuestionBank_Click(object sender, EventArgs e)
        {
            // tạo hộp thoại mở tập tin
            OpenFileDialog dlg = new OpenFileDialog();
            // chỉ mở các tập tin .xml
            dlg.Filter = "Chon tap tin .xml|*.xml";
            string path = "";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin đã chọn
                path = dlg.FileName;
            }

            QuizCreater._filePathQuestionBank = path;
            loadXMLToQuestionBank(path);

        }
    }
}
