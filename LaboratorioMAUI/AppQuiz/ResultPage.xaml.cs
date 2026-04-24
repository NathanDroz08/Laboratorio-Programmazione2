namespace AppQuiz;

public partial class ResultPage : ContentPage
{
	public ResultPage(int currentScore)
	{
		InitializeComponent();
        FinalScoreLabel.Text = $"Il tuo punteggio finale è: {currentScore}";
    }
}
