using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public abstract class QuestionBase
    {
        private int _points;
        private string _text;

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public QuestionBase(string text, int points )
        {
            _text = text;
            _points = points;
            
        }

        public abstract bool CheckAnswer(string answer);


    }
}
