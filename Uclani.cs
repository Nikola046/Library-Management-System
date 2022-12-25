using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteka
{
    public partial class Uclani : Form
    {
        public Uclani()
        {
            InitializeComponent();
        }

        private void btn_ponisti_Click(object sender, EventArgs e)
        {
            tb_ime.Clear();
            tb_prezime.Clear();
            tb_telefon.Clear();
            tb_adresa.Clear();
            tb_email.Clear();

            tb_ime.Focus();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Clanovi cl=new Clanovi();
            this.Hide();
            cl.ShowDialog();
            this.Close();
        }

        //Povezivanje sa bazom i upis podataka u tabelu Clanovi
        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            if (tb_ime.Text == "" || tb_prezime.Text == "" || tb_telefon.Text == "" || tb_adresa.Text == "" || tb_mesto.Text == "" || tb_email.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_ime.Clear();
                tb_prezime.Clear();
                tb_telefon.Clear();
                tb_adresa.Clear();
                tb_mesto.Clear();
                tb_email.Clear();

                tb_ime.Focus();
            }
            else
            {

                string ConnectionString;
                ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();
                string querry = "INSERT INTO Clanovi(Ime, Prezime, Telefon, Adresa, Mesto, Email) VALUES ('" + tb_ime.Text + "', '" + tb_prezime.Text + "', '" + tb_telefon.Text + "', '" + tb_adresa.Text + "', '" + tb_mesto.Text + "', '" + tb_email.Text + "') ";

                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Uspešno ste učlanili novog člana", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_ime.Clear();
                tb_prezime.Clear();
                tb_telefon.Clear();
                tb_adresa.Clear();
                tb_mesto.Clear();
                tb_email.Clear();

                tb_ime.Focus();
            }
        }
    }
}
