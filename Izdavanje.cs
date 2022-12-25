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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Biblioteka
{
    public partial class Izdavanje : Form
    {
        public Izdavanje()
        {
            InitializeComponent();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Knjige knjige = new Knjige();
            this.Hide();
            knjige.ShowDialog();
            this.Close();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Da li želite da izdate knjigu čiji je ID: {tb_id_knjiga.Text} članu čiji je ID: {tb_id_clan.Text} ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                string ConnectionString;
                ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();
                string querry = "\r\nINSERT INTO IzdateKnjige(KnjigaID, Naziv, Pisac, ClanID, Ime, Prezime) SELECT Knjige.KnjigaID, Knjige.Naziv, Knjige.Pisac, Clanovi.ClanID,Clanovi.Ime, Clanovi.Prezime FROM Knjige, Clanovi WHERE KnjigaID='"+tb_id_knjiga.Text+"' AND ClanID='"+tb_id_clan.Text+"'";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show($"Uspešno ste izdali knjigu čiji je ID: {tb_id_knjiga.Text} članu čiji je ID: {tb_id_clan.Text}", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(dr == DialogResult.No)
            {
                MessageBox.Show("Odustali ste od izdavanja", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tb_id_knjiga.Clear();
            tb_id_clan.Clear();
        }
    }
}
