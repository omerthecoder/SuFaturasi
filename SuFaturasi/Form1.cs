using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFaturasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioUmumi.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                lstAdSoyad.Items.Add(txtAdSoyad.Text);
                double kullanilanSu = Convert.ToDouble(txtSonIndex.Text) - (Convert.ToDouble(txtIlkIndex.Text));
                
                double fatura = 0;
                if (radioMesken.Checked)
                {
                    lstKSuMiktari.Items.Add(kullanilanSu);
                    fatura = kullanilanSu * 0.7 + kullanilanSu * 0.3 * 0.2;
                    lstFaturaTutari.Items.Add(fatura);
                }
                else if (radioUmumi.Checked)
                {
                    lstKSuMiktari.Items.Add(kullanilanSu);
                    fatura = kullanilanSu * 0.3;
                    lstFaturaTutari.Items.Add(fatura);
                }
            }
            catch (Exception ex)
            {
                lstAdSoyad.Items.RemoveAt(lstAdSoyad.Items.Count - 1);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
