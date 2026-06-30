namespace CityGuide.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new Views.LoginPage());

            // Telefon boyutuna yakın bir pencere (iPhone 15 ~ 393x852)
            window.Width = 393;
            window.Height = 652;

            return window;
        }
    }
}