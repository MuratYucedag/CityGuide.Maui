using CityGuide.Maui.Views;

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
            var window = new Window(new Views.TransportationPage());
            window.Width = 393;
            window.Height = 652;
            return window;
        }
    }
}