using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReniecWindowsFormsApplication
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

        private void button1_Click(object sender, EventArgs e)
        {
            string token = "tu-token";

            string dni = dniTextBox.Text;

            var client = new RestClient("https://tecactus.com/");

            var request = new RestRequest("api/reniec/dni", Method.POST);
            request.AddParameter("dni", dni);

            // agregando Headers
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);

            // ejecutando el request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            resultTextBox.Text = content;
        }
    }
}
