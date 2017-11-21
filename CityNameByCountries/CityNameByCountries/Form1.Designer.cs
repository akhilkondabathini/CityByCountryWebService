namespace CityNameByCountries
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
            this.btnShowCities = new System.Windows.Forms.Button();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxCountry = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowCities
            // 
            this.btnShowCities.Location = new System.Drawing.Point(392, 32);
            this.btnShowCities.Name = "btnShowCities";
            this.btnShowCities.Size = new System.Drawing.Size(157, 31);
            this.btnShowCities.TabIndex = 0;
            this.btnShowCities.Text = "Show Cities";
            this.btnShowCities.UseVisualStyleBackColor = true;
            this.btnShowCities.Click += new System.EventHandler(this.btnShowCities_Click);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(13, 41);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(98, 17);
            this.lblCountryName.TabIndex = 1;
            this.lblCountryName.Text = "Country Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // txtBxCountry
            // 
            this.txtBxCountry.Location = new System.Drawing.Point(133, 41);
            this.txtBxCountry.Name = "txtBxCountry";
            this.txtBxCountry.Size = new System.Drawing.Size(189, 22);
            this.txtBxCountry.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(133, 95);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 626);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.btnShowCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCities;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCountry;
        private System.Windows.Forms.Label lblResult;
    }
}

