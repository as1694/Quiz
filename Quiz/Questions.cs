using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Questions
    {
        public string Question { get; private set; }
        public List<string> answer { get; private set; }

        public Questions(string q, List<string> a)
        {
            Question = q;
            answer = a;
        }
    }
}
