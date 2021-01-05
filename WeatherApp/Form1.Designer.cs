
namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SzukajButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityNameLabel.Location = new System.Drawing.Point(356, 121);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(459, 121);
            this.CityNameLabel.TabIndex = 3;
            this.CityNameLabel.Text = "City Name";
            this.CityNameLabel.Click += new System.EventHandler(this.CityNameLabel_Click);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(504, 275);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(341, 170);
            this.TemperatureLabel.TabIndex = 4;
            this.TemperatureLabel.Text = "20";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Insert city name";
            // 
            // SzukajButton
            // 
            this.SzukajButton.Location = new System.Drawing.Point(726, 51);
            this.SzukajButton.Name = "SzukajButton";
            this.SzukajButton.Size = new System.Drawing.Size(89, 37);
            this.SzukajButton.TabIndex = 6;
            this.SzukajButton.Text = "Search";
            this.SzukajButton.UseVisualStyleBackColor = true;
            this.SzukajButton.Click += new System.EventHandler(this.SzukajButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.sun;
            this.pictureBox1.Location = new System.Drawing.Point(41, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 226);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.BackgroundImage = global::WeatherApp.Properties.Resources.png_clipart_computer_icons_shutdown_button_button_computer_window_thumbnail;
            this.ShutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownButton.Location = new System.Drawing.Point(1004, 12);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(69, 65);
            this.ShutdownButton.TabIndex = 1;
            this.ShutdownButton.UseVisualStyleBackColor = false;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 238);
            this.label1.TabIndex = 7;
            this.label1.Text = "°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SzukajButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShutdownButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SzukajButton;
        private System.Windows.Forms.Label label1;
    }
}

