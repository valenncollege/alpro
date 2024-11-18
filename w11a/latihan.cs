using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_W11A_Jevon_Valentino_160424066
{
    public partial class DigitalFarm : Form
    {
        public DigitalFarm()
        {
            InitializeComponent();
        }
        char[,] arrSawah;
        int baris, kolom;

        private void btnPlantOnCoordinates_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            int jumBaris = int.Parse(cmbLengthPos.Text);
            int jumKolom = int.Parse(cmbWidthPos.Text);
            char plant = cmbPlantName.Text[0];
            arrSawah[(jumBaris - 1), (jumKolom - 1)] = plant;

            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    temp = temp + arrSawah[i, j] + "\t";
                }
                lstDisplay.Items.Add(temp);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            int totalHarga;

            if (rdoRequiredFunds.Checked && rdoEachRows.Checked) // total harga bibit dari masing2 baris #1
            {
                for (int i = 0; i < baris; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < kolom; j++)
                    {
                        if(arrSawah[i,j] == 'T')
                        {
                            totalHarga = totalHarga +  0;
                        }
                        else if (arrSawah[i,j] == 'P')
                        {
                            totalHarga = totalHarga + 100;
                        }
                        else if (arrSawah[i,j] == 'C')
                        {
                            totalHarga = totalHarga + 300;
                        }
                        else if (arrSawah[i,j] == 'G')
                        {
                            totalHarga = totalHarga + 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 500;
                        }
                    }
                    lstDisplay.Items.Add("Required Funds for Each Rows " + (i+1) + " = " + totalHarga);
                }
            }
            else if (rdoRequiredFunds.Checked && rdoEachColumns.Checked) // total harga bibit dari masing2 kolom #2
            {
                for (int i = 0; i < kolom; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < baris; j++)
                    {
                        if (arrSawah[j,i] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[j,i] == 'P')
                        {
                            totalHarga = totalHarga + 100;
                        }
                        else if (arrSawah[j,i] == 'C')
                        {
                            totalHarga = totalHarga + 300;
                        }
                        else if (arrSawah[j,i] == 'G')
                        {
                            totalHarga = totalHarga + 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 500;
                        }
                    }
                    lstDisplay.Items.Add("Required Funds for Each Columns " + (i + 1) + " = " + totalHarga);
                }
            }
            else if (rdoRequiredFunds.Checked && rdoWholeFarmlands.Checked) // total harga bibit dari seluruh sawah #3
            {
                totalHarga = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (arrSawah[i, j] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[i, j] == 'P')
                        {
                            totalHarga = totalHarga + 100;
                        }
                        else if (arrSawah[i, j] == 'C')
                        {
                            totalHarga = totalHarga + 300;
                        }
                        else if (arrSawah[i, j] == 'G')
                        {
                            totalHarga = totalHarga + 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 500;
                        }
                    }
                }
                lstDisplay.Items.Add("Required Funds for Whole Farmlands " + " = " + totalHarga);

            }
            else if (rdoEstimatedSales.Checked && rdoEachRows.Checked)// total harga jual dari masing2 baris #4
            {
                for (int i = 0; i < baris; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < kolom; j++)
                    {
                        if (arrSawah[i, j] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[i, j] == 'P')
                        {
                            totalHarga = totalHarga + 120;
                        }
                        else if (arrSawah[i, j] == 'C')
                        {
                            totalHarga = totalHarga + 450;
                        }
                        else if (arrSawah[i, j] == 'G')
                        {
                            totalHarga = totalHarga + 200;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800;
                        }
                    }
                    lstDisplay.Items.Add("Estimated Sales for Each Rows " + (i + 1) + " = " + totalHarga);
                }
            }
            else if (rdoEstimatedSales.Checked && rdoEachColumns.Checked) // total harga jual masing2 kolom #5
            {
                for (int i = 0; i < kolom; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < baris; j++)
                    {
                        if (arrSawah[j, i] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[j, i] == 'P')
                        {
                            totalHarga = totalHarga + 120;
                        }
                        else if (arrSawah[j, i] == 'C')
                        {
                            totalHarga = totalHarga + 450;
                        }
                        else if (arrSawah[j, i] == 'G')
                        {
                            totalHarga = totalHarga + 200;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800;
                        }
                    }
                    lstDisplay.Items.Add("Estimated Sales for Each Columns " + (i + 1) + " = " + totalHarga);
                }
            }
            else if (rdoEstimatedSales.Checked && rdoWholeFarmlands.Checked) // total harga jual seluruh sawah #6
            {
                totalHarga = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (arrSawah[i, j] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[i, j] == 'P')
                        {
                            totalHarga = totalHarga + 120;
                        }
                        else if (arrSawah[i, j] == 'C')
                        {
                            totalHarga = totalHarga + 450;
                        }
                        else if (arrSawah[i, j] == 'G')
                        {
                            totalHarga = totalHarga + 200;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800;
                        }
                    }
                }
                lstDisplay.Items.Add("Estimated Sales for Whole Farmlands " + " = " + totalHarga);
            }
            else if (rdoTotalProfit.Checked && rdoEachRows.Checked) // total profit masing2 baris #7
            {
                for (int i = 0; i < baris; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < kolom; j++)
                    {
                        if (arrSawah[i, j] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[i, j] == 'P')
                        {
                            totalHarga = totalHarga + 120 - 100;
                        }
                        else if (arrSawah[i, j] == 'C')
                        {
                            totalHarga = totalHarga + 450 - 300;
                        }
                        else if (arrSawah[i, j] == 'G')
                        {
                            totalHarga = totalHarga + 200 - 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800 - 500;
                        }
                    }
                    lstDisplay.Items.Add("Total Profit for Each Rows " + (i + 1) + " = " + totalHarga);
                }
            }
            else if (rdoTotalProfit.Checked && rdoEachColumns.Checked) // total profit masing2 kolom #8
            {
                for (int i = 0; i < kolom; i++)
                {
                    totalHarga = 0;
                    for (int j = 0; j < baris; j++)
                    {
                        if (arrSawah[j, i] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[j, i] == 'P')
                        {
                            totalHarga = totalHarga + 120 - 100;
                        }
                        else if (arrSawah[j, i] == 'C')
                        {
                            totalHarga = totalHarga + 450 - 300;
                        }
                        else if (arrSawah[j, i] == 'G')
                        {
                            totalHarga = totalHarga + 200 - 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800 - 500;
                        }
                    }
                    lstDisplay.Items.Add("Total Profit for Each Columns " + (i + 1) + " = " + totalHarga);
                }
            }
            else // total profit seluruh sawah #9
            {
                totalHarga = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (arrSawah[i, j] == 'T')
                        {
                            totalHarga = totalHarga + 0;
                        }
                        else if (arrSawah[i, j] == 'P')
                        {
                            totalHarga = totalHarga + 120- 100;
                        }
                        else if (arrSawah[i, j] == 'C')
                        {
                            totalHarga = totalHarga + 450 - 300;
                        }
                        else if (arrSawah[i, j] == 'G')
                        {
                            totalHarga = totalHarga + 200 - 150;
                        }
                        else
                        {
                            totalHarga = totalHarga + 800 - 500;
                        }
                    }
                }
                lstDisplay.Items.Add("Total Profit for Whole Farmlands " + " = " + totalHarga);
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            baris =int.Parse( txtFarmLength.Text); // length = panjang = baris
            kolom = int.Parse(txtFarmWidth.Text); // width = lebar = kolom

            arrSawah = new char[baris, kolom];

            string temp;
            for (int i = 0; i < baris; i++)
            {
                temp = "";
                for (int j = 0; j < kolom; j++)
                {
                    arrSawah[i, j] = 'T';
                    temp = temp + arrSawah[i, j] + "\t";
                }
                lstDisplay.Items.Add(temp);
            }
            gbFarmCreation.Enabled = false;
            for (int i = 1; i <= baris; i++)
            {
                cmbLengthPos.Items.Add(i);
            }
            for (int i = 1; i <= kolom; i++)
            {
                cmbWidthPos.Items.Add(i);
            }
            cmbLengthPos.Focus();
        }
    }
}
