using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThiTracNghiem
{
    static class Candidates
    {
        public static string Name;

        public static string ID;

        public static string _pathTestXML { get; set; }
        public static int _currentIndexQuestion { get; set; } = 0;
        public static int _totalQuestion { get; set; }
        public static string _code { get; set; }

        // question list of test
        public static List<quest> _quiz { get; set; } = new List<quest>();

        // answer list of test
        public static string[] _answerList { get; set; }
        public static List<int> _randomList { get; set; } = new List<int>();
        
        
    }
}
