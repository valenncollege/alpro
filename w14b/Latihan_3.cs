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
    public partial class Latihan_3 : Form
    {
        public Latihan_3()
        {
            InitializeComponent();
        }

        List<string> listNama = new List<string>();
        List<int> listBelanja = new List<int>();
        List<string> listBayar = new List<string>();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string nama = txtName.Text;
            int bakso = int.Parse(txtJumBakso.Text);
            int mie = int.Parse(txtJumMieAyam.Text);

            int bayar = 20000 * bakso + 10000 * mie;

            string metodeBayar;
            if (rdoCash.Checked)
            {
                metodeBayar = rdoCash.Text;
            }
            else if (rdoOvo.Checked)
            {
                metodeBayar = rdoOvo.Text;
            }
            else
            {
                metodeBayar = rdoGopay.Text;
            }

            listNama.Add(nama);
            listBelanja.Add(bayar);
            listBayar.Add(metodeBayar);
        }

        private void btnRedisplay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listNama.Count; i++)
            {
                lstOut.Items.Add(listNama[i] + "\t" + listBelanja[i] + "\t" + listBayar[i]);
            }
        }

        private int HitungPendapatan(List<int> pListBelanja)
        {
            int total = 0;
            for (int i = 0; i < pListBelanja.Count; i++)
            {
                total = total + pListBelanja[i];
            }
            return total;
        }
        private double HitungRata(List<int> pListBelanja)
        {
            double rata = (double)HitungPendapatan(pListBelanja) / pListBelanja.Count;
            return rata;
        }
        private string HitungMetodePembayaranTerbanyak(List<string> pBayar)
        {
            int ovo = 0, cash = 0, gopay = 0;
            for (int i = 0; i < pBayar.Count; i++)
            {
                if (pBayar[i] == "Ovo")
                {
                    ovo++;
                }
                else if (pBayar[i] == "Cash")
                {
                    cash++;
                }
                else
                {
                    gopay++;
                }
            }

            int mak = ovo;

            if (mak < gopay)
            {
                mak = gopay;
            }
            if (mak < cash)
            {
                mak = cash;
            }

            string hasil = "";
            if (mak == ovo)
            {
                hasil = hasil + "Ovo ";
            }
            if (mak == cash)
            {
                hasil = hasil + "Cash ";
            }
            if (mak == gopay)
            {
                hasil = hasil + "Gopay";
            }
            return hasil;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            lstOut.Items.Add("Jumlah Pelanggan = " + listNama.Count);
            lstOut.Items.Add("Total pendapatan = " + HitungPendapatan(listBelanja));
            lstOut.Items.Add("Rata-rata pembelian = " + HitungRata(listBelanja));
            lstOut.Items.Add("Jenis Pembayaran terbanyak = " + HitungMetodePembayaranTerbanyak(listBayar));
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
