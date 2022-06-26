using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double value)
        {
            InitializeComponent();

            if(value <= 18.49)
            {
                resultBmi.Text = $" {value.ToString()}";
                resultBmi1.Text = "You are underweight. Maintain muscles.";
                maintain.Text = "Maintain muscles (recommendation)";
            }
            else if (value >=18.5 && value <= 24.99)
            {
                resultBmi.Text = $" {value.ToString()}";
                resultBmi1.Text = "You weight is normal. Keep going.";
            }
            else if (value >=25.00 && value <= 29.99)
            {
                resultBmi.Text = $" {value.ToString()}";
                resultBmi1.Text = "You are overweight. Change your habits.";
                Habits.Text = "Change habits (recommendation)";
            }
            else
            {
                resultBmi.Text = $" {value.ToString()}";
                resultBmi1.Text = "You need to slow down. Burn your fat.";
                burning.Text = "fat burning (recommendation)";
               
            }
             
            
        }

        private async void burning_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FatBurningPage());
        }

        private async void maintain_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaintainPage());
        }

        private async void Habits_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HabitsPage());
        }
    }
}