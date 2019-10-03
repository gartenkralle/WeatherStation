namespace WindowsFormsApp
{
    partial class Form
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
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(237, 139);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(161, 20);
            this.tbTemperature.TabIndex = 0;
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(237, 179);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(161, 20);
            this.tbPressure.TabIndex = 1;
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(237, 220);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(161, 20);
            this.tbHumidity.TabIndex = 2;
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(161, 142);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(70, 13);
            this.lbTemperature.TabIndex = 3;
            this.lbTemperature.Text = "Temperature:";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(161, 182);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(51, 13);
            this.lbPressure.TabIndex = 4;
            this.lbPressure.Text = "Pressure:";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Location = new System.Drawing.Point(161, 223);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(50, 13);
            this.lbHumidity.TabIndex = 5;
            this.lbHumidity.Text = "Humidity:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 417);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.tbTemperature);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label lbHumidity;
    }
}

