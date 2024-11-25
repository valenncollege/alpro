using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W12A_Jevon_Valentino_160424066
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnFibo_Click(object sender, EventArgs e)
        {
            int bil = int.Parse(txtInput.Text);
            int[] arrA = new int[bil];
            int a = 0, b = 1, c;
            for (int i = 0; i < bil; i++)
            {
                arrA[i] = a;
                c = b + a;
                a = b;
                b = c;
            }
            for (int i = 0; i < arrA.Length; i++)
            {
                lstOut1.Items.Add(arrA[i]);
            }
        }
    }
}
