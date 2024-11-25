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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> listNo1 = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number =int.Parse(txtInput.Text);            
            while(number != 0)
            {
                listNo1.Add(number % 10);
                number /= 10;
            }
            string temp = "";
            for (int i = listNo1.Count-1; i >= 0; i--)
            {
                temp = temp + listNo1[i] + " ";
            }
            lstOut1.Items.Add(temp);
        }
        List<int> listOdd = new List<int>();
        List<int> listEven = new List<int>();

        private void btnSeparate_Click(object sender, EventArgs e)
        {
            for (int i = listNo1.Count-1; i >= 0; i--)
            {
                if (listNo1[i] % 2 == 0)
                {
                    listEven.Add(listNo1[i]);
                }
                else
                {
                    listOdd.Add(listNo1[i]);
                }
            }
            string temp = "";
            foreach (int i in listEven)
            {
                temp = temp + i + " ";
            }
            lstEven.Items.Add(temp);

            string temp2 = "";
            foreach (int i in listOdd)
            {
                temp2 = temp2 + i + " ";
            }
            lstOdd.Items.Add(temp2);
        }

    }
}
