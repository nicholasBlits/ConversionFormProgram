/*
 *  Program Author: Nicholas S. Blits
 *  Program Version: 1.1.3
 *  Current File: TemperatureForm.cs
 *  
 *  Copyright Notice: All code that is not automatically created by an IDE (such as Visual Studio 2022) has been created by Nicholas S. Blits as of this version. Any unwarranted plaigiarism of this code (the code that has been manually created) is strictly prohibited. Legal action may be taken as appropriate.
 */

// Start of TemperatureForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // This and the above are typical using statements for a Windows Forms Application (that in this particular case, uses the .NET Framework)

namespace ConversionProgram.Forms // The location in which all the program's various Forms are currently stored 
{
    // A Class for Forms that convert values in degrees Fahrenheit to degrees Celsius and vice versa.
    public partial class TemperatureForm : Form
    {
        // Initializing a instance of the TemperatureForm Class
        public TemperatureForm()
        {
            InitializeComponent();
        }


        // Code that executes once the Form's "Convert" Button is clicked.
        // This code first checks which conversion is to be done, and then what is the actual number being converted to the opposite type of weather measurement.
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // At the time the button is clicked, get the values of the Form's two TextBoxes
            // The values are saved as strings, then cast as doubles later

            // The TextBoxes are named tbFahrenheit and tbCelsius, which corresponds to which measurement the user has interest in
            string fahrenheitString = tbFahrenheit.Text;
            string celsiusString = tbCelsius.Text;

            // Check if both TextBoxes were left blank when the button was pressed
            if (fahrenheitString == string.Empty && celsiusString == string.Empty)
            {
                // If both TextBoxes were left blank, display an appropriate error message
                // Error message is displayed in a MessageBox element
                MessageBox.Show("A value must be entered in one of the TextBoxes before a value can be converted.");
            }
            // Code to execute if there is a value in both TextBoxes
            else if (fahrenheitString != string.Empty && celsiusString != string.Empty)
            {
                // Alert the user that one of the TextBoxes must be empty before any numbers can be converted.
                // The alert is displayed in a MessageBox
                MessageBox.Show("One of the TextBoxes on the Form must be empty before a value may be converted.");
            }
            // Reaching this point of this comparison indicates that ONLY one TextBox has a value entered
            else
            {
                // NOTE: The values for Celsius and Fahrenheit are not rounded to any number of decimal places.

                // Check which TextBox has a value entered into it when the Button is clicked
                if (fahrenheitString != string.Empty) // Checking if the Fahrenheit TextBox has a value entered into it
                {
                    // Cast the Fahrenheit TextBox's Text as a double, to then convert it into degrees Celsius
                    double fahrenheitValue = Double.Parse(fahrenheitString);

                    // Doing the math to convert the value of degrees Fahrenheit to degrees Celsius
                    // The math to do so takes the value of degrees Fahrenheit, multiplies it by 5/9, and then finally subtracts 32 degrees from that value
                    double newCelsiusValue = (fahrenheitValue - 32) * 5 / 9;
                    // Setting the TextBox for Celsius' Text to be the newly calculated value for degrees Celsius
                    // Value must be cast as a String to be used as a String element for tbCelsius.Text
                    tbCelsius.Text = newCelsiusValue.ToString();

                    // Warn the user to clear either TextBox before continuing to use the program
                    MessageBox.Show("Please be sure to clear one of the TextBoxes of this Form before clicking the Convert Button again.");
                }
                // The TextBox for Celsius is the one the user wishes to convert
                else
                {
                    // Cast the Celsius TextBox's Text as a double, to then convert it into degrees Fahrenheit
                    double celsiusValue = Double.Parse(celsiusString);

                    // Doing the math to convert the value of degrees Celsius to degrees Fahrenheit
                    // The math to do so takes the value of degrees Fahrenheit, multiplies it by 9/5, and then finally adds 32 degrees from that value
                    double newFahrenheitValue = (celsiusValue * 9 / 5) + 32;
                    // Setting the TextBox for Fahrenheit's Text to be the newly calculated value for degrees Fahrenheit
                    // Value must be cast as a String to be used as a String element for tbFahrenheit.Text
                    tbFahrenheit.Text = newFahrenheitValue.ToString();

                    // Warn the user to clear either TextBox before continuing to use the program
                    MessageBox.Show("Please be sure to clear one of the TextBoxes of this Form before clicking the Convert Button again.");
                }
            }

        }
    }
}
// End of TemperatureForm.cs
