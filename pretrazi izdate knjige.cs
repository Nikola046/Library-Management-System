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
    public partial class pretrazi_izdate_knjige : Form
    {
        public pretrazi_izdate_knjige()
        {
            InitializeComponent();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Izdate_knjige izdatek = new Izdate_knjige();
            this.Hide();
            izdatek.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string querry = "SELECT * FROM IzdateKnjige WHERE Naziv='" + tb_naziv.Text + "' OR Pisac='" + tb_pisac.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_pretrazi_izdate_knjige.DataSource = table;
            con.Close();

            tb_naziv.Clear();
            tb_pisac.Clear();

            tb_naziv.Focus();
        }
    }
}
