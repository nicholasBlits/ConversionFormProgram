/*
 *  Program Author: Nicholas S. Blits
 *  Program Version: 1.1.3
 *  Current File: GradeConversionForm.cs
 *  
 * Copyright Notice: All code that is not automatically created by an IDE (such as Visual Studio 2022) has been created by Nicholas S. Blits as of this version. Any unwarranted plaigiarism of this code (the code that has been manually created) is strictly prohibited. Legal action may be taken as appropriate.
 */

// Start of GradeConversionForm.cs

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
    // A Class for Forms that convert percentages into letter grades.

    // It is advised that you read the note above the logic for calculating the grade.
    public partial class GradeConversionForm : Form
    {
        // Creating an instance of a GradeConversionForm and calling a default method to make it visible.
        public GradeConversionForm()
        {
            InitializeComponent();

            // Hiding the Label element used for the grade's letter equivalent at runtime
            lblGradeLetter.Text = "";
            // This Label element is reassigned later in this file of the program.
        }

        // NOTE: The logic for what each percentage value means follows the American grading scale.
        // This means that any grade between 97.00% and 100.00% is an A+, a grade between 94.00% and 96.99% is an A, and so on. (Typically the grade lowers in increments of 3% for reference)
        // The exact numbers for the lowest percentage for each grade are provided in the following List of type Double.

        // A List of minimum values for every possible letter grade
        private List<Double> gradeThresholds = new List<Double>();

        // A List of Strings for the letter grades of each grade's threshold
        private List<string> letterGrades = new List<string>();

        // Code to execute when the "Calculate Letter Grade" Button is clicked
        // This code first obtains a value from the Form's NumericUpDown element, then populates the two lists from above, and finally tells the user what their letter grade is based on the value the user enters
        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            // Getting the value of the grade entered by the user
            // The value is cast to the Double type, so that the logic for determining the letter grade of the user can be more precise.
            double gradePercentage = (double)nudGradePercentage.Value;

            // Adding each grade's lower bound to the gradesThreshold List.
            // This will work in the order of A+ - F (which includes all grade's pluses and minuses [An example of every added grade: [A-, B+, B, B-])

            gradeThresholds.Add(97.00); // Numerical equivalent of an A+
            gradeThresholds.Add(94.00); // Numerical equivalent of an A
            gradeThresholds.Add(90.00); // Numerical equivalent of an A-
            gradeThresholds.Add(87.00); // Numerical equivalent of a B+
            gradeThresholds.Add(84.00); // Numerical equivalent of a B
            gradeThresholds.Add(80.00); // Numerical equivalent of a B-
            gradeThresholds.Add(77.00); // Numerical equivalent of a C+
            gradeThresholds.Add(74.00); // Numerical equivalent of a C
            gradeThresholds.Add(70.00); // Numerical equivalent of a C-
            gradeThresholds.Add(67.000); // Numerical equivalent of a D+
            gradeThresholds.Add(64.00); // Numerical equivalent of a D
            gradeThresholds.Add(60.00); // Numerical equivalent of a D-
            gradeThresholds.Add(0.00); // Numerical equivalent of an F

            // Adding each letter grade to the letterGrades List
            // Grades are added to the letterGrades List in correlation with how grade thresholds are added to the gradeThresholds List
            letterGrades.Add("A+");
            letterGrades.Add("A");
            letterGrades.Add("A-");
            letterGrades.Add("B+");
            letterGrades.Add("B");
            letterGrades.Add("B-");
            letterGrades.Add("C+");
            letterGrades.Add("C");
            letterGrades.Add("C-");
            letterGrades.Add("D+");
            letterGrades.Add("D");
            letterGrades.Add("D-");
            letterGrades.Add("F");

            for (int i = 0; i < gradeThresholds.Count; i++) // Iterate through each grade's threshold; Uses a for-loop with a counter variable called i
            {
                if (gradePercentage >= gradeThresholds[i]) // Checking the grade the user entered compared to each individual threshold
                {
                    // When the threshold is met or exceeded, tell the user their final grade
                    lblGradeLetter.Text = "The letter grade equivalent of a " + gradePercentage + "% is a(n): " + letterGrades[i];
                    // Stop the comparison of grade percentages to letter grade thresholds
                    break;
                }
            }
        }
    }
}
// End of GradeConversionForm.cs
