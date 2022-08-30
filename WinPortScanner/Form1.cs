using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPortScanner
{
    public partial class Form1 : Form
    {
        private static string LOGIN_URL = "http://portscan.atwebpages.com/login_check.php";
        private static string REGISTER_URL = "http://portscan.atwebpages.com/register.html";

        public int id {set; get;}
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string HtmlResult;
            using (WebClient wc = new WebClient()) {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                HtmlResult = wc.UploadString(LOGIN_URL, "e="+email+"&w="+password);
                int start = HtmlResult.IndexOf("(");
                int end = HtmlResult.IndexOf(")");
                if (HtmlResult.Contains("Welcome:"))
                    this.id = int.Parse(HtmlResult.Substring(start+1, (end-start-1) ));                
            }
            if (HtmlResult.Contains("Welcome:"))
            {
                FormPortScanner frmPortScanner = new FormPortScanner(this.id);
                frmPortScanner.Show(HtmlResult.Substring(HtmlResult.IndexOf("Welcome")+8));
                frmPortScanner.Show();
            }
            else
            {
                labelBadLogin.Text = "Bad Login!";
                System.Diagnostics.Process.Start(REGISTER_URL);
            }
            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            //textBoxEmail.Text = "";
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "your email")
            textBoxEmail.Clear();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
                textBoxEmail.Text = "your email";
        }
    }
}
