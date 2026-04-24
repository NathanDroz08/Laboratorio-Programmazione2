using Quiz.Models;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        private List<QuestionBase> _questions = new List<QuestionBase>();
        private int _currentIndex = 0;
        private int _score = 0;

        public MainPage()
        {
            InitializeCompontent();
            _questions.Add(new TrueFalseQuestion("The sky is blue.", 10, true));
            _questions.Add(new TrueFalseQuestion("The heart is flat", 10, false));
            ShowQuestion(); 
        }

        private void ShowQuestion()
        {
            if (_currentIndex < _questions.Count)
            {
                var question = _questions[_currentIndex];
                QuestionLabel.Text = question.Text;
            }
            else
            {
                QuestionLabel.Text = $"Quiz completed! Your score: {_score}";
                TrueButton.IsEnabled = FalseButton.IsEnabled = false;
            }
        }
    }

}
