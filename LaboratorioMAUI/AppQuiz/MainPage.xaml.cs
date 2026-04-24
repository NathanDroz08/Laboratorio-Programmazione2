using AppQuiz.Model;

namespace AppQuiz
{
    public partial class MainPage : ContentPage
    {
        private List<QuestionBase> _questions = new List<QuestionBase>();
        private int _currentIndex = 0;
        private int _score = 0;

        public MainPage()
        {
            InitializeComponent();
            _questions.Add(new TrueFalseQuestion("Il C# è un linguaggio a oggetti?", 10, true));
            _questions.Add(new TrueFalseQuestion("Python è un linguaggio compilato?", 0, false));
            ShowQuestion();

        }

        private void ShowQuestion()
        {
            if (_currentIndex < _questions.Count)
            {
                QuestionBase current = _questions[_currentIndex];
                QuestionTextLabel.Text = current.Text;
                ScoreLabel.Text = $"Punteggio: {_score}";
            }
            else
            {
                QuestionTextLabel.Text = $"Fine! Clicca il bottone per vedere i risultati";
                TrueButton.IsEnabled = false;
                FalseButton.IsEnabled = false;
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
                ScoreButton.IsVisible = true;
            }
        }

        private async void OnAnswerClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            bool userAnswer = bool.Parse(btn.CommandParameter.ToString());

            if (_questions[_currentIndex].CheckAnswer(userAnswer))
            {
                _score += _questions[_currentIndex].Points;
                await DisplayAlert("Esatto!", "Hai indovinato!", "OK");
            }
            else
            {
                await DisplayAlert("Errore!", "Riprova alla prossima.", "OK");
            }
            _currentIndex++;
            ShowQuestion();
        }

        private async void OnQuizFinished()
        {
            await Navigation.PushAsync(new ResultPage(_score));
        }

        private void btnScore_Clicked(object sender, EventArgs e)
        {
            OnQuizFinished();
        }

    }

}
