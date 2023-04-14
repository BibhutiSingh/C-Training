using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossformCommunication
{
    public partial class frmWelcome : Form
    {
        public string Name { get; set; }
        public frmWelcome(string name)
        {
            InitializeComponent();
            Name = name;
            lblWelcome.Text = $"Welcome : {Name}";

            
        }
        

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void frmWelcome_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
