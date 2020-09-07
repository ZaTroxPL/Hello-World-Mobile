using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            carousel.ItemsSource = new List<string> { "Quote 1", "Quote 2", "Quote 3", "Quote 4", "Quote 5" };
        }
    }
}
