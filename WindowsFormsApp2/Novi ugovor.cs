using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Novi_ugovor : Form
    {
        public Novi_ugovor()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KC0AGPE;Initial Catalog=Studentski_Centar;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNazadUgovor_Click(object sender, EventArgs e){
            this.Close();
            Ugovori ugovoriForma = new Ugovori();
            ugovoriForma.Show();
        }

        private void btnGlavniMeni_Click(object sender, EventArgs e){
            this.Close();
            MainMenu glavniMeni = new MainMenu();
            glavniMeni.Show();
        }

        private void btnSmjestaj_Click(object sender, EventArgs e){
            this.Close();
            Smjestaj smjestajForma = new Smjestaj();
            smjestajForma.Show();
        }

        private void btnReset_Click(object sender, EventArgs e){
            ResetPolja();
        }

        private void btnPretraziStudenta_Click(object sender, EventArgs e){

            try
            {
                SqlCommand cmd = new SqlCommand("ispisIDiS", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@imeStudenta", txtStudentIme.Text);
                cmd.Parameters.AddWithValue("@prezimeStudenta", txtStudentPrezime.Text);
                cmd.Parameters.AddWithValue("@fakultet", txtStudentFakultet.Text);

                cmd.Parameters.Add("@IDs", SqlDbType.Int);
                cmd.Parameters.Add("@BrSobe", SqlDbType.Int);

                cmd.Parameters["@IDs"].Direction = ParameterDirection.Output;
                cmd.Parameters["@BrSobe"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                txtIDstudenta.Text = cmd.Parameters["@IDs"].Value.ToString();
                txtBrojSobe.Text = cmd.Parameters["@BrSobe"].Value.ToString();
            }catch{
                MessageBox.Show("Ne postoji rekord sa odgovarajucim podacima!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnPretraziBlagajna_Click(object sender, EventArgs e) {

            try {
                SqlCommand cmd = new SqlCommand("ispisIDblagajnika", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@imeBlagajnika", txtBlagajnikIme.Text);
                cmd.Parameters.AddWithValue("@prezimeBlagajnika", txtBlagajnikPrezime.Text);

                cmd.Parameters.Add("@IDblagajnika", SqlDbType.Int);

                cmd.Parameters["@IDblagajnika"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                txtIDblagajnika.Text = cmd.Parameters["@IDblagajnika"].Value.ToString();
            }
            catch {
                MessageBox.Show("Ne postoji rekord sa unesenim podacima!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Novi_ugovor_Load(object sender, EventArgs e){
            txtDatumSklapanjaUgovora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
            txtDatumIstekaUgovora.Text = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd HH:mm:ss:fff");
        }


        private void btnSacuvajUgovor_Click(object sender, EventArgs e){

            try{
                SqlDataAdapter da = new SqlDataAdapter("unosUgovorUplata", conn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@sifraUgovora", SqlDbType.VarChar, (10)).Value = txtSifraUgovora.Text;
                da.SelectCommand.Parameters.Add("@datumSklapanjaUgovora", SqlDbType.Date).Value = txtDatumSklapanjaUgovora.Text;
                da.SelectCommand.Parameters.Add("@datumIstekaUgovora", SqlDbType.Date, (30)).Value = txtDatumIstekaUgovora.Text;
                da.SelectCommand.Parameters.Add("@ID_studenta", SqlDbType.Int).Value = txtIDstudenta.Text;
                da.SelectCommand.Parameters.Add("@ID_blagajnika", SqlDbType.Int).Value = txtIDblagajnika.Text;
               da.SelectCommand.Parameters.Add("@iznos", SqlDbType.Decimal, 0).Value = txtUplacenIznos.Text;
                da.SelectCommand.Parameters.Add("@duguje", SqlDbType.Decimal,0).Value = txtDuguje.Text;
                da.SelectCommand.Parameters.Add("@potrazuje", SqlDbType.Decimal).Value = txtPotrazuje.Text;

                conn.Open();
                da.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Podaci su uspjesno sacuvani!", "Ugovor kreiran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPolja();

            } catch{
                MessageBox.Show("Neuspjesan unos!", "Greska!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ResetPolja(){
            txtStudentIme.Clear();
            txtStudentPrezime.Clear();
            txtStudentFakultet.Clear();
            txtBlagajnikIme.Clear();
            txtBlagajnikPrezime.Clear();
            txtDatumSklapanjaUgovora.Clear();
            txtDatumIstekaUgovora.Clear();
            txtSifraUgovora.Clear();
            txtUplacenIznos.Clear();
            txtDuguje.Clear();
            txtPotrazuje.Clear();
            txtIDstudenta.Clear();
            txtBrojSobe.Clear();

            txtStudentIme.Focus();
        }


    }
}
