namespace CityGuide.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("specialevents", typeof(Views.SpecialEventsPage));
            Routing.RegisterRoute("routedetail", typeof(Views.RouteDetailPage));
            Routing.RegisterRoute("routes", typeof(Views.RoutesPage));
            Routing.RegisterRoute("profile", typeof(Views.ProfilePage));
            Routing.RegisterRoute("fooddrinks", typeof(Views.FoodDrinksPage));
        }

    }
}
