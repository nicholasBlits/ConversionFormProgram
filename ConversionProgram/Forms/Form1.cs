/*
 *  Program Author: Nicholas S. Blits
 *  Program Version: 1.1.3
 *  Current File: Form1.cs
 *  
 *  Copyright Notice: All code that is not automatically created by an IDE (such as Visual Studio 2022) has been created by Nicholas S. Blits as of this version. Any unwarranted plagiarism of this code (the code that has been manually created) is strictly prohibited. Legal action may be taken as appropriate.
 */

// Start of Form1.cs

using ConversionProgram.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // This and the above are typical using statements for a Windows Forms Application (that in this particular case, uses the .NET Framework)

namespace ConversionProgram // The namespace of Form1.cs, which contains all the program's core files (such as Program.cs, which is automatically created by Visual Studio 2022)
{
    public partial class Form1 : Form
    {
        // Creating an instance of Form1 and making it visible to the user
        public Form1()
        {
            InitializeComponent();
        }

        // Code to execute when the "Convert Temperature" Button is clicked
        private void btnConvertWeather_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the Form used to convert/calculate temperatures (in degrees Fahrenheit and degrees Celsius)
            TemperatureForm temperatureForm = new TemperatureForm();
            // Make the new instance of the TemperatureForm appear for the user
            temperatureForm.ShowDialog();
        }

        // Code to execute when the "Convert Angle Measurement" Button is clicked
        private void btnConvertAngleMeasurement_Click(object sender, EventArgs e)
        {
            // Creating an instance of an AngleForm
            AngleForm angleForm = new AngleForm();
            // Displaying that AngleForm instance to the user.
            angleForm.ShowDialog();
        }

        // Code to execute when the "Convert to Letter Grade" Button is clicked
        private void btnConvertGrade_Click(object sender, EventArgs e)
        {
            // Create a new instance of the GradeConversionForm class, so a user may compare their grade's percentage to a letter grade
            GradeConversionForm gradeConversionForm = new GradeConversionForm();
            // Make the new GradeConversionForm Object created above visible to the user.
            gradeConversionForm.ShowDialog();
        }

        // Code to execute when the "Convert Time" Button is clicked
        private void btnConvertTime_Click(object sender, EventArgs e)
        {
            // Making a new TimeConversionForm Object
            TimeConversionForm timeConversionForm = new TimeConversionForm();
            // Making the user able to see the object that was just created
            timeConversionForm.ShowDialog();
        }

        // Code to execute when the "Exit Program" Button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Create a DialogResult Object to store the option a user selects from a MessageBox with Buttons for "Yes" and "No"
            // Create a MessageBox asking the user if they are sure that they wish to exit the program
            // The MessageBox has a caption further clarifying what clicking "Yes" and "No" will individually do (if the standard message does not make that clear already)
            DialogResult result = MessageBox.Show("Are you sure you wish to close out the program?", "Close the Program?", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes) // Checking if the user selected the "Yes" option as provided by the above MessageBox
            {
                // Terminating the program if and only if the user selected "Yes"
                Application.Exit();
            }
            // There is no special code to execute if the user selected "No".
        }
    }
}
// End of Form1.cs