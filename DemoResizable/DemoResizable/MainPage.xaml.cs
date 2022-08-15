using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace DemoResizable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);

            SplashScreenImage.Source = ImageSource.FromResource("DemoResizable.Assets.Images.splashpage.png", assembly);
            // int ScreenWidth = (int)Resources.DisplayMetrics.WidthPixels;
            //int ScreenHeight = (int)Resources.DisplayMetrics.HeightPixels;            
        }
    }
}
