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
    public partial class Dodaj_novu_knjigu : Form
    {
        public Dodaj_novu_knjigu()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btn_ponisti_Click(object sender, EventArgs e)
        {
            tb_naziv.Clear();
            tb_pisac.Clear();
            tb_zanr.Clear();
            tb_broj_strana.Clear();

            tb_naziv.Focus();
        }

        //povezivanje sa bazom i upis podataka u tabelu Knjige
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (tb_naziv.Text == "" || tb_pisac.Text == "" || tb_zanr.Text == "" || tb_broj_strana.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_naziv.Clear();
                tb_pisac.Clear();
                tb_zanr.Clear();
                tb_broj_strana.Clear();

                tb_naziv.Focus();
            } else {

                string ConnectionString;
                ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string querry = "INSERT INTO Knjige(Naziv, Pisac, Zanr, BrojStrana) VALUES ('" + tb_naziv.Text + "', '" + tb_pisac.Text + "', '" + tb_zanr.Text + "', '" + tb_broj_strana.Text + "')";

                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Uspešno ste dodali novu knjigu", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_naziv.Clear();
                tb_pisac.Clear();
                tb_zanr.Clear();
                tb_broj_strana.Clear();

                tb_naziv.Focus();
            }
        }
    }
}
