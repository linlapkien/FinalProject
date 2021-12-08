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
    public partial class QuestionTable : UserControl
    {
        
        public QuestionTable()
        {
            InitializeComponent();
        }

        // reset radioButton every new queston
        public void resetRadioButton()
        {
            rbtnA.Checked = false;
            rbtnB.Checked = false;
            rbtnC.Checked = false;
            rbtnD.Checked = false;
        }

        public void submit()
        {
            Candidates._answerList[Candidates._currentIndexQuestion] = checkRadioButtonIsChosen();
        }

        public void Start()
        {
            resetRadioButton();

            rbtnA.Enabled = true;
            rbtnB.Enabled = true;
            rbtnC.Enabled = true;
            rbtnD.Enabled = true;

            showQuestion(Candidates._randomList);
        }




        //Show the question
        public void showQuestion(List<int> randomIndex)
        {
            updateIndexQuestion();
            txtContent.Text = Candidates._quiz[Candidates._currentIndexQuestion]._qContent;
            rbtnA.Text = Candidates._quiz[Candidates._currentIndexQuestion]._qAnswer[randomIndex[0 + (Candidates._currentIndexQuestion * 4)]];
            rbtnB.Text = Candidates._quiz[Candidates._currentIndexQuestion]._qAnswer[randomIndex[1 + (Candidates._currentIndexQuestion * 4)]];
            rbtnC.Text = Candidates._quiz[Candidates._currentIndexQuestion]._qAnswer[randomIndex[2 + (Candidates._currentIndexQuestion * 4)]];
            rbtnD.Text = Candidates._quiz[Candidates._currentIndexQuestion]._qAnswer[randomIndex[3 + (Candidates._currentIndexQuestion * 4)]];

            chosenAnswer();
        }

        //Forward and backward show the current answer is chosen
        private void chosenAnswer()
        {
            if (Candidates._answerList[Candidates._currentIndexQuestion] == null)
            {
                return;
            }

            string temp = Candidates._answerList[Candidates._currentIndexQuestion];

            if (rbtnA.Text == temp)
                rbtnA.Checked = true;
            else if (rbtnB.Text == temp)
                rbtnB.Checked = true;
            else if (rbtnC.Text == temp)
                rbtnC.Checked = true;
            else if (rbtnD.Text == temp)
                rbtnD.Checked = true;
            else
                return;
        }
           
        
        //Update question index
        private void updateIndexQuestion()
        {
            if (Candidates._currentIndexQuestion <= 0)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (Candidates._currentIndexQuestion >= Candidates._totalQuestion - 1)
            {
                btnPrevious.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }

            lblQuestionIndex.Text = (Candidates._currentIndexQuestion + 1).ToString();
        }

        //Forward question
        private void btnNext_Click(object sender, EventArgs e)
        {

            Candidates._answerList[Candidates._currentIndexQuestion] = checkRadioButtonIsChosen();

            Candidates._currentIndexQuestion++;
            Start();
            
        }

        //backward question
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            Candidates._answerList[Candidates._currentIndexQuestion] = checkRadioButtonIsChosen();

            Candidates._currentIndexQuestion--;
            Start();
        }

        //Save answer to list
        private string checkRadioButtonIsChosen()
        {
            if (rbtnA.Checked)
                return rbtnA.Text;
            else if (rbtnB.Checked)
                return rbtnB.Text;
            else if (rbtnC.Checked)
                return rbtnC.Text;
            else if (rbtnD.Checked)
                return rbtnD.Text;

            return "0";
        }

       
    }
}
