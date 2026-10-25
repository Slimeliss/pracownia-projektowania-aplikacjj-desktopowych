using System.Collections.ObjectModel;
using System.Windows;

namespace Elektro_Bud0
{
    // Klasa reprezentująca produkt
    public class Product
    {
        //Właściwości produktu
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
    }

    // Główne okno aplikacji
    public partial class MainWindow : Window
    {
        // Lista produktów w magazynie
        public ObservableCollection<Product> ListaProduktow { get; set; }
        // tworzenie głównego okna aplikacji
        public MainWindow()
        {
            InitializeComponent();

            // Tekstowe dane produktów
            ListaProduktow = new ObservableCollection<Product>
            {
                //Produkty w magazynie
                new Product { Id = 1, Nazwa = "Monitor Samsung", Kategoria = "Monitory", Ilosc = 70, Cena = 800m },
                new Product { Id = 2, Nazwa = "Laptop MSI", Kategoria = "Laptopy", Ilosc = 40, Cena = 3500m },
                new Product { Id = 3, Nazwa = "Sluchawki Marshall", Kategoria = "Audio", Ilosc = 85, Cena = 459m },
                new Product { Id = 4, Nazwa = "Iphone 18 Pro", Kategoria = "Telefony", Ilosc = 15, Cena = 6300m }
            };

            // Przypisanie listy produktów do kontrolki ListView
            lvProducts.ItemsSource = ListaProduktow;
        }
    }
}