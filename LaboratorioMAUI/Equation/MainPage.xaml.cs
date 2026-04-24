namespace Equation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntA.Text) || string.IsNullOrEmpty(EntB.Text) || string.IsNullOrEmpty(EntC.Text))
            {
                LblRisultato.BackgroundColor = Colors.Orange;
                LblRisultato.Text = "Perfavore inserire i valori in tutti i campi!";
                return;
            }

            if (EntA.Text == "0")
                LblRisultato.Text = "L'equazione non è di secondo grado";

            int delta = 0;
            delta = (int.Parse(EntB.Text) * int.Parse(EntB.Text)) - (4 * int.Parse(EntA.Text) * int.Parse(EntC.Text));
            if (delta > 0)
            {
                double x1 = (-int.Parse(EntB.Text) + Math.Sqrt(delta)) / (2 * int.Parse(EntA.Text));
                double x2 = (-int.Parse(EntB.Text) - Math.Sqrt(delta)) / (2 * int.Parse(EntA.Text));
                LblRisultato.BackgroundColor = Colors.Green;
                LblRisultato.Text = "L'equazione ha due soluzioni: "+ x1 +" e "+ x2;
            }
            else if (delta == 0)
            {
                double x = -int.Parse(EntB.Text) / (2 * int.Parse(EntA.Text));
                LblRisultato.BackgroundColor = Colors.Green;
                LblRisultato.Text = "L'equazione ha una soluzione: " + x;
            }
            else
            {
                LblRisultato.BackgroundColor = Colors.Red;
                LblRisultato.Text = "L'equazione non ha soluzioni reali";
            }
        }

    }
}
