using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PetBuySell.DataModels;

namespace PetBuySell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Pet> petsList = new List<Pet>
            {
                new Pet{Name = "Bulldog", Price = "50€", Locality = "Čadca", Image = "bulldog" },
                new Pet { Name = "Pes", Price = "50€", Locality = "Čadca", Image = "bulldog" },
            };

            petsListView.ItemsSource = petsList;

            //OnPropertyChanged();


        }

        void BackButtonClicked(object sender, EventArgs e)
        {

        }


    }
}
