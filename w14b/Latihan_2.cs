using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W14B_Jevon_Valentino_160424066
{
    public partial class Latihan_2 : Form
    {
        public Latihan_2()
        {
            InitializeComponent();
        }

        private double KonversiReamur(double pCelcius)
        {
            double reamur = (4.0 / 5) * pCelcius;
            return reamur;
        }

        private double KonversiFahrenheit(double pCelcius)
        {
            double fahrenheit = (9.0 / 5) * pCelcius + 32;
            return fahrenheit;
        }

        private double KonversiKelvin(double pCelcius)
        {
            double kelvin = pCelcius + 273;
            return kelvin;
        }

        private void Konversi(double pCelcius, out double pReamur, out double pFahrenheit, out double pKelvin)
        {
            pReamur = KonversiReamur(pCelcius);
            pKelvin = KonversiKelvin(pCelcius);
            pFahrenheit = KonversiFahrenheit(pCelcius);
        }

        double[,] arrSuhu = new double[100, 4];
        int index = 0;
        private void btnKonversi_Click(object sender, EventArgs e)
        {
            double celcius = double.Parse(txtCelcius.Text);
            Konversi(celcius, out double reamur, out double fahrenheit, out double kelvin);
            Simpan(celcius, reamur, fahrenheit, kelvin);
        }

        private void Simpan(double c, double r, double f, double k)
        {
            arrSuhu[index, 0] = c;
            arrSuhu[index, 1] = r;
            arrSuhu[index, 2] = f;
            arrSuhu[index, 3] = k;
            index++;
        }

        private void TampilSemua()
        {
            string temp;
            for (int i = 0; i < index; i++)
            {
                temp = "";
                for (int j = 0; j < 4; j++)
                {
                    temp = temp + arrSuhu[i, j] + "\t";
                }
                lstOut.Items.Add(temp);
            }
        }

        private void btnTampilSemua_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            lstOut.Items.Add("Celcius" + "\t" + "Reamur" + "\t" + "Fahrenheit" +"\t"+ "Kelvin" + "\t");
            TampilSemua();
        }

        private void TampilSuhu(int pKolom)
        {
            for (int i = 0; i < index; i++)
            {
                lstOut.Items.Add(arrSuhu[i, pKolom]);
            }
        }

        private void btnTampilSuhu_Click(object sender, EventArgs e)
        {
            int kolom;
            if (rdoCelcius.Checked)
            {
                kolom = 0;
            }
            else if (rdoReamur.Checked)
            {
                kolom = 1;
            }
            else if (rdoFahrenheit.Checked)
            {
                kolom = 2;
            }
            else
            {
                kolom = 3;
            }
            TampilSuhu(kolom);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();         
            txtCelcius.Clear();
        }
    }
}
