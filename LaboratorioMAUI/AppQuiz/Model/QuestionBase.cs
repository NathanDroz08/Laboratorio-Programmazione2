using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuiz.Model
{
    public abstract class QuestionBase
    {
        String _text;
        int _points;
        
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public int Points
        {
            get { return _points; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _points = value;
            }
        }

        public QuestionBase(String text, int points)
        {
            Text = text;
            Points = points;
        }

        public abstract bool CheckAnswer(bool answer);
    }
}
