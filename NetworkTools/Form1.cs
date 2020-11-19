using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenWhoIS_Click(object sender, EventArgs e)
        {
            WHOIS whoisForm = new WHOIS();
            whoisForm.Show();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            PingTool ping = new PingTool();
            ping.Show();
        }

        private void btnIPInfo_Click(object sender, EventArgs e)
        {
            IPLocation ipl = new IPLocation();
            ipl.ShowDialog();
        }
    }
}
