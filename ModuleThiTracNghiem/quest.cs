using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThiTracNghiem
{
    class quest
    {
        public string _qContent { get; set; }
        public List<string> _qAnswer { get; set; } = new List<string>();
        public string _qTopic { get; set; }

        public quest(string content)
        {
            _qContent = content;

        }

        public quest()
        {

        }

    }
}
