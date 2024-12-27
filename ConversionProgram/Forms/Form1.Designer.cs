namespace ConversionProgram
{
    partial class Form1
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
            this.btnConvertTime = new System.Windows.Forms.Button();
            this.btnConvertGrade = new System.Windows.Forms.Button();
            this.btnConvertAngleMeasurement = new System.Windows.Forms.Button();
            this.btnConvertWeather = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertTime
            // 
            this.btnConvertTime.Location = new System.Drawing.Point(303, 326);
            this.btnConvertTime.Name = "btnConvertTime";
            this.btnConvertTime.Size = new System.Drawing.Size(185, 112);
            this.btnConvertTime.TabIndex = 3;
            this.btnConvertTime.Text = "Convert Time";
            this.btnConvertTime.UseVisualStyleBackColor = true;
            this.btnConvertTime.Click += new System.EventHandler(this.btnConvertTime_Click);
            // 
            // btnConvertGrade
            // 
            this.btnConvertGrade.Location = new System.Drawing.Point(12, 326);
            this.btnConvertGrade.Name = "btnConvertGrade";
            this.btnConvertGrade.Size = new System.Drawing.Size(185, 112);
            this.btnConvertGrade.TabIndex = 4;
            this.btnConvertGrade.Text = "Convert to Letter Grade";
            this.btnConvertGrade.UseVisualStyleBackColor = true;
            this.btnConvertGrade.Click += new System.EventHandler(this.btnConvertGrade_Click);
            // 
            // btnConvertAngleMeasurement
            // 
            this.btnConvertAngleMeasurement.Location = new System.Drawing.Point(303, 12);
            this.btnConvertAngleMeasurement.Name = "btnConvertAngleMeasurement";
            this.btnConvertAngleMeasurement.Size = new System.Drawing.Size(185, 112);
            this.btnConvertAngleMeasurement.TabIndex = 5;
            this.btnConvertAngleMeasurement.Text = "Convert Angle Measurement";
            this.btnConvertAngleMeasurement.UseVisualStyleBackColor = true;
            this.btnConvertAngleMeasurement.Click += new System.EventHandler(this.btnConvertAngleMeasurement_Click);
            // 
            // btnConvertWeather
            // 
            this.btnConvertWeather.Location = new System.Drawing.Point(12, 12);
            this.btnConvertWeather.Name = "btnConvertWeather";
            this.btnConvertWeather.Size = new System.Drawing.Size(185, 112);
            this.btnConvertWeather.TabIndex = 6;
            this.btnConvertWeather.Text = "Convert Temperature";
            this.btnConvertWeather.UseVisualStyleBackColor = true;
            this.btnConvertWeather.Click += new System.EventHandler(this.btnConvertWeather_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(158, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 112);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertWeather);
            this.Controls.Add(this.btnConvertAngleMeasurement);
            this.Controls.Add(this.btnConvertGrade);
            this.Controls.Add(this.btnConvertTime);
            this.Name = "Form1";
            this.Text = "Conversion Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvertTime;
        private System.Windows.Forms.Button btnConvertGrade;
        private System.Windows.Forms.Button btnConvertAngleMeasurement;
        private System.Windows.Forms.Button btnConvertWeather;
        private System.Windows.Forms.Button btnExit;
    }
}

