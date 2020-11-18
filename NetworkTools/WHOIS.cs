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
    public partial class WHOIS : Form
    {
        public WHOIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Lookup Button, event not named properly
        {
            NetworkToolMain ntm = new NetworkToolMain(); //Declare main class
            string output = ntm.GetWhoIsInformation(URL.Text); //Get info
            txtOut.Text = output; //output to giant textbox
        }
    }
}
