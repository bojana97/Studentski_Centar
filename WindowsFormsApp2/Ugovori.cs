using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Ugovori : Form
    {
        public Ugovori(){
            InitializeComponent();
        }

        private void btnMeni_Click(object sender, EventArgs e){
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }


        private void btnSmjestaj_Click(object sender, EventArgs e){
            this.Hide();
            Smjestaj smjestaj = new Smjestaj();
            smjestaj.Show();
        }


        private void btnOdjava_Click(object sender, EventArgs e){
            this.Close();
            Form1 loginForma = new Form1();
            loginForma.Show();
        }


        private void btnIspisUgovora_Click(object sender, EventArgs e){

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KC0AGPE;Initial Catalog=Studentski_Centar;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("ugovoriIspis", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@imeStudenta", txtImeStudentaUgovor.Text);
            cmd.Parameters.AddWithValue("@prezimeStudenta", txtPrezimeStudentaUgovor.Text);

            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridUgovori.DataSource = dt;

        }

        private void btnNoviUgovor_Click(object sender, EventArgs e){
            this.Close();
            Novi_ugovor noviUgovor = new Novi_ugovor();
            noviUgovor.Show();  
        }
    }
}
