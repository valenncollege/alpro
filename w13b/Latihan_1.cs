using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W13B_Jevon_Valentino_160424066
{
    public partial class Latihan_1 : Form
    {
        public Latihan_1()
        {
            InitializeComponent();
        }

        private void Message(string pName)
        {
            lblMessage.Text = "Welcome " + pName + "!";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Message(name);
        }
    }
}
