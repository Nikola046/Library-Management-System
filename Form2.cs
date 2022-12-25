using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_odjavi_se_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_clanovi_Click(object sender, EventArgs e)
        {
            Clanovi clanovi = new Clanovi();
            this.Hide();
            clanovi.ShowDialog();
            this.Close();

            
        }

        private void btn_knjige_Click(object sender, EventArgs e)
        {
            Knjige knjige = new Knjige();
            this.Hide();
            knjige.ShowDialog();
            this.Close();
        }

        private void btn_izdate_knjige_Click(object sender, EventArgs e)
        {
            Izdate_knjige izdate=new Izdate_knjige();
            this.Hide();
            izdate.ShowDialog();
            this.Close();
        }

        private void btn_dodaj_novu_knjigu_Click(object sender, EventArgs e)
        {
            Dodaj_novu_knjigu dnk=new Dodaj_novu_knjigu();
            this.Hide();
            dnk.ShowDialog();
            this.Close();
        }
    }
}
