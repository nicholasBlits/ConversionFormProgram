namespace ConversionProgram.Forms
{
    partial class TimeConversionForm
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
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblHourCount = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblMinuteCount = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblSecondCount = new System.Windows.Forms.Label();
            this.nudNumberOfDays = new System.Windows.Forms.NumericUpDown();
            this.btnConvertTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(127, 116);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(107, 16);
            this.lblNumberOfDays.TabIndex = 0;
            this.lblNumberOfDays.Text = "Number of Days:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(123, 222);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(111, 16);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Number of Hours:";
            // 
            // lblHourCount
            // 
            this.lblHourCount.AutoSize = true;
            this.lblHourCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHourCount.Location = new System.Drawing.Point(291, 222);
            this.lblHourCount.Name = "lblHourCount";
            this.lblHourCount.Size = new System.Drawing.Size(44, 16);
            this.lblHourCount.TabIndex = 2;
            this.lblHourCount.Text = "label3";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(113, 271);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(121, 16);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Number of Minutes:";
            // 
            // lblMinuteCount
            // 
            this.lblMinuteCount.AutoSize = true;
            this.lblMinuteCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMinuteCount.Location = new System.Drawing.Point(291, 271);
            this.lblMinuteCount.Name = "lblMinuteCount";
            this.lblMinuteCount.Size = new System.Drawing.Size(44, 16);
            this.lblMinuteCount.TabIndex = 4;
            this.lblMinuteCount.Text = "label5";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(105, 317);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(129, 16);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "Number of Seconds:";
            // 
            // lblSecondCount
            // 
            this.lblSecondCount.AutoSize = true;
            this.lblSecondCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSecondCount.Location = new System.Drawing.Point(291, 317);
            this.lblSecondCount.Name = "lblSecondCount";
            this.lblSecondCount.Size = new System.Drawing.Size(44, 16);
            this.lblSecondCount.TabIndex = 6;
            this.lblSecondCount.Text = "label7";
            // 
            // nudNumberOfDays
            // 
            this.nudNumberOfDays.Location = new System.Drawing.Point(277, 110);
            this.nudNumberOfDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudNumberOfDays.Name = "nudNumberOfDays";
            this.nudNumberOfDays.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfDays.TabIndex = 7;
            // 
            // btnConvertTime
            // 
            this.btnConvertTime.Location = new System.Drawing.Point(135, 406);
            this.btnConvertTime.Name = "btnConvertTime";
            this.btnConvertTime.Size = new System.Drawing.Size(207, 68);
            this.btnConvertTime.TabIndex = 8;
            this.btnConvertTime.Text = "Convert Time";
            this.btnConvertTime.UseVisualStyleBackColor = true;
            this.btnConvertTime.Click += new System.EventHandler(this.btnConvertTime_Click);
            // 
            // TimeConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 502);
            this.Controls.Add(this.btnConvertTime);
            this.Controls.Add(this.nudNumberOfDays);
            this.Controls.Add(this.lblSecondCount);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinuteCount);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHourCount);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblNumberOfDays);
            this.Name = "TimeConversionForm";
            this.Text = "Converting a Time";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblHourCount;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblMinuteCount;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblSecondCount;
        private System.Windows.Forms.NumericUpDown nudNumberOfDays;
        private System.Windows.Forms.Button btnConvertTime;
    }
}