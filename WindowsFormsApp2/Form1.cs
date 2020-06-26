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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KC0AGPE;Initial Catalog=Studentski_Centar;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("prijavaProcedura", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@korisnickoIme", txtKorisnickoIme.Text);
            cmd.Parameters.AddWithValue("@lozinka", txtLozinka.Text);
            conn.Open();
            int isValidUser = Convert.ToInt32(cmd.ExecuteScalar());

            if (isValidUser== 1){
                this.Hide();
                MainMenu main = new MainMenu();
                main.Show();
            }
            else {
                MessageBox.Show("Neispravno uneseni podaci! Pokusajte ponovo!", "Neuspjesna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e){
            this.AcceptButton = btnPrijaviSe;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
