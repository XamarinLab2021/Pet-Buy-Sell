using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PetBuySell.DataModels;
using PetBuySell.Model;

namespace PetBuySell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           
            InitializeComponent();

            var PetsList = new PetsList();
            PetsList.AddPet(new Pet("Bulldog", "Dog", "5" + "€", "Žilina", "bulldog.png"));
            petsListView.ItemsSource = PetsList.petsList;

            //OnPropertyChanged();


        }

        void BackButtonClicked(object sender, EventArgs e)
        {

        }


    }
}
