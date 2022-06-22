using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinValueConverters
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            txb1.Text = "";
            txb2.Text = "1";
            DisplayAlert(txb2.ToString(), txb2.IsEnabled.ToString(), "Ok");
        }
    }
}
