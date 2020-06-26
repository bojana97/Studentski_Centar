namespace WindowsFormsApp2
{
    partial class Ugovori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ugovori));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezimeStudentaUgovor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIspisUgovora = new System.Windows.Forms.Button();
            this.txtImeStudentaUgovor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridUgovori = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNoviUgovor = new System.Windows.Forms.Button();
            this.btnSmjestaj = new System.Windows.Forms.Button();
            this.btnMeni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUgovori)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrezimeStudentaUgovor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIspisUgovora);
            this.groupBox1.Controls.Add(this.txtImeStudentaUgovor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(170, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unesite podatke za pretragu";
            // 
            // txtPrezimeStudentaUgovor
            // 
            this.txtPrezimeStudentaUgovor.Location = new System.Drawing.Point(103, 121);
            this.txtPrezimeStudentaUgovor.Name = "txtPrezimeStudentaUgovor";
            this.txtPrezimeStudentaUgovor.Size = new System.Drawing.Size(219, 22);
            this.txtPrezimeStudentaUgovor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime:";
            // 
            // btnIspisUgovora
            // 
            this.btnIspisUgovora.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIspisUgovora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisUgovora.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisUgovora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspisUgovora.Image = global::WindowsFormsApp2.Properties.Resources.Search_icon__2_;
            this.btnIspisUgovora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspisUgovora.Location = new System.Drawing.Point(416, 149);
            this.btnIspisUgovora.Name = "btnIspisUgovora";
            this.btnIspisUgovora.Padding = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.btnIspisUgovora.Size = new System.Drawing.Size(138, 40);
            this.btnIspisUgovora.TabIndex = 2;
            this.btnIspisUgovora.Text = "Pretrazi";
            this.btnIspisUgovora.UseVisualStyleBackColor = false;
            this.btnIspisUgovora.Click += new System.EventHandler(this.btnIspisUgovora_Click);
            // 
            // txtImeStudentaUgovor
            // 
            this.txtImeStudentaUgovor.Location = new System.Drawing.Point(103, 77);
            this.txtImeStudentaUgovor.Name = "txtImeStudentaUgovor";
            this.txtImeStudentaUgovor.Size = new System.Drawing.Size(219, 22);
            this.txtImeStudentaUgovor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // dataGridUgovori
            // 
            this.dataGridUgovori.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUgovori.Location = new System.Drawing.Point(22, 272);
            this.dataGridUgovori.Name = "dataGridUgovori";
            this.dataGridUgovori.RowTemplate.Height = 24;
            this.dataGridUgovori.Size = new System.Drawing.Size(848, 141);
            this.dataGridUgovori.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnNoviUgovor);
            this.groupBox2.Controls.Add(this.btnSmjestaj);
            this.groupBox2.Controls.Add(this.btnMeni);
            this.groupBox2.Location = new System.Drawing.Point(631, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnNoviUgovor
            // 
            this.btnNoviUgovor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNoviUgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviUgovor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNoviUgovor.Location = new System.Drawing.Point(48, 149);
            this.btnNoviUgovor.Name = "btnNoviUgovor";
            this.btnNoviUgovor.Size = new System.Drawing.Size(146, 40);
            this.btnNoviUgovor.TabIndex = 2;
            this.btnNoviUgovor.Text = "+ Novi ugovor";
            this.btnNoviUgovor.UseVisualStyleBackColor = false;
            this.btnNoviUgovor.Click += new System.EventHandler(this.btnNoviUgovor_Click);
            // 
            // btnSmjestaj
            // 
            this.btnSmjestaj.BackColor = System.Drawing.Color.DarkGray;
            this.btnSmjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmjestaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSmjestaj.Location = new System.Drawing.Point(48, 77);
            this.btnSmjestaj.Name = "btnSmjestaj";
            this.btnSmjestaj.Size = new System.Drawing.Size(146, 38);
            this.btnSmjestaj.TabIndex = 1;
            this.btnSmjestaj.Text = "Smjestaj";
            this.btnSmjestaj.UseVisualStyleBackColor = false;
            this.btnSmjestaj.Click += new System.EventHandler(this.btnSmjestaj_Click);
            // 
            // btnMeni
            // 
            this.btnMeni.BackColor = System.Drawing.Color.DarkGray;
            this.btnMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeni.Location = new System.Drawing.Point(48, 31);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(146, 40);
            this.btnMeni.TabIndex = 0;
            this.btnMeni.Text = "Glavni meni";
            this.btnMeni.UseVisualStyleBackColor = false;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // Ugovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridUgovori);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ugovori";
            this.Text = "Ugovori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUgovori)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIspisUgovora;
        private System.Windows.Forms.TextBox txtImeStudentaUgovor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridUgovori;
        private System.Windows.Forms.TextBox txtPrezimeStudentaUgovor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSmjestaj;
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNoviUgovor;
    }
}