using CityGuide.Maui.Models;
using CityGuide.Maui.Services;

namespace CityGuide.Maui.Views;

public partial class CulturePage : ContentPage
{
    private readonly AppDatabase _db = new AppDatabase();
    private List<Event> _allEvents = new List<Event>();
    public CulturePage()
    {
        InitializeComponent();
    }

    // Sayfa ekrana geldiðinde çalýþýr
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // --- Kategoriler ---
        var categories = await _db.GetCategoriesAsync();
        categories.Insert(0, new Category { Id = 0, CategoryName = "Tümü" });
        CategoriesCollection.ItemsSource = categories;

        // --- Etkinlikler: bir kez çek, bellekte sakla ---
        _allEvents = await _db.GetEventsWithCategoryAsync();
        EventsCollection.ItemsSource = _allEvents;

        // Baþlangýçta "Tümü" seçili olsun (listenin ilk öðesi)
        CategoriesCollection.SelectedItem = categories[0];
    }

    // Bir kategori seçilince çalýþýr
    private void OnCategorySelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Seçili öðeyi al
        if (e.CurrentSelection.FirstOrDefault() is not Category category)
            return;

        if (category.Id == 0)
        {
            // "Tümü" -> hepsini göster
            EventsCollection.ItemsSource = _allEvents;
        }
        else
        {
            // Seçilen kategoriye ait etkinlikleri süz
            var filtered = _allEvents
                .Where(ev => ev.CategoryId == category.Id)
                .ToList();

            EventsCollection.ItemsSource = filtered;
        }
    }

    // Bir kategori hapýna týklanýnca çalýþýr
    private void OnCategoryTapped(object sender, TappedEventArgs e)
    {
        // Týklanan hapýn baðlý olduðu kategori nesnesini al
        if (sender is not Border border) return;
        if (border.BindingContext is not Category category) return;

        if (category.Id == 0)
        {
            // "Tümü" -> hepsini göster
            EventsCollection.ItemsSource = _allEvents;
        }
        else
        {
            // Seçilen kategoriye ait etkinlikleri süz
            var filtered = _allEvents
                .Where(ev => ev.CategoryId == category.Id)
                .ToList();

            EventsCollection.ItemsSource = filtered;
        }
    }
}