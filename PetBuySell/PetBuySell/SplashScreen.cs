using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace PetBuySell
{
    public class SplashScreen : ContentPage
    {
        Image splashImage;
        public void SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "logo.png",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize);

            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.FromHex("e429de3");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
