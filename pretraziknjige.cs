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
    public partial class pretraziknjige : Form
    {
        public pretraziknjige()
        {
            InitializeComponent();
        }

        private void btn_nazad_Click(object sender, EventArgs e)
        {
            Knjige knjige= new Knjige();
            this.Hide();
            knjige.ShowDialog();
            this.Close();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            ConnectionString = @"Data Source=NN;Initial Catalog=Biblioteka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string querry = "SELECT * FROM Knjige WHERE Naziv='" + tb_naziv.Text + "' OR Pisac='" + tb_pisac.Text + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dgv_pretrazi_knjige.DataSource = table;
            con.Close();

            tb_naziv.Clear();
            tb_pisac.Clear();

            tb_naziv.Focus();
        }

        private void btn_izdaj_Click(object sender, EventArgs e)
        {
            Izdavanje izdavanje = new Izdavanje();
            this.Hide();
            izdavanje.ShowDialog();
            this.Close();
        }
    }
}
