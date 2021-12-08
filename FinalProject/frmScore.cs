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
    public partial class frmScore : Form
    {
        List<Question> answerList = new List<Question>();
        List<Quiz> quizList = new List<Quiz>();

        private static string folderImport;
        private static string outputScorePath;
        
        public frmScore()
        {
            InitializeComponent();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Visible = true;

            if (QuizCreater._filePathQuestionBank != "")
                frm.loadXMLToQuestionBank(QuizCreater._filePathQuestionBank);

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImportQB_Click(object sender, EventArgs e)
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

            loadAnswerQuestionBank(path);

            
        }

        public void loadAnswerQuestionBank(string fileName)
        {
            using (var read = XmlReader.Create(fileName))
            {
                read.ReadToFollowing("totalQuestion");
                while (read.ReadToFollowing("question"))
                { 
                    Question q = new Question();

                    read.ReadToFollowing("content");
                    q._content = read.ReadElementContentAsString();

                    read.ReadToFollowing("correctAnswer");
                    q._correctAnswer = read.ReadElementContentAsString();

                    answerList.Add(q);
                }
                read.Close();
            }

            string fileN = Path.GetFileName(fileName);
            lblQB.Text = "Question Bank: " + fileN;
        }

        private void btnImportQuiz_Click(object sender, EventArgs e)
        {
            //Get folder path
            FolderBrowserDialog folDlg = new FolderBrowserDialog();
            if (folDlg.ShowDialog() == DialogResult.OK)
            {
                folderImport = folDlg.SelectedPath;
            }

            string fileN = Path.GetFileName(folderImport);
            lblImport.Text = "Folder Import: " + fileN;

            string pattern = "*.xml";
            string[] files = Directory.GetFiles(folderImport, pattern);

            foreach(var f in files)
            {
                loadInfoOfCandidates(f);
            }
        }

        private void loadInfoOfCandidates(string path)
        {
            Quiz quiz = new Quiz();
            using (var read = XmlReader.Create(path))
            {
                read.ReadToFollowing("information");
                read.MoveToAttribute("Code");
                quiz._code = read.Value;
                read.MoveToAttribute("Name");
                quiz._name = read.Value;
                read.MoveToAttribute("ID");
                quiz._id = read.Value;
                read.MoveToAttribute("Time");
                quiz._time = read.Value;

                while (read.ReadToFollowing("question"))
                {
                    read.ReadToFollowing("content");
                    string con = read.ReadElementContentAsString();
                    read.ReadToFollowing("answer");
                    string ans = read.ReadElementContentAsString();

                    quiz._test.Add(new Question(con, ans));
                }

                read.Close();
            }
            quizList.Add(quiz);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // tạo hộp thoại mở tập tin
            SaveFileDialog dlg = new SaveFileDialog();
            // chỉ mở các tập tin .xml
            dlg.Filter = "Chon tap tin .txt|*.txt";
            
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin đã chọn
                outputScorePath = dlg.FileName;
            }

            writeResult();

            MessageBox.Show("Output Successful");
        }

        private void writeResult()
        {
            StreamWriter sw = File.CreateText(outputScorePath);

            //Write the Result to output
            foreach (var q in quizList)
            {
                int score = markTheQuiz(q);
                sw.WriteLine($"Name: {q._name},\tId: {q._id}, \ttime: {q._time}");
                sw.WriteLine($"Code: {q._code}, \tScore: " + score.ToString() + "/" + q._test.Count + "\n");

            }

            sw.Close();
        }

        private int markTheQuiz(Quiz q)
        {
            int score = 0;

            for (int i = 0; i < q._test.Count(); i++)
            {
                foreach (var x in answerList)
                {
                    if(q._test[i]._content == x._content)
                    {
                        if (q._test[i]._correctAnswer == x._correctAnswer)
                        {
                            score++;
                        }
                        break;
                    }
                }
            }

            return score;
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            if (QuizCreater._filePathQuestionBank != "")
            {
                btnImportQB.Enabled = false;
                loadAnswerQuestionBank(QuizCreater._filePathQuestionBank);
            }


        }
    }
}
