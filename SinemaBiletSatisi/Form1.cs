using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatisi
{
    public partial class txtBilet : Form
    {
        public txtBilet()
        {
            InitializeComponent();
        }

        decimal kasatutar = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal misir, su, cay, bilet, kasa, toplam;
            misir = Convert.ToInt32(txtMisir.Text);
            bilet = Convert.ToInt32(textBilet.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            lblKasaTutar.Text = kasatutar.ToString() + "TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtCay.Text = "";
            txtSu.Text = "";
            textBilet.Text = "";
        }

        private void txtBilet_Load(object sender, EventArgs e)
        {

        }
    }
}
