using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace c_paises
{
    public partial class FormPaises1 : Form
    {
        public FormPaises1()
        {
            InitializeComponent();
        }

        private void FormPaises1_Load(object sender, EventArgs e)
        {
            WebRequest req;

            req = WebRequest.Create("https://restcountries.eu/rest/v2/all");

            req.ContentType = "application/json";
            WebResponse resp = req.GetResponse();
            Stream strm = resp.GetResponseStream();
            StreamReader strm_reader = new StreamReader(strm);
            string json = strm_reader.ReadToEnd();

            List<Country> Paises = JsonConvert.DeserializeObject<List<Country>>(json);

            var q = from p in Paises
                    orderby p.name ascending
                    select new
                    {
                        País = p.name,
                        Região = p.region,
                        Capital = p.capital,
                        Área = p.area,
                        População = p.population
                    };

            grid_Paises.DataSource = q.ToList();

            //configurar o controlo grid_Paises
            grid_Paises.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_Paises.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_Paises.ReadOnly = true;

        }
    }
}
