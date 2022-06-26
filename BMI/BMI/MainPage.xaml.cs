using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
            
        }
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            double weight = 1;
            double height = 1;
        
            double.TryParse(WeightCon.Text, out weight);
            double.TryParse(HeightCon.Text, out height);

            if (weight <= 40 || weight >= 250 || height <= 40 || height >= 280) {
                if (weight <= 40 || weight >= 250)
                {
                    await DisplayAlert("Error", "Check your weight.", "exit");

                }
                if (height <= 40 || height >= 280)
                {
                    await DisplayAlert("Error", "Check your height.", "exit");
                }
            }
            else {
                double BMI = (weight / ((height * height)/10000));

                await Navigation.PushAsync(new ResultPage(BMI = Math.Round(BMI, 2)));
            }


        }
        
    }
}
