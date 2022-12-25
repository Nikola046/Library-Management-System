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
    public partial class Brisanje : Form
    {
        public Brisanje()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string querry = "SELECT * FROM Clanovi";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_brisanje.DataSource = table;
            con.Close();

            
            
        }

        private void Ucitaj()
        {
            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string querry = "SELECT * FROM Clanovi";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_brisanje.DataSource = table;
            con.Close();
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Da li ste sigurni da želite da izbrisete člana čiji je ID: {tb_ID.Text} ?", "Potvridite brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    string ConnectionString;
                    ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

                    SqlConnection con = new SqlConnection(ConnectionString);

                    con.Open();

                    string querry = "DELETE FROM Clanovi WHERE ClanID='"+tb_ID.Text+"'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();

                    

                    con.Close();

                    MessageBox.Show("Uspešno ste obrisali člana", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    tb_ID.Clear();

                    
                }
                else if(dr == DialogResult.No)
                {
                    MessageBox.Show("Odustali ste od brisanja", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dgv_brisanje.DataSource = null;
            Ucitaj();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Clanovi cl = new Clanovi();
            this.Hide();
            cl.ShowDialog();
            this.Close();
        }
    }
}
