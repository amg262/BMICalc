using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMICalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        void Btn_Clicked(object sender, System.EventArgs e)
        {
            if(!String.IsNullOrEmpty(Inp_height.Text) || !String.IsNullOrEmpty(Inp_weight.Text))
            {
                int height = Int32.Parse(Inp_height.Text);
                double weight = Int32.Parse(Inp_weight.Text);

                double bmi = 703 * (weight / (height * height));

                Lbl_BMI.Text = $"Your BMI is {bmi}.";
                Inp_height.Text = "";
                Inp_weight.Text = "";
            }
            else
            {
                Lbl_BMI.Text = "Enter Height and Weight to get BMI";

            }
        }
    }
}
