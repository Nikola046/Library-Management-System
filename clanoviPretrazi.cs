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
    public partial class clanoviPretrazi : Form
    {
        public clanoviPretrazi()
        {
            InitializeComponent();

            
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Clanovi cl = new Clanovi();
            this.Hide();
            cl.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            

            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string querry = "SELECT * FROM Clanovi WHERE Ime='" + tb_ime.Text + "' OR Prezime='" + tb_prezime.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_clanovi_pretrazi.DataSource = table;
            con.Close();

            tb_ime.Clear();
            tb_prezime.Clear();
            tb_ime.Focus();
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            Brisanje brisi = new Brisanje();
            this.Hide();
            brisi.ShowDialog();
            this.Close();
        }
    }
}
