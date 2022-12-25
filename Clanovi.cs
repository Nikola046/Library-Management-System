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
    public partial class Clanovi : Form
    {
        public Clanovi()
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
            dgv_clanovi.DataSource = table;
            con.Close();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btn_uclani_Click(object sender, EventArgs e)
        {
            Uclani uclani = new Uclani();
            this.Hide();
            uclani.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            clanoviPretrazi cp=new clanoviPretrazi();
            this.Hide();
            cp.ShowDialog();
            this.Close();
        }

        private void Clanovi_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_clanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            Brisanje brisi=new Brisanje();
            this.Hide();
            brisi.ShowDialog();
            this.Close();
        }
    }
}
