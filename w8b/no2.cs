using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_W8B
{
    public partial class no2 : Form
    {
        public no2()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string kota = cmbKota.Text;
            string pendidikan ="";
            if (rdoSarjana.Checked == true)
            {
                pendidikan = rdoSarjana.Text;
            }
            if (rdoMagister.Checked == true)
            {
                pendidikan = rdoMagister.Text;
            }
            if (rdoDoktor.Checked == true)
            {
                pendidikan = rdoDoktor.Text;
            }
            string bidang = "";
            if (cbMachineLearning.Checked == true)
            {
                bidang += cbMachineLearning.Text + ", ";
            }
            if (cbSoftwareEngine.Checked == true)
            {
                bidang += cbSoftwareEngine.Text + ", ";
            }
            if (cbDataAnalytics.Checked == true)
            {
                bidang += cbDataAnalytics.Text + ", ";
            }
            if (cbStatistics.Checked == true)
            {
                bidang += cbStatistics.Text + ", ";
            }
            if (cbITManage.Checked == true)
            {
                bidang += cbITManage.Text + ", ";
            }
            if (cbEnterprise.Checked == true)
            {
                bidang += cbEnterprise.Text + ", ";
            }
            if (cbGameDev.Checked == true)
            {
                bidang += cbGameDev.Text + ", ";
            }
            if (cbMultimedia.Checked == true)
            {
                bidang += cbMultimedia.Text + ", ";
            }

            int usia = (int)nudUsia.Value;

            lstHasil.Items.Add("Nama : " + nama);
            lstHasil.Items.Add("Usia : " + usia + " Tahun");
            lstHasil.Items.Add("Kota Asal : "+ kota);
            lstHasil.Items.Add("Pendidikan Terakhir : "+ pendidikan);
            lstHasil.Items.Add("Bidang Keahlian : "+ bidang);
            lstHasil.Items.Add("Selamat, data anda berhasil disimpan !");

        }

        private void no2_Load(object sender, EventArgs e)
        {

        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbKota_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKota.Items.Add("Surabaya");
            cmbKota.Items.Add("Malang");
            cmbKota.Items.Add("Jakarta");
            cmbKota.Items.Add("Medan");
            cmbKota.Items.Add("Yogyakarta");
            cmbKota.Items.Add("Makassar");


        }
    }
}
