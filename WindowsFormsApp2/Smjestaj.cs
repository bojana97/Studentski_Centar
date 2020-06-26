using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Smjestaj : Form
    {
        public Smjestaj(){
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KC0AGPE;Initial Catalog=Studentski_Centar;Integrated Security=True");

        private void btnUgovori_Click(object sender, EventArgs e){
            this.Hide();
            Ugovori ugovor = new Ugovori();
            ugovor.Show();
        }

        private void btnNazad_Click(object sender, EventArgs e) {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }





        private void btnPretraziSobe_Click(object sender, EventArgs e){
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.pretragaSoba", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_paviljona", txtBPaviljona.Text);
                cmd.Parameters.AddWithValue("@ID_sobe", txtBSobe.Text);

                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridViewSobeStudenti.DataSource = dt;

            }catch{
                MessageBox.Show("Ne postoji rekord sa unesenim podacima!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void Smjestaj_Load(object sender, EventArgs e){
            SqlCommand cmd = new SqlCommand("dbo.ispisSlobodnihMjesta",conn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridViewSlobodneSobe.DataSource = dt;
        }
    }
}
