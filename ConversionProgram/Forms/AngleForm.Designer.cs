namespace ConversionProgram.Forms
{
    partial class AngleForm
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
            this.cbMeasurements = new System.Windows.Forms.ComboBox();
            this.lblAngleValue = new System.Windows.Forms.Label();
            this.nudAngleValue = new System.Windows.Forms.NumericUpDown();
            this.btnConvertAngle = new System.Windows.Forms.Button();
            this.lblMeasurement = new System.Windows.Forms.Label();
            this.lblConvertedAngle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleValue)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMeasurements
            // 
            this.cbMeasurements.FormattingEnabled = true;
            this.cbMeasurements.Location = new System.Drawing.Point(302, 201);
            this.cbMeasurements.Name = "cbMeasurements";
            this.cbMeasurements.Size = new System.Drawing.Size(121, 24);
            this.cbMeasurements.TabIndex = 0;
            // 
            // lblAngleValue
            // 
            this.lblAngleValue.AutoSize = true;
            this.lblAngleValue.Location = new System.Drawing.Point(189, 68);
            this.lblAngleValue.Name = "lblAngleValue";
            this.lblAngleValue.Size = new System.Drawing.Size(83, 16);
            this.lblAngleValue.TabIndex = 1;
            this.lblAngleValue.Text = "Angle Value:";
            // 
            // nudAngleValue
            // 
            this.nudAngleValue.DecimalPlaces = 2;
            this.nudAngleValue.Location = new System.Drawing.Point(302, 66);
            this.nudAngleValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngleValue.Name = "nudAngleValue";
            this.nudAngleValue.Size = new System.Drawing.Size(120, 22);
            this.nudAngleValue.TabIndex = 2;
            // 
            // btnConvertAngle
            // 
            this.btnConvertAngle.Location = new System.Drawing.Point(175, 292);
            this.btnConvertAngle.Name = "btnConvertAngle";
            this.btnConvertAngle.Size = new System.Drawing.Size(198, 83);
            this.btnConvertAngle.TabIndex = 3;
            this.btnConvertAngle.Text = "Convert Angle";
            this.btnConvertAngle.UseVisualStyleBackColor = true;
            this.btnConvertAngle.Click += new System.EventHandler(this.btnConvertAngle_Click);
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.AutoSize = true;
            this.lblMeasurement.Location = new System.Drawing.Point(137, 204);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(135, 16);
            this.lblMeasurement.TabIndex = 4;
            this.lblMeasurement.Text = "Angle is Measured in:";
            // 
            // lblConvertedAngle
            // 
            this.lblConvertedAngle.AutoSize = true;
            this.lblConvertedAngle.Location = new System.Drawing.Point(34, 425);
            this.lblConvertedAngle.Name = "lblConvertedAngle";
            this.lblConvertedAngle.Size = new System.Drawing.Size(44, 16);
            this.lblConvertedAngle.TabIndex = 5;
            this.lblConvertedAngle.Text = "label1";
            // 
            // AngleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 476);
            this.Controls.Add(this.lblConvertedAngle);
            this.Controls.Add(this.lblMeasurement);
            this.Controls.Add(this.btnConvertAngle);
            this.Controls.Add(this.nudAngleValue);
            this.Controls.Add(this.lblAngleValue);
            this.Controls.Add(this.cbMeasurements);
            this.Name = "AngleForm";
            this.Text = "Converting an Angle";
            ((System.ComponentModel.ISupportInitialize)(this.nudAngleValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMeasurements;
        private System.Windows.Forms.Label lblAngleValue;
        private System.Windows.Forms.NumericUpDown nudAngleValue;
        private System.Windows.Forms.Button btnConvertAngle;
        private System.Windows.Forms.Label lblMeasurement;
        private System.Windows.Forms.Label lblConvertedAngle;
    }
}