using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace CreatePrizeForm
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e) //On Create Prize Button Click
        {
            if (ValidateForm()) 
            {
                //Submits the information to the modele
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text, 
                    placeNameValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                    //Clears out fields
                    placeNumberValue.Text = "";
                    placeNameValue.Text = "";
                    prizeAmountValue.Text = "0";
                    prizePercentageValue.Text = "0";
            }
        }

        private bool ValidateForm()
        {
            bool output = true; //If all the if-statments clear then output will be true.
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out int placeNumber); //int placeNumber = 0;

            if (placeNumberValidNumber == false) //No information entered
            {
                MessageBox.Show("Not a valid Place Number.");
                output = false;
            }

            if (placeNumber < 1)
            {
                MessageBox.Show("Not a valid Place Number.");
                output = false;
            }
            
            if (placeNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please Enter in a Place Number.");
                output = false;
            }

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out decimal prizeAmount);//double prizeAmount= 0; Trys and parses the text into a decimal number.
            bool prizePercentValid = double.TryParse(prizePercentageValue.Text, out double prizePercentage); //double prizePercentage= 0; Trys and parses the text into a double number.

            if (prizeAmountValid == false || prizePercentValid == false)
            {
                MessageBox.Show("Neither Prize Amount\nor\nPrize Percentage was Filled out");
                output = false;
            }

            if (prizeAmount <=0 && prizePercentage <=0)
            {
                MessageBox.Show("Neither Prize Amount\nor\nPrize Percentage was Filled out");
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                MessageBox.Show("Prize Percentage is to High or to Low");
                output = false;
            }

            return output;

        }
    }
}
