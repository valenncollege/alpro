using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W13A_Jevon_Valentino_160424066
{
    public partial class Latihan_2 : Form
    {
        public Latihan_2()
        {
            InitializeComponent();
        }

        int hasil = 0; // inisialisasi variabel penampung hasil

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close(); // button close
        }

        int nilaiA, nilaiB, nilaiC; //inisialisasi variabel nilai

        private void Input ()
        {
            nilaiA = int.Parse(txtInputA.Text); //method untuk input
            nilaiB = int.Parse(txtInputB.Text);
            nilaiC = int.Parse(txtInputC.Text);            
        }

        private void Tampil()
        {
            lblHasil.Text = hasil.ToString(); // method untuk output
        }
        private int Penjumlahan (int a, int b, int c)
        {
            hasil = a + b + c; //method proses penjumlahan
            return hasil;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Input();

            hasil = Penjumlahan(nilaiA, nilaiB, nilaiC); //proses

            Tampil(); //output
        }

        private int Pengurangan (int a, int b, int c) //method pengurangan
        {
            hasil = a - b - c;
            return hasil;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Input();
            hasil = Pengurangan(nilaiA, nilaiB, nilaiC);
            Tampil();
        }

        private int Perkalian (int a, int b, int c) //method perkalian
        {
            hasil = a * b * c;
            return hasil;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Input();
            double hasil2 = Pembagian(nilaiA, nilaiB, nilaiC);
            lblHasil.Text = hasil2.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputA.Clear();
            txtInputB.Clear();
            txtInputC.Clear();
            lblHasil.Text = "Hasil";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Input();
            hasil = Perkalian(nilaiA, nilaiB, nilaiC);
            Tampil();
        }

        private double Pembagian(double a, double b, double c) //method pembagian
        {
            double hasil2 = (a / b) / c;
            return hasil2;
        }

    }
}
