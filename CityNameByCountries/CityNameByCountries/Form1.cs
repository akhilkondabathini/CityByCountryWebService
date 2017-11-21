using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityNameByCountries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void btnShowCities_Click(object sender, EventArgs e)
        {
            CityByCountryService.GlobalWeatherSoapClient client = new CityByCountryService.GlobalWeatherSoapClient();
            var response = client.GetCitiesByCountry(txtBxCountry.Text);
            lblResult.Text = response;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 