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
    public partial class Izdate_knjige : Form
    {
        public Izdate_knjige()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string querry = "SELECT * FROM IzdateKnjige";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_izdate_knjige.DataSource = table;
            con.Close();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            pretrazi_izdate_knjige pretrazi_Izdate_Knjige=new pretrazi_izdate_knjige();
            this.Hide();
            pretrazi_Izdate_Knjige.ShowDialog();
            this.Close();
        }

        private void dgv_izdate_knjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
