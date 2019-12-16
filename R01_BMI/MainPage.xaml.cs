using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double cm = double.Parse(CM.Text);
            double kg = double.Parse(KG.Text);
            double a = cm / 100;
            double c = kg / (a * a);
            double rsl = Math.Round(c);
            DisplayAlert("結果", "あなたのBMIは" + rsl + "です！", "OK");
        }
    }
}
