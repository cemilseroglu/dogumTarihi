using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogumTarihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int gun;
        int ay;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            #region YasHesapla
            DateTime dt = dtpDogumGunu.Value;
            lblYasiniz.Text = (DateTime.Now.Year - dt.Year).ToString();
            #endregion
            #region YasananGunHesapla
            TimeSpan gecenSure = DateTime.Now - dt;
            lblYasadiginizGun.Text = ((int)gecenSure.TotalDays).ToString();
            ay = Convert.ToInt16(dtpDogumGunu.Value.Month);
            gun = Convert.ToInt16(dtpDogumGunu.Value.Day);
            #endregion 
            #region burcHesapla
            if ((ay == 12 & gun >= 12) || (ay == 1 & gun <= 20))
            {
                lblBurcunuz.Text = "OĞLAK";
            }
            if ((ay == 9 & gun >= 22) || (ay == 10 & gun <= 23))
            {
                lblBurcunuz.Text = "TERAZİ";
            }
            if ((ay == 1 & gun >= 21) || (ay == 2 & gun <= 19))
            {
                lblBurcunuz.Text = "KOVA";
            }
            if ((ay == 2 & gun >= 20) || (ay == 3 & gun <= 20))
            {
                lblBurcunuz.Text = "BALIK";
            }
            if ((ay == 3 & gun >= 21) || (ay == 4 & gun <= 20))
            {
                lblBurcunuz.Text = "KOÇ";
            }
            if ((ay == 4 & gun >= 21) || (ay == 5 & gun <= 21))
            {
                lblBurcunuz.Text = "BOĞA";
            }
            if ((ay == 5 & gun >= 22) || (ay == 6 & gun <= 21))
            {
                lblBurcunuz.Text = "İKİZLER";
            }
            if ((ay == 6 & gun >= 22) || (ay == 7 & gun <= 23))
            {
                lblBurcunuz.Text = "YENGEÇ";
            }
            if ((ay == 7 & gun >= 24) || (ay == 8 & gun <= 23))
            {
                lblBurcunuz.Text = "ASLAN";
            }
            if ((ay == 8 & gun >= 24) || (ay == 9 & gun <= 23))
            {
                lblBurcunuz.Text = "BAŞAK";
            }
            if ((ay == 102 & gun >= 23) || (ay == 11 & gun <= 22))
            {
                lblBurcunuz.Text = "AKREP";
            }
            if ((ay == 11 & gun >= 23) || (ay == 12 & gun <= 22))
            {
                lblBurcunuz.Text = "YAY";
            }
            #endregion
        }


    }
}
