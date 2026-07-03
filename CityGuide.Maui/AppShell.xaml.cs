namespace CityGuide.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("specialevents", typeof(Views.SpecialEventsPage));
        }

    }
}
