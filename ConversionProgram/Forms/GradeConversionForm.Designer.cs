namespace ConversionProgram.Forms
{
    partial class GradeConversionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudGradePercentage = new System.Windows.Forms.NumericUpDown();
            this.lblGradeNumber = new System.Windows.Forms.Label();
            this.lblGradeLetter = new System.Windows.Forms.Label();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradePercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGradePercentage
            // 
            this.nudGradePercentage.DecimalPlaces = 2;
            this.nudGradePercentage.Location = new System.Drawing.Point(199, 74);
            this.nudGradePercentage.Name = "nudGradePercentage";
            this.nudGradePercentage.Size = new System.Drawing.Size(120, 22);
            this.nudGradePercentage.TabIndex = 0;
            // 
            // lblGradeNumber
            // 
            this.lblGradeNumber.AutoSize = true;
            this.lblGradeNumber.Location = new System.Drawing.Point(63, 80);
            this.lblGradeNumber.Name = "lblGradeNumber";
            this.lblGradeNumber.Size = new System.Drawing.Size(116, 16);
            this.lblGradeNumber.TabIndex = 1;
            this.lblGradeNumber.Text = "Current Grade (%):";
            // 
            // lblGradeLetter
            // 
            this.lblGradeLetter.AutoSize = true;
            this.lblGradeLetter.Location = new System.Drawing.Point(49, 171);
            this.lblGradeLetter.Name = "lblGradeLetter";
            this.lblGradeLetter.Size = new System.Drawing.Size(44, 16);
            this.lblGradeLetter.TabIndex = 2;
            this.lblGradeLetter.Text = "label1";
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(68, 223);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(251, 72);
            this.btnCalculateLetterGrade.TabIndex = 3;
            this.btnCalculateLetterGrade.Text = "Calculate Letter Grade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            this.btnCalculateLetterGrade.Click += new System.EventHandler(this.btnCalculateLetterGrade_Click);
            // 
            // GradeConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 328);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.lblGradeLetter);
            this.Controls.Add(this.lblGradeNumber);
            this.Controls.Add(this.nudGradePercentage);
            this.Name = "GradeConversionForm";
            this.Text = "Converting a Grade";
            ((System.ComponentModel.ISupportInitialize)(this.nudGradePercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGradePercentage;
        private System.Windows.Forms.Label lblGradeNumber;
        private System.Windows.Forms.Label lblGradeLetter;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
    }
}