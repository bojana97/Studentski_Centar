namespace WindowsFormsApp2
{
    partial class Novi_ugovor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novi_ugovor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSmjestaj = new System.Windows.Forms.Button();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.btnNazadUgovor = new System.Windows.Forms.Button();
            this.groupBoxUgovor = new System.Windows.Forms.GroupBox();
            this.txtIDblagajnika = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSacuvajUgovor = new System.Windows.Forms.Button();
            this.txtBrojSobe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDstudenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPotrazuje = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDatumSklapanjaUgovora = new System.Windows.Forms.TextBox();
            this.txtDatumIstekaUgovora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifraUgovora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUplacenIznos = new System.Windows.Forms.TextBox();
            this.txtDuguje = new System.Windows.Forms.TextBox();
            this.groupBoxBlagajnik = new System.Windows.Forms.GroupBox();
            this.btnPretraziBlagajna = new System.Windows.Forms.Button();
            this.txtBlagajnikPrezime = new System.Windows.Forms.TextBox();
            this.txtBlagajnikIme = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.btnPretraziStudenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentFakultet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStudentIme = new System.Windows.Forms.TextBox();
            this.txtStudentPrezime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxUgovor.SuspendLayout();
            this.groupBoxBlagajnik.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSmjestaj);
            this.groupBox1.Controls.Add(this.btnGlavniMeni);
            this.groupBox1.Controls.Add(this.btnNazadUgovor);
            this.groupBox1.Controls.Add(this.groupBoxUgovor);
            this.groupBox1.Controls.Add(this.groupBoxBlagajnik);
            this.groupBox1.Controls.Add(this.groupBoxStudent);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 690);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Brown;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(855, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 43);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSmjestaj
            // 
            this.btnSmjestaj.BackColor = System.Drawing.Color.Gray;
            this.btnSmjestaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmjestaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSmjestaj.Location = new System.Drawing.Point(713, 21);
            this.btnSmjestaj.Name = "btnSmjestaj";
            this.btnSmjestaj.Size = new System.Drawing.Size(126, 43);
            this.btnSmjestaj.TabIndex = 23;
            this.btnSmjestaj.Text = "Smjestaj";
            this.btnSmjestaj.UseVisualStyleBackColor = false;
            this.btnSmjestaj.Click += new System.EventHandler(this.btnSmjestaj_Click);
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGlavniMeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGlavniMeni.Location = new System.Drawing.Point(581, 21);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(126, 43);
            this.btnGlavniMeni.TabIndex = 22;
            this.btnGlavniMeni.Text = "Glavni meni";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // btnNazadUgovor
            // 
            this.btnNazadUgovor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNazadUgovor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNazadUgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazadUgovor.Image = global::WindowsFormsApp2.Properties.Resources.Back_2_2_icon;
            this.btnNazadUgovor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazadUgovor.Location = new System.Drawing.Point(28, 21);
            this.btnNazadUgovor.Name = "btnNazadUgovor";
            this.btnNazadUgovor.Padding = new System.Windows.Forms.Padding(28, 0, 10, 0);
            this.btnNazadUgovor.Size = new System.Drawing.Size(147, 43);
            this.btnNazadUgovor.TabIndex = 21;
            this.btnNazadUgovor.Text = "Nazad";
            this.btnNazadUgovor.UseVisualStyleBackColor = false;
            this.btnNazadUgovor.Click += new System.EventHandler(this.btnNazadUgovor_Click);
            // 
            // groupBoxUgovor
            // 
            this.groupBoxUgovor.AutoSize = true;
            this.groupBoxUgovor.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxUgovor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUgovor.Controls.Add(this.txtIDblagajnika);
            this.groupBoxUgovor.Controls.Add(this.label9);
            this.groupBoxUgovor.Controls.Add(this.btnSacuvajUgovor);
            this.groupBoxUgovor.Controls.Add(this.txtBrojSobe);
            this.groupBoxUgovor.Controls.Add(this.label6);
            this.groupBoxUgovor.Controls.Add(this.label5);
            this.groupBoxUgovor.Controls.Add(this.txtIDstudenta);
            this.groupBoxUgovor.Controls.Add(this.label16);
            this.groupBoxUgovor.Controls.Add(this.label15);
            this.groupBoxUgovor.Controls.Add(this.txtPotrazuje);
            this.groupBoxUgovor.Controls.Add(this.label14);
            this.groupBoxUgovor.Controls.Add(this.label13);
            this.groupBoxUgovor.Controls.Add(this.txtDatumSklapanjaUgovora);
            this.groupBoxUgovor.Controls.Add(this.txtDatumIstekaUgovora);
            this.groupBoxUgovor.Controls.Add(this.label2);
            this.groupBoxUgovor.Controls.Add(this.txtSifraUgovora);
            this.groupBoxUgovor.Controls.Add(this.label1);
            this.groupBoxUgovor.Controls.Add(this.label3);
            this.groupBoxUgovor.Controls.Add(this.txtUplacenIznos);
            this.groupBoxUgovor.Controls.Add(this.txtDuguje);
            this.groupBoxUgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxUgovor.Location = new System.Drawing.Point(432, 92);
            this.groupBoxUgovor.Name = "groupBoxUgovor";
            this.groupBoxUgovor.Size = new System.Drawing.Size(558, 534);
            this.groupBoxUgovor.TabIndex = 18;
            this.groupBoxUgovor.TabStop = false;
            this.groupBoxUgovor.Text = "Novi ugovor";
            // 
            // txtIDblagajnika
            // 
            this.txtIDblagajnika.Location = new System.Drawing.Point(245, 380);
            this.txtIDblagajnika.Name = "txtIDblagajnika";
            this.txtIDblagajnika.Size = new System.Drawing.Size(215, 22);
            this.txtIDblagajnika.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID blagajnika:";
            // 
            // btnSacuvajUgovor
            // 
            this.btnSacuvajUgovor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSacuvajUgovor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvajUgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajUgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvajUgovor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSacuvajUgovor.Location = new System.Drawing.Point(281, 457);
            this.btnSacuvajUgovor.Name = "btnSacuvajUgovor";
            this.btnSacuvajUgovor.Size = new System.Drawing.Size(156, 39);
            this.btnSacuvajUgovor.TabIndex = 25;
            this.btnSacuvajUgovor.Text = "Sacuvaj";
            this.btnSacuvajUgovor.UseVisualStyleBackColor = false;
            this.btnSacuvajUgovor.Click += new System.EventHandler(this.btnSacuvajUgovor_Click);
            // 
            // txtBrojSobe
            // 
            this.txtBrojSobe.Location = new System.Drawing.Point(245, 343);
            this.txtBrojSobe.Name = "txtBrojSobe";
            this.txtBrojSobe.Size = new System.Drawing.Size(215, 22);
            this.txtBrojSobe.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Broj sobe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID studenta:";
            // 
            // txtIDstudenta
            // 
            this.txtIDstudenta.Location = new System.Drawing.Point(245, 303);
            this.txtIDstudenta.Name = "txtIDstudenta";
            this.txtIDstudenta.Size = new System.Drawing.Size(215, 22);
            this.txtIDstudenta.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Duguje:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Potrazuje:";
            // 
            // txtPotrazuje
            // 
            this.txtPotrazuje.Location = new System.Drawing.Point(245, 261);
            this.txtPotrazuje.Name = "txtPotrazuje";
            this.txtPotrazuje.Size = new System.Drawing.Size(215, 22);
            this.txtPotrazuje.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Sifra ugovora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Uplacen iznos:";
            // 
            // txtDatumSklapanjaUgovora
            // 
            this.txtDatumSklapanjaUgovora.Location = new System.Drawing.Point(245, 63);
            this.txtDatumSklapanjaUgovora.Name = "txtDatumSklapanjaUgovora";
            this.txtDatumSklapanjaUgovora.Size = new System.Drawing.Size(215, 22);
            this.txtDatumSklapanjaUgovora.TabIndex = 7;
            // 
            // txtDatumIstekaUgovora
            // 
            this.txtDatumIstekaUgovora.Location = new System.Drawing.Point(245, 101);
            this.txtDatumIstekaUgovora.Name = "txtDatumIstekaUgovora";
            this.txtDatumIstekaUgovora.Size = new System.Drawing.Size(215, 22);
            this.txtDatumIstekaUgovora.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum sklapanja ugovora:";
            // 
            // txtSifraUgovora
            // 
            this.txtSifraUgovora.Location = new System.Drawing.Point(245, 142);
            this.txtSifraUgovora.Name = "txtSifraUgovora";
            this.txtSifraUgovora.Size = new System.Drawing.Size(215, 22);
            this.txtSifraUgovora.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, -31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra ugovora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum isteka ugovora:";
            // 
            // txtUplacenIznos
            // 
            this.txtUplacenIznos.Location = new System.Drawing.Point(245, 182);
            this.txtUplacenIznos.Name = "txtUplacenIznos";
            this.txtUplacenIznos.Size = new System.Drawing.Size(215, 22);
            this.txtUplacenIznos.TabIndex = 6;
            // 
            // txtDuguje
            // 
            this.txtDuguje.Location = new System.Drawing.Point(245, 222);
            this.txtDuguje.Name = "txtDuguje";
            this.txtDuguje.Size = new System.Drawing.Size(215, 22);
            this.txtDuguje.TabIndex = 8;
            // 
            // groupBoxBlagajnik
            // 
            this.groupBoxBlagajnik.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBlagajnik.Controls.Add(this.btnPretraziBlagajna);
            this.groupBoxBlagajnik.Controls.Add(this.txtBlagajnikPrezime);
            this.groupBoxBlagajnik.Controls.Add(this.txtBlagajnikIme);
            this.groupBoxBlagajnik.Controls.Add(this.label12);
            this.groupBoxBlagajnik.Controls.Add(this.label11);
            this.groupBoxBlagajnik.Location = new System.Drawing.Point(28, 400);
            this.groupBoxBlagajnik.Name = "groupBoxBlagajnik";
            this.groupBoxBlagajnik.Size = new System.Drawing.Size(356, 226);
            this.groupBoxBlagajnik.TabIndex = 20;
            this.groupBoxBlagajnik.TabStop = false;
            this.groupBoxBlagajnik.Text = "Blagajnik";
            // 
            // btnPretraziBlagajna
            // 
            this.btnPretraziBlagajna.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPretraziBlagajna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziBlagajna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraziBlagajna.Location = new System.Drawing.Point(130, 153);
            this.btnPretraziBlagajna.Name = "btnPretraziBlagajna";
            this.btnPretraziBlagajna.Size = new System.Drawing.Size(131, 35);
            this.btnPretraziBlagajna.TabIndex = 4;
            this.btnPretraziBlagajna.Text = "Pretrazi ";
            this.btnPretraziBlagajna.UseVisualStyleBackColor = false;
            this.btnPretraziBlagajna.Click += new System.EventHandler(this.btnPretraziBlagajna_Click);
            // 
            // txtBlagajnikPrezime
            // 
            this.txtBlagajnikPrezime.Location = new System.Drawing.Point(101, 116);
            this.txtBlagajnikPrezime.Name = "txtBlagajnikPrezime";
            this.txtBlagajnikPrezime.Size = new System.Drawing.Size(195, 22);
            this.txtBlagajnikPrezime.TabIndex = 3;
            // 
            // txtBlagajnikIme
            // 
            this.txtBlagajnikIme.Location = new System.Drawing.Point(101, 68);
            this.txtBlagajnikIme.Name = "txtBlagajnikIme";
            this.txtBlagajnikIme.Size = new System.Drawing.Size(195, 22);
            this.txtBlagajnikIme.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Prezime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ime:";
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxStudent.Controls.Add(this.btnPretraziStudenta);
            this.groupBoxStudent.Controls.Add(this.label8);
            this.groupBoxStudent.Controls.Add(this.txtStudentFakultet);
            this.groupBoxStudent.Controls.Add(this.label10);
            this.groupBoxStudent.Controls.Add(this.txtStudentIme);
            this.groupBoxStudent.Controls.Add(this.txtStudentPrezime);
            this.groupBoxStudent.Controls.Add(this.label7);
            this.groupBoxStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxStudent.Location = new System.Drawing.Point(28, 92);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(356, 283);
            this.groupBoxStudent.TabIndex = 19;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // btnPretraziStudenta
            // 
            this.btnPretraziStudenta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPretraziStudenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziStudenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretraziStudenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraziStudenta.Location = new System.Drawing.Point(130, 216);
            this.btnPretraziStudenta.Name = "btnPretraziStudenta";
            this.btnPretraziStudenta.Size = new System.Drawing.Size(131, 35);
            this.btnPretraziStudenta.TabIndex = 16;
            this.btnPretraziStudenta.Text = "Pretrazi studenta";
            this.btnPretraziStudenta.UseVisualStyleBackColor = false;
            this.btnPretraziStudenta.Click += new System.EventHandler(this.btnPretraziStudenta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fakultet:";
            // 
            // txtStudentFakultet
            // 
            this.txtStudentFakultet.Location = new System.Drawing.Point(101, 159);
            this.txtStudentFakultet.Name = "txtStudentFakultet";
            this.txtStudentFakultet.Size = new System.Drawing.Size(194, 22);
            this.txtStudentFakultet.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Prezime:";
            // 
            // txtStudentIme
            // 
            this.txtStudentIme.Location = new System.Drawing.Point(101, 68);
            this.txtStudentIme.Name = "txtStudentIme";
            this.txtStudentIme.Size = new System.Drawing.Size(193, 22);
            this.txtStudentIme.TabIndex = 9;
            // 
            // txtStudentPrezime
            // 
            this.txtStudentPrezime.Location = new System.Drawing.Point(102, 113);
            this.txtStudentPrezime.Name = "txtStudentPrezime";
            this.txtStudentPrezime.Size = new System.Drawing.Size(193, 22);
            this.txtStudentPrezime.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uplaceno:";
            // 
            // Novi_ugovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Novi_ugovor";
            this.Text = "Novi_ugovor";
            this.Load += new System.EventHandler(this.Novi_ugovor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUgovor.ResumeLayout(false);
            this.groupBoxUgovor.PerformLayout();
            this.groupBoxBlagajnik.ResumeLayout(false);
            this.groupBoxBlagajnik.PerformLayout();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifraUgovora;
        private System.Windows.Forms.TextBox txtStudentPrezime;
        private System.Windows.Forms.TextBox txtStudentIme;
        private System.Windows.Forms.TextBox txtDuguje;
        private System.Windows.Forms.TextBox txtDatumSklapanjaUgovora;
        private System.Windows.Forms.TextBox txtUplacenIznos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUgovor;
        private System.Windows.Forms.TextBox txtDatumIstekaUgovora;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxBlagajnik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSmjestaj;
        private System.Windows.Forms.Button btnGlavniMeni;
        private System.Windows.Forms.Button btnNazadUgovor;
        private System.Windows.Forms.Button btnSacuvajUgovor;
        private System.Windows.Forms.TextBox txtBrojSobe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDstudenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPotrazuje;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBlagajnikPrezime;
        private System.Windows.Forms.TextBox txtBlagajnikIme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPretraziStudenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentFakultet;
        private System.Windows.Forms.Button btnPretraziBlagajna;
        private System.Windows.Forms.TextBox txtIDblagajnika;
        private System.Windows.Forms.Label label9;
    }
}