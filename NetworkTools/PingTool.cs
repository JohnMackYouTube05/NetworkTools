using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetworkTools.NetworkToolMain;

namespace NetworkTools
{
    public partial class PingTool : Form
    {
        public PingTool()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            NetworkToolMain ntm = new NetworkToolMain();
            txtOutput.Items.Add("Pinging " + txtURL.Text + " with 32 bytes of data...");
            txtOutput.Items.Add(ntm.Ping(txtURL.Text, Convert.ToInt32(nudMilliseconds.Value)));
            

        }
    }
}
