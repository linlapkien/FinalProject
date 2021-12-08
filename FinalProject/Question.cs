using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Question
    {
        public string        _content { get; set; }
        public string        _correctAnswer { get; set; }
        public List<string>  _listAnswer { get; set; }
        public string        _topic { get; set; }

        

        public Question()
        {
            _listAnswer = new List<string>();
        }

        public Question(string con, string correct)
        {
            _listAnswer = new List<string>();
            _content = con;
            _correctAnswer = correct;
        }

        public Question(string content, string correctAns, string ans1, string ans2, string ans3, string topic)
        {
            _content = content;
            _correctAnswer = correctAns;

            _listAnswer = new List<string>();
            _listAnswer.Add(ans1);
            _listAnswer.Add(ans2);
            _listAnswer.Add(ans3);
            _listAnswer.Add(correctAns);

            _topic = topic;
        }

        public void copyQuestion(string content, string correctAns, string ans1, string ans2, string ans3, string topic)
        {
            _content = content;
            _correctAnswer = correctAns;
            _listAnswer = new List<string>();
            _listAnswer.Add(ans1);
            _listAnswer.Add(ans2);
            _listAnswer.Add(ans3);
            _listAnswer.Add(correctAns);
            _topic = topic;
        }

        public override string ToString()
        {
            return "Topic: " + _topic + " | Question: " + _content + " | Correct Answer: " + _correctAnswer;
        }
    }
}
