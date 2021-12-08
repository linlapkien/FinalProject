using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Quiz
    {
        public int _amount { get; set; }
        public List<Question> _test { get; set; }

        public string _name { get; set; }
        public string _id { get; set; }
        public string _code { get; set; }
        public string _time { get; set; }

        public Quiz()
        {
            _test = new List<Question>();
        }


    }
}
