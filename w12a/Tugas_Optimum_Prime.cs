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
    public partial class Tugas_Optimum_Prime : Form
    {
        public Tugas_Optimum_Prime()
        {
            InitializeComponent();
        }
        List<int> listA = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            
            while (input > 0)
            {
                listA.Add(input % 10);
                input = input / 10;
            }
            for (int i = listA.Count-1; i >= 0; i--)
            {
                lstOut1.Items.Add(listA[i]);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int count;
            string temp = "";
            for (int i = listA.Count-1; i >= 0; i--)
            {
                count = 0;
                for (int j = 1; j <= listA[i]; j++)
                {
                    if (listA[i] % j == 0)
                    {
                        count++;
                    }                   
                }
                if (count == 2)
                {
                    temp = temp + listA[i] + " ";
                }
            }
            lstPrime.Items.Add(temp);

        }
    }
}
