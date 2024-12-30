/*
 *  Program Author: Nicholas S. Blits
 *  Program Version: 1.1.3
 *  Current File: AngleForm.cs
 *  
 *  Copyright Notice: All code that is not automatically created by an IDE (such as Visual Studio 2022) has been created by Nicholas S. Blits as of this version. Any unwarranted plaigiarism of this code (the code that has been manually created) is strictly prohibited. Legal action may be taken as appropriate.
 */

// Start of AngleForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // This and the above are typical using statements for a Windows Forms Application (that in this particular case, uses the .NET Framework)

namespace ConversionProgram.Forms // The path that this file operates out of
{
    // A Class for Forms that converts angles from either radians to degress or vice versa.
    public partial class AngleForm : Form
    {
        // Creating the instance of the AngleForm Class.
        public AngleForm()
        {
            InitializeComponent();
            
            // Adding the two ways to measure angles as Items to the ComboBox called cbMeasurements
            cbMeasurements.Items.Add("Radians");
            cbMeasurements.Items.Add("Degrees");

            // Setting "Radians" as the selected option by default
            cbMeasurements.SelectedIndex = 0;

            // Hiding the element used to display the conversion from one measurement to the other at runtime by using an empty string
            lblConvertedAngle.Text = "";

            // Informing the user that they must manually turn a value in radians (such as n radians where n is pi) into a numerical value (rounded to two decimal places) like 3.14
           MessageBox.Show("Please Note: If you enter a Radian value, it must be listed as a normalized number, not a fraction that includes Pi. (Ex. 3.14 instead of Pi Radians)", "Warning - Please Read");
        }

        // Code to execute when the "Convert Angle" Button is clicked
        // This method will convert an angle from either degrees to radians, or radians to degrees, based on a user's selection before the button is clicked
        // This method does a manual conversion between the two measurements

        // NOTE: The numbers calculated by this method are not rounded to any number of decimal places.
        private void btnConvertAngle_Click(object sender, EventArgs e)
        {
            // Get the value of the angle, as entered by the user
            // Angle is stored in a variable of type Double
            // The angle's value must be cast to a Double, as a NumericUpDown's standard value type is of type Decimal.
            double angle = (double)nudAngleValue.Value;

            // Check which measurement the angle is measured in
            if (cbMeasurements.SelectedIndex == 0) // Checking if the user entered the angle in Radians or Degrees (if the index is 0, the user chose Radians)
            {
                // Make a variable that contains the result of the math required to turn radians into degrees (which is the angle in radians multipiled by 180 divided by pi.)
                double angleInDegrees = angle * (180 / Math.PI); // Math.PI is an existing object that is used to represent the mathematical constant pi.

                // Setting the Text of the label for the converted angle's measurement to the converted angle as calculated above
                // The element, which is currently saved as a double, must be converted to a String to become the Text of the converted angle's label
                // The value is preceeded by a message indicating what the value as determined above actually means in the converted angle Label's Text
                lblConvertedAngle.Text = angle + " radians is equivalent to " + angleInDegrees.ToString() + " degrees.";
            }
            else // Reaching this point indicates the user is converting an angle from degrees to radians (which will be saved as a normal number and NOT a fraction)
            {
                // Make a variable that contains the result of the math required to turn degrees into radians (which is the angle in degrees multipiled by pi divided by 180.)
                double angleInRadians = angle * (Math.PI / 180); // Math.PI is an exisiting object that is used to represent the mathematical constant pi.

                // Setting the Text of the label for the converted angle's measurement to the converted angle as calculated above
                // The element, which is currently saved as a double, must be converted to a String to become the Text of the converted angle's label
                // The value is preceeded by a message indicating what the value as determined above actually means in the converted angle Label's Text
                lblConvertedAngle.Text = angle + " degrees is equivalent to " + angleInRadians.ToString() + " radians.";
            }
        }
    }
}
// End of AngleForm.cs
