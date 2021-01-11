using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;


namespace powerPointGenerator.Forms
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private async void submit_Click(object sender, EventArgs e)
        {
            var response = await Shared.RestHelper.Get((titleBox.Text + " " + bodyBox.Text));
            var beautifiedResponse = Shared.RestHelper.BeautifyJson(response);
            var jo = Newtonsoft.Json.Linq.JObject.Parse(response);
            var imgId = jo["items"][0]["link"].ToString();
            var imgId2 = jo["items"][1]["link"].ToString();
            var imgId3 = jo["items"][2]["link"].ToString();
            var imgId4 = jo["items"][3]["link"].ToString();
            var imgId5 = jo["items"][4]["link"].ToString();
            var imgId6 = jo["items"][5]["link"].ToString();
            var imgId7 = jo["items"][6]["link"].ToString();
            var imgId8 = jo["items"][7]["link"].ToString();
            var imgId9 = jo["items"][8]["link"].ToString();
            textBox1.Text = jo.ToString();
            if (imgId != null) { pictureBox1.ImageLocation = imgId; };
            if (imgId2 != null) { pictureBox2.ImageLocation = imgId2; };
            if (imgId3 != null) { pictureBox3.ImageLocation = imgId3; };
            if (imgId4 != null) { pictureBox4.ImageLocation = imgId4; };
            if (imgId5 != null) { pictureBox5.ImageLocation = imgId5; };
            if (imgId6 != null) { pictureBox6.ImageLocation = imgId6; };
            if (imgId7 != null) { pictureBox7.ImageLocation = imgId7; };
            if (imgId8 != null) { pictureBox8.ImageLocation = imgId8; };
            if (imgId9 != null) { pictureBox9.ImageLocation = imgId9; };



          
        }
    }
}

