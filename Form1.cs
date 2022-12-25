namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_lozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_prijavi_se_Click(object sender, EventArgs e)
        {
            if (tb_kor_ime.Text != "administrator" || tb_lozinka.Text != "admin064") 
            {
                MessageBox.Show("Pogrešno korisnièko ime ili lozinka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                tb_kor_ime.Clear();
                tb_lozinka.Clear();
                tb_kor_ime.Focus();
            }
            else
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog(); 
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_kor_ime_Click(object sender, EventArgs e)
        {

        }

        private void tb_kor_ime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lozinka_Click(object sender, EventArgs e)
        {

        }
    }
}