using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Newtonsoft.Json.Converters;
using static System.Net.WebRequestMethods;
using System.Numerics;
using System.Xml.Linq;

namespace FormApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Roots roots = new Roots();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "https://swapi.dev/api/films/";
            }
            
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "https://swapi.dev/api/people/";
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "https://swapi.dev/api/planets/";
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "https://swapi.dev/api/species/";
            }

            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "https://swapi.dev/api/starships/";

            }

            if (comboBox1.SelectedIndex == 5)
            {
                textBox1.Text = "https://swapi.dev/api/vehicles/";
                
            }
        }
       
        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(textBox1.Text))
                {
                    using (HttpContent content = response.Content)
                    {
                        var options = new JsonSerializerOptions
                        {
                            WriteIndented = true
                        };
                        string mycontent = await content.ReadAsStringAsync();
                        var roots = new Roots
                        {
                            Films = mycontent,
                            People = mycontent,
                            Planets = mycontent,
                            Species = mycontent,
                            Starships = mycontent,
                            Vehicles = mycontent
                        };

                        if (comboBox1.SelectedIndex == 0 )
                        {
                            //string json = JsonConvert.SerializeObject(roots.Films, Formatting.Indented);
                            string jsonFormatted = JValue.Parse(roots.Films).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;

                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            string jsonFormatted = JValue.Parse(roots.People).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            string jsonFormatted = JValue.Parse(roots.Planets).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;
                        }
                        if (comboBox1.SelectedIndex == 3)
                        {
                            string jsonFormatted = JValue.Parse(roots.Species).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;
                        }
                        if (comboBox1.SelectedIndex == 4)
                        {
                            string jsonFormatted = JValue.Parse(roots.Starships).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;
                        }
                        if (comboBox1.SelectedIndex == 5)
                        {
                            string jsonFormatted = JValue.Parse(roots.Vehicles).ToString(Formatting.Indented);
                            richTextBox1.Text = jsonFormatted;
                        }
                     
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
