namespace WindowsFormsApp2
{
    partial class Smjestaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smjestaj));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBSobe = new System.Windows.Forms.TextBox();
            this.btnPretraziSobe = new System.Windows.Forms.Button();
            this.txtBPaviljona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.dataGridViewSobeStudenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewSlobodneSobe = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSobeStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlobodneSobe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtBSobe);
            this.groupBox1.Controls.Add(this.btnPretraziSobe);
            this.groupBox1.Controls.Add(this.txtBPaviljona);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBSobe
            // 
            this.txtBSobe.Location = new System.Drawing.Point(118, 113);
            this.txtBSobe.Name = "txtBSobe";
            this.txtBSobe.Size = new System.Drawing.Size(189, 22);
            this.txtBSobe.TabIndex = 5;
            // 
            // btnPretraziSobe
            // 
            this.btnPretraziSobe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPretraziSobe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziSobe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraziSobe.Image = global::WindowsFormsApp2.Properties.Resources.Search_icon__2_;
            this.btnPretraziSobe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraziSobe.Location = new System.Drawing.Point(398, 128);
            this.btnPretraziSobe.Name = "btnPretraziSobe";
            this.btnPretraziSobe.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnPretraziSobe.Size = new System.Drawing.Size(134, 43);
            this.btnPretraziSobe.TabIndex = 0;
            this.btnPretraziSobe.Text = "Pretrazi";
            this.btnPretraziSobe.UseVisualStyleBackColor = false;
            this.btnPretraziSobe.Click += new System.EventHandler(this.btnPretraziSobe_Click);
            // 
            // txtBPaviljona
            // 
            this.txtBPaviljona.Location = new System.Drawing.Point(118, 65);
            this.txtBPaviljona.Name = "txtBPaviljona";
            this.txtBPaviljona.Size = new System.Drawing.Size(189, 22);
            this.txtBPaviljona.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj paviljona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite podatke za pretragu:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnUgovori);
            this.groupBox2.Controls.Add(this.btnNazad);
            this.groupBox2.Location = new System.Drawing.Point(643, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnUgovori
            // 
            this.btnUgovori.BackColor = System.Drawing.Color.DarkGray;
            this.btnUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUgovori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUgovori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUgovori.Image = global::WindowsFormsApp2.Properties.Resources.Document_icon;
            this.btnUgovori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUgovori.Location = new System.Drawing.Point(113, 103);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Padding = new System.Windows.Forms.Padding(32, 0, 15, 0);
            this.btnUgovori.Size = new System.Drawing.Size(155, 42);
            this.btnUgovori.TabIndex = 2;
            this.btnUgovori.Text = "Ugovori";
            this.btnUgovori.UseVisualStyleBackColor = false;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DarkGray;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(113, 50);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(155, 44);
            this.btnNazad.TabIndex = 3;
            this.btnNazad.Text = "Glavni meni";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dataGridViewSobeStudenti
            // 
            this.dataGridViewSobeStudenti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSobeStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSobeStudenti.Location = new System.Drawing.Point(44, 260);
            this.dataGridViewSobeStudenti.Name = "dataGridViewSobeStudenti";
            this.dataGridViewSobeStudenti.RowTemplate.Height = 24;
            this.dataGridViewSobeStudenti.Size = new System.Drawing.Size(569, 344);
            this.dataGridViewSobeStudenti.TabIndex = 2;
            // 
            // dataGridViewSlobodneSobe
            // 
            this.dataGridViewSlobodneSobe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSlobodneSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlobodneSobe.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewSlobodneSobe.Name = "dataGridViewSlobodneSobe";
            this.dataGridViewSlobodneSobe.RowTemplate.Height = 24;
            this.dataGridViewSlobodneSobe.Size = new System.Drawing.Size(320, 339);
            this.dataGridViewSlobodneSobe.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dataGridViewSlobodneSobe);
            this.groupBox3.Location = new System.Drawing.Point(643, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 375);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(94, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ispis slobodnih mjesta";
            // 
            // Smjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewSobeStudenti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Smjestaj";
            this.Text = "Smjestaj";
            this.Load += new System.EventHandler(this.Smjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSobeStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlobodneSobe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox txtBSobe;
        private System.Windows.Forms.Button btnPretraziSobe;
        private System.Windows.Forms.TextBox txtBPaviljona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSobeStudenti;
        private System.Windows.Forms.DataGridView dataGridViewSlobodneSobe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}