namespace BMI_CALCULATOR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
            //ResultPage = new NavigationPage(new ResultPage());
        }
    }
}
