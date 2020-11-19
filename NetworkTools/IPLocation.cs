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
    public partial class IPLocation : Form
    {
        public IPLocation()
        {
            InitializeComponent();
        }

        private async void btnRetrieve_Click(object sender, EventArgs e)
        {
            NetworkToolMain ntm = new NetworkToolMain();
            txtInfo.Text = await ntm.GetIPInfoAsync(txtURL.Text);
            string ipInfo = txtInfo.Text;
        }
    }
}
