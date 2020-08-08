using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace cb_down
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            callMethod();
        }

        public  async Task callMethod()
        {
            Task<string> task = Main();
            string str = await task;
            printLink(str);
        }

        public  void printLink(string dl)
        {
            txtDownLink.Text = dl;
        }

        public  async Task<string> Main()
        {
            string strPck = "";
            if (txtPackgeName.Text.StartsWith("https://"))
            {
                strPck = txtPackgeName.Text.Substring(26);
            }
            else
            {
                strPck = txtPackgeName.Text;
            }

            string json = $@"{{
                    ""properties"": {{
                        ""androidClientInfo"": {{
                        ""sdkVersion"": 22,
                        ""cpu"":""'x86,armeabi-v7a,armeabi'""
                        }}
                    }},
                    ""singleRequest"": {{
                        ""appDownloadInfoRequest"": {{
                        ""downloadStatus"": 1,
                        ""packageName"": ""{strPck}""
                        }}
                    }}
                }}";

            HttpClient client = new HttpClient();
            string dLink = "";
            try
            {
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer **************************");
                HttpResponseMessage response = await client.PostAsync("https://api.cafebazaar.ir/rest-v1/process/AppDownloadInfoRequest", data);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject rss = JObject.Parse(responseBody);

                string pSize = (string)rss["singleReply"]["appDownloadInfoReply"]["packageSize"];
                int pSizeInt =( Convert.ToInt32(pSize)) / 1024 / 1024;
                lblAppSize.Text = Convert.ToString(pSizeInt) + " MB;";
                string rssTitle = (string)rss["singleReply"]["appDownloadInfoReply"]["token"];
                string rssTitle2 = (string)rss["singleReply"]["appDownloadInfoReply"]["cdnPrefix"][0];


                dLink = rssTitle2 + "apks/" + rssTitle+ ".apk";
               

            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.ToString());
            }

            return dLink;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDownLink.Text);
            btnCopy.ForeColor = Color.Red;
            btnCopy.Text = "Copy Done!";
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            string target = txtDownLink.Text;

            try
            {
                System.Diagnostics.Process.Start(target);
            }

            catch (System.ComponentModel.Win32Exception noBrowser)
            {

                if (noBrowser.ErrorCode == -2147467259)

                    MessageBox.Show("!!!مرورگر نصب نمی باشد");

            }

            catch (System.Exception)
            {

                MessageBox.Show("!!!خطای ناشناخته");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDownLink.Text = "";
            txtPackgeName.Text = "";
            lblAppSize.Text = "";
            btnCopy.Text = "Copy!";
            btnCopy.ForeColor = Color.Black;
        }

        private void txtPackgeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDownLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAppSize_Click(object sender, EventArgs e)
        {

        }
    }
}