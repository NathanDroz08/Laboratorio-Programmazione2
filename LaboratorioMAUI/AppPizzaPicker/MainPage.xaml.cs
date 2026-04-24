namespace AppPizzaPicker
{
    public partial class MainPage : ContentPage
    {
        List<string> pizze = new List<string>();
        
        




        public MainPage()
        {
            InitializeComponent();
            
            pizze.Add("Margherita");
            pizze.Add("Diavola");
            pizze.Add("Quattro Stagioni");
            pickPizze.ItemsSource = pizze;

        }

        private void pickPizze_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
