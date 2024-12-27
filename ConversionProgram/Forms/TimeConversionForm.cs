/*
 *  Program Author: Nicholas S. Blits
 *  Program Version: 1.0.0
 *  Current File: TimeConversionForm.cs
 *  
 *  Copyright Notice: All code that is not automatically created by an IDE (such as Visual Studio 2022) has been created by Nicholas S. Blits as of this version. Any unwarranted plaigiarism of this code (the code that has been manually created) is strictly prohibited. Legal action may be taken as appropriate.
 */

// Start of TimeConversionForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // This and the above are typical using statements for a Windows Forms Application (that in this particular case, uses the .NET Framework)

namespace ConversionProgram.Forms // The path in which this file is stored
{
    // A Class for Forms that convert a number of days into hours, minutes, and seconds
    public partial class TimeConversionForm : Form
    {
        // A constructor for every new TimeConversionForm
        public TimeConversionForm()
        {
            InitializeComponent();

            // Making the three labels that store results of the calculations hidden by setting their text elements to empty strings
            lblHourCount.Text = "";
            lblMinuteCount.Text = "";
            lblSecondCount.Text = "";
        }

        // Code to execute when the "Convert Time" Button is clicked
        // This method takes a number of days and displays the number of hours, minutes, and seconds in that number of days to a user through Windows Forms Label elements
        private void btnConvertTime_Click(object sender, EventArgs e)
        {
            // Make a variable to store the number of days entered by the user (through the NumericUpDown element on this Form)
            // The value is cast to an Integer as days are only representable by whole numbers (in the context of this program)
            int numOfDays = (int)nudNumberOfDays.Value;

            // Make three variables - One for the number of hours in the numOfDays variable's value, one for the number of minutes in those hours (assuming a number ending in .00), and one for the number of seconds in those minutes (assuming a number that ends in .00 is returned for the number of minutes)
            // Integers are used for all 3 variables' types to remove the variability found in decimal values
            int numOfHours = numOfDays * 24; // The number of days is multiplied by 24 as there are 24 hours in each day
            int numberOfMinutes = numOfHours * 60; // There are 60 minutes in every hour of every day, so the number of hours is multiplied by 60
            int numberOfSeconds = numberOfMinutes * 60; // Each minute contains 60 seconds, so the number of minutes is multiplied by 60 to calculate the number of seconds. 

            // Setting the labels that display the values for hours, minutes, and seconds to the values as determined above (pays respect to which variable it is, such that numOfSeconds is made out to be the value of the Label for the count of seconds' Text)
            // All the values are cast as Strings in order to be used for their Label's Text element
            lblHourCount.Text = numOfHours.ToString();
            lblMinuteCount.Text = numberOfMinutes.ToString();
            lblSecondCount.Text = numberOfSeconds.ToString();
        }
    }
}
// End of TimeConversionForm.cs