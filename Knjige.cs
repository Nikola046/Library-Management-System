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
    public partial class Knjige : Form
    {
        public Knjige()
        {
            InitializeComponent();

            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string querry = "SELECT Knjige.KnjigaID, Knjige.Naziv, Knjige.Pisac, Knjige.Zanr, Knjige.BrojStrana FROM Knjige";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_knjige.DataSource = table;
            con.Close();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_k_Click(object sender, EventArgs e)
        {
            pretraziknjige Pretraziknjige=new pretraziknjige();
            this.Hide();
            Pretraziknjige.ShowDialog();
            this.Close();
        }

        private void btn_izdaj_Click(object sender, EventArgs e)
        {
            Izdavanje izdavanje=new Izdavanje();
            this.Hide();
            izdavanje.ShowDialog();
            this.Close();
        }

        private void dgv_knjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
