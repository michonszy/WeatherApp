using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;



namespace WeatherApp
{

 
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void SzukajButton_Click(object sender, EventArgs e)
        {

            string miasto;
            miasto = textBox1.Text;
          

            string url = String.Format("http://api.weatherapi.com/v1/current.xml?key=53f0dce159204904bda210003210501&q="+miasto);
            
            XDocument doc = XDocument.Load(url);
            string CityName = (string)doc.Descendants("name").FirstOrDefault();
            string TempC = (string)doc.Descendants("temp_c").FirstOrDefault();

            WebClient client = new WebClient();
            string Icon = (string)doc.Descendants("icon").FirstOrDefault();
            byte[] image = client.DownloadData("http:" + Icon);
            MemoryStream stream = new MemoryStream(image);
            Bitmap newBitMap = new Bitmap(stream);
            Bitmap icon = newBitMap;
        

            CityNameLabel.Text = CityName;
            TemperatureLabel.Text = TempC;
            pictureBox1.Image = icon;
        }

        private void CityNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
