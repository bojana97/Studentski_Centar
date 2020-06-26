using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class MainMenu : Form
    {
        public MainMenu(){
            InitializeComponent();
        }





        public int ID_studenta;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KC0AGPE;Initial Catalog=Studentski_Centar;Integrated Security=True");



        private void btnDodajStudenta_Click(object sender, EventArgs e){
            if (IsValid()) {
                try{

                        conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);
                        conn.FireInfoMessageEventOnUserErrors = true;

                        SqlDataAdapter da = new SqlDataAdapter("dodajStudenta", conn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@br_indeksa", SqlDbType.VarChar).Value = txtBrindexa.Text;
                        da.SelectCommand.Parameters.Add("@ime", SqlDbType.VarChar, (30)).Value = txtIme.Text;
                        da.SelectCommand.Parameters.Add("@prezime", SqlDbType.VarChar, (40)).Value = txtPrezime.Text;
                        da.SelectCommand.Parameters.Add("@pol", SqlDbType.Char, (1)).Value = txtPol.Text;
                        da.SelectCommand.Parameters.Add("@datum_rodjenja", SqlDbType.Date).Value = txtDatumRodjenja.Text;
                        da.SelectCommand.Parameters.Add("@fakultet", SqlDbType.VarChar, (40)).Value = txtFakultet.Text;
                        da.SelectCommand.Parameters.Add("@godina_studija", SqlDbType.Int).Value = txtGodinaStudija.Text;
                        da.SelectCommand.Parameters.Add("@telefon", SqlDbType.VarChar, (30)).Value = txtTelefon.Text;
                        da.SelectCommand.Parameters.Add("@ID_sobe", SqlDbType.Int).Value = txtBrojSobe.Text;

                        conn.Open();
                        da.SelectCommand.ExecuteNonQuery();
                        conn.Close();
                }catch{
                        MessageBox.Show("Podaci nisu uneseni! Pokusajte ponovo!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        public void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e){
            MessageBox.Show(e.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }


        private bool IsValid(){
              if (txtIme.Text == string.Empty || txtPrezime.Text==string.Empty || txtBrindexa.Text==string.Empty|| txtPol.Text==string.Empty || txtDatumRodjenja.Text==string.Empty || txtFakultet.Text==string.Empty || txtGodinaStudija.Text==string.Empty || txtTelefon.Text==string.Empty || txtTelefon.Text==string.Empty){
                 MessageBox.Show("Svi podaci moraju biti uneseni", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
              }
                 return true;
              }


        private void btnReset_Click(object sender, EventArgs e){
            OcistiPolja();
        }



        private void OcistiPolja(){
            txtIme.Clear();
            txtPrezime.Clear();
            txtPol.Clear();
            txtDatumRodjenja.Clear();
            txtTelefon.Clear();
            txtPaviljon.Clear();
            txtBrojSobe.Clear();
            txtFakultet.Clear();
            txtBrindexa.Clear();
            txtGodinaStudija.Clear();
            txtIme.Focus();
        }


        private void btnPretrazi_Click(object sender, EventArgs e){

            try
            {
                SqlCommand cmd = new SqlCommand("ispisStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ime", txtImeStudenta.Text);
                cmd.Parameters.AddWithValue("@prezime", txtPrezimeStudenta.Text);

                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                DataGridStudent.DataSource = dt;
            }catch{
                MessageBox.Show("Ne postoji rekord sa unesenim podacima!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e){

            ID_studenta = Convert.ToInt32(DataGridStudent.SelectedRows[0].Cells[0].Value);
            txtIme.Text = DataGridStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtPrezime.Text = DataGridStudent.SelectedRows[0].Cells[2].Value.ToString();
            txtPol.Text = DataGridStudent.SelectedRows[0].Cells[3].Value.ToString();
            txtDatumRodjenja.Text = DataGridStudent.SelectedRows[0].Cells[4].Value.ToString();
            txtTelefon.Text = DataGridStudent.SelectedRows[0].Cells[5].Value.ToString();
            txtFakultet.Text = DataGridStudent.SelectedRows[0].Cells[6].Value.ToString();
            txtGodinaStudija.Text = DataGridStudent.SelectedRows[0].Cells[7].Value.ToString();
            txtBrindexa.Text = DataGridStudent.SelectedRows[0].Cells[8].Value.ToString();
            txtPaviljon.Text = DataGridStudent.SelectedRows[0].Cells[9].Value.ToString();
            txtBrojSobe.Text = DataGridStudent.SelectedRows[0].Cells[10].Value.ToString();   
        }




        private void btnIzmjeni_Click(object sender, EventArgs e){

            DateTime dt=DateTime.Now;
            DateTime.TryParse(txtDatumRodjenja.Text, out dt);


            if (ID_studenta > 0){
                SqlCommand cmd = new SqlCommand("UPDATE studenti  SET br_indeksa=@br_indeksa,ime=@ime,prezime=@prezime,pol=@pol,datum_rodjenja=@datum_rodjenja," +
                    "fakultet=@fakultet,godina_studija=@godina_studija,telefon=@telefon,ID_sobe=@ID_sobe WHERE ID_studenta=@ID_studenta", conn);


                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@br_indeksa", txtBrindexa.Text);
                cmd.Parameters.AddWithValue("@ime", txtIme.Text);
                cmd.Parameters.AddWithValue("@prezime", txtPrezime.Text);
                cmd.Parameters.AddWithValue("@pol", txtPol.Text);
                cmd.Parameters.Add("@datum_rodjenja", SqlDbType.DateTime).Value = dt;
                cmd.Parameters.AddWithValue("@fakultet", txtFakultet.Text);
                cmd.Parameters.AddWithValue("@godina_studija", txtGodinaStudija.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@ID_sobe", txtBrojSobe.Text);
                cmd.Parameters.AddWithValue("@ID_studenta", this.ID_studenta);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Podaci su uspjesno  sacuvani!", "Izmjenjeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();

            }
            else{
                MessageBox.Show("Izaberite studenta za izmjenu podataka!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnObrisi_Click(object sender, EventArgs e){

            SqlDataAdapter sda = new SqlDataAdapter("brisanje",conn);
            conn.Open();
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@ID_studenta", SqlDbType.Int).Value = this.ID_studenta;
            sda.SelectCommand.Parameters.Add("@ID_sobe", SqlDbType.Int).Value = txtBrojSobe.Text;


            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Podaci su uspjesno obrisani!", "Obrisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OcistiPolja();
        }


        private void btnPretragaSobe_Click(object sender, EventArgs e) {
                this.Hide();
                Smjestaj smjestaj = new Smjestaj();
                smjestaj.Show();
        }


        private void btnUgovori_Click(object sender, EventArgs e){
                this.Hide();
                Ugovori ugovor = new Ugovori();
                ugovor.Show();
        }
    }
}
