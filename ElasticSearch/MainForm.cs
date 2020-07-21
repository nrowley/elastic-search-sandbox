using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;


namespace ElasticSearch
{
    public partial class MainForm : Form
    {
        public const string uri = "http://localhost:9200";
        HttpClient client = new HttpClient();
        public MainForm()
        {
            InitializeComponent();
            
          
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string json = messageBox.Text;
            string url = uri + urlBox.Text;
            HttpResponseMessage response;
            switch (methodBox.SelectedItem)
            {
                case "PUT":
                    response = await client.PutAsync(url,new StringContent(json,Encoding.UTF8,"application/json"));
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        responseBox.Text = responseBody;
                    }
                    break;
                case "GET":
                    response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        responseBox.Text = FormatJson(responseBody);
                    }
                    break;
                case "POST":
                    response = await client.PostAsync(url,new StringContent(json,Encoding.UTF8,"application/json"));
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        responseBox.Text = responseBody;
                    }
                    break;
                case "DELETE":
                    response = await client.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        responseBox.Text = responseBody;
                    }
                    break;
            }
        }

        private string FormatJson(string json)
        {
            return json.Replace(",", "\n");
        }
    
    }
}
