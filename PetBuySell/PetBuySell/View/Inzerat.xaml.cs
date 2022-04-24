using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PetBuySell.Model;
using PetBuySell.DataModels;

namespace PetBuySell.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inzerat : ContentPage
    {
        public Inzerat()
        {
            InitializeComponent();
            var PetsList = new PetsList();
            PetsList.AddPet(new Pet("Bulldog", "Dog", "5" + "€", "Žilina", "bulldog.png"));
            inzeratView.ItemsSource = PetsList.petsList;

        }
        void BackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}