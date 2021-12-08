using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ModuleThiTracNghiem
{
    public partial class frmThiTracNghiem : Form
    {
        public frmThiTracNghiem()
        {
            InitializeComponent();
            uscClock.uscEClock_Exit += UscClock_uscEClock_Exit;
        }

        private void UscClock_uscEClock_Exit()
        {
            uscClock.Stop();
            MessageBox.Show("Out of Time", "Submit your test", MessageBoxButtons.OK);
            btnSubmit.Enabled = false;
            submit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            this.Hide();

            frm.Show();
        }

        private void frmThiTracNghiem_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello " + Candidates.Name;
        }

        private DateTime currentTime()
        {
            DateTime now = DateTime.Now;

            return now;
        }

        public void submit()
        {
            questionTable.submit();

            uscClock.Stop();

            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "Luu tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin sẽ lưu
                string filePath = dlg.FileName;

                using (var w = XmlWriter.Create(filePath, new XmlWriterSettings() { Indent = true }))
                {
                    w.WriteStartElement("information");
                    w.WriteAttributeString("Time", currentTime().ToString());
                    w.WriteAttributeString("ID", Candidates.ID);
                    w.WriteAttributeString("Name", Candidates.Name);
                    w.WriteAttributeString("Code", Candidates._code);

                    for (int i = 0; i < Candidates._totalQuestion; i++)
                    {
                        w.WriteStartElement("question");

                        w.WriteStartElement("content");
                        w.WriteValue(Candidates._quiz[i]._qContent);
                        w.WriteEndElement();

                        w.WriteStartElement("answer");
                        w.WriteValue(Candidates._answerList[i]);
                        w.WriteEndElement();
                        w.WriteEndElement();
                    }

                    w.WriteEndElement();
                    w.Close();
                }
            }

            MessageBox.Show("Submit Successful!");

            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void btnInputQuiz_Click(object sender, EventArgs e)
        {
            // tạo hộp thoại mở tập tin
            OpenFileDialog dlg = new OpenFileDialog();
            // chỉ mở các tập tin .xml
            dlg.Filter = "Chon tap tin .xml|*.xml";

            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // lấy đường dẫn tập tin đã chọn
                Candidates._pathTestXML = dlg.FileName;
            }

            getTotalQuestionCode();
            LoadQuestionFromTest();
            LoadAnswerFromTest();
            Candidates._answerList = new string[Candidates._totalQuestion];

            //Random defaults list
            Candidates._randomList = indexRandom(4);

            btnStart.Enabled = true;
            btnInputQuiz.Enabled = false;
        }

        //Random List
        public List<int> indexRandom(int amount)
        {
            Random r = new Random();
            List<int> RandomList = new List<int>();

            for (int t = 0; t < Candidates._totalQuestion; t++)
            {
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
                    RandomList.Add(randomIndex);
                }
            }

            return RandomList;
        }

        //Get total amount of question
        static public void getTotalQuestionCode()
        {
            using (var xml = XmlReader.Create(Candidates._pathTestXML))
            {
                xml.ReadToFollowing("totalQuestion");
                xml.MoveToAttribute("Amount");
                Candidates._totalQuestion = int.Parse(xml.Value);

                xml.MoveToAttribute("Code");
                Candidates._code = xml.Value;

                xml.Close();
            }
        }


        //Load all the question from test.xml
        static public void LoadQuestionFromTest()
        {
            using (var xml = XmlReader.Create(Candidates._pathTestXML))
            {
                for (int i = 0; i < (Candidates._totalQuestion); i++)
                {
                    // Add all the question to list
                    xml.ReadToFollowing("question");
                    xml.ReadToFollowing("content");
                    string element = xml.ReadElementContentAsString();
                    quest q = new quest(element);
                    Candidates._quiz.Add(q);
                }
                xml.Close();
            }

        }

        //Load all the question from test.xml
        static public void LoadAnswerFromTest()
        {
            using (var xml = XmlReader.Create(Candidates._pathTestXML))
            {
                for (int i = 0; i < Candidates._totalQuestion; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        // Add question to list<quest> in _quiz attribute
                        xml.ReadToFollowing("answer");
                        string element = xml.ReadElementContentAsString();
                        Candidates._quiz[i]._qAnswer.Add(element);
                    }
                }
                xml.Close();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            int timeTotal = Candidates._totalQuestion * 15;
            uscClock._mm = timeTotal / 60;
            uscClock._ss = timeTotal % 60;
          
            uscClock.Start();
            btnStart.Enabled = false;
            questionTable.Start();
            btnSubmit.Enabled = true;
        }


    }
}
