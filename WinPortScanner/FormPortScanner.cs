using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPortScanner
{
    public delegate void DisplayResult(string txt, int n);
    public partial class FormPortScanner : Form
    {
        public event DisplayResult displayResult;
        public PortScanner ps;
        private static int NUMBER_OF_THREADS = 53;
        private int id;
        private static string SAVE_RESULT_URL = "http://portscan.atwebpages.com/save_result.php";  // "http://localhost/ports/save_result.php";

        public FormPortScanner(int id)
        {
            this.id = id;
            InitializeComponent();                    
        }

        private void FormPortScanner_Load(object sender, EventArgs e)
        {
            pictureProcessing.Visible = false;
        }

        public void DisplayOutput(string txt, int n)
        {            
            richTextBoxResult.Invoke(new Action(() => AppendText(richTextBoxResult, Color.FromArgb(n), txt)));                        
        }
        
        private void btnScan_Click(object sender, EventArgs e)
        {
            pictureProcessing.Visible = true;
            displayResult = DisplayOutput;
            ps = new PortScanner(txtIp.Text.ToString(),
                                 Int32.Parse(txtStartPort.Text.ToString()), Int32.Parse(txtEndPort.Text.ToString()),
                                 displayResult);
            richTextBoxResult.Clear();
            ps.start(NUMBER_OF_THREADS); //We can start more than one thread here but it will slow down program.
            btnSave.Enabled = true;
        }

        internal void Show(string v) => groupBox1.Text += v;   //to present welcome message to user.

        private void FormPortScanner_FormClosing(Object sender, FormClosingEventArgs e)
        {            
            Environment.Exit(Environment.ExitCode);
        }

         
        // Append text of the given color.
        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }

        public string GetMacAddress() {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    addr += n.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return addr;
        }        

        private void btnStop_Click(object sender, EventArgs e)
        {
            pictureProcessing.Visible = false;
            ps.stop();  // need also to post range of ports in scam and MAC address of machine
            
            for (int i = 0; i < NUMBER_OF_THREADS; i++)
                ps.th[i].Abort();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pictureProcessing.Visible = false;
            string HtmlResult;
            if(ps.stopped && ps.open_ports_list.Length>1)  //will save only if list not empty, and scans stopped.
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                HtmlResult = wc.UploadString(SAVE_RESULT_URL, "uid=" + this.id +
                    "&list=" + ps.open_ports_list + "&mac=" + GetMacAddress() +
                    "&startPort=" + txtStartPort.Text + "&endPort=" + txtEndPort.Text + "&ip=" + txtIp.Text);
            }
            btnSave.Enabled = false;
        }
    }
}
