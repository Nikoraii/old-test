
namespace Kolokvijum1
{
    partial class Form1
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
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbGodinaIzdanja = new System.Windows.Forms.TextBox();
            this.tbListaZanrova = new System.Windows.Forms.TextBox();
            this.tbListaOcena = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbUpisFajl = new System.Windows.Forms.TextBox();
            this.btnUpisFajl = new System.Windows.Forms.Button();
            this.btnUcitajFajl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbListaKnjiga = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(99, 17);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(322, 20);
            this.tbNaslov.TabIndex = 0;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(99, 54);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(322, 20);
            this.tbAutor.TabIndex = 1;
            // 
            // tbGodinaIzdanja
            // 
            this.tbGodinaIzdanja.Location = new System.Drawing.Point(99, 95);
            this.tbGodinaIzdanja.Name = "tbGodinaIzdanja";
            this.tbGodinaIzdanja.Size = new System.Drawing.Size(322, 20);
            this.tbGodinaIzdanja.TabIndex = 2;
            // 
            // tbListaZanrova
            // 
            this.tbListaZanrova.Location = new System.Drawing.Point(99, 132);
            this.tbListaZanrova.Name = "tbListaZanrova";
            this.tbListaZanrova.Size = new System.Drawing.Size(322, 20);
            this.tbListaZanrova.TabIndex = 3;
            // 
            // tbListaOcena
            // 
            this.tbListaOcena.Location = new System.Drawing.Point(99, 173);
            this.tbListaOcena.Name = "tbListaOcena";
            this.tbListaOcena.Size = new System.Drawing.Size(322, 20);
            this.tbListaOcena.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(99, 216);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(322, 40);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj u listu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbUpisFajl
            // 
            this.tbUpisFajl.Location = new System.Drawing.Point(99, 270);
            this.tbUpisFajl.Name = "tbUpisFajl";
            this.tbUpisFajl.Size = new System.Drawing.Size(322, 20);
            this.tbUpisFajl.TabIndex = 6;
            // 
            // btnUpisFajl
            // 
            this.btnUpisFajl.Location = new System.Drawing.Point(99, 307);
            this.btnUpisFajl.Name = "btnUpisFajl";
            this.btnUpisFajl.Size = new System.Drawing.Size(322, 40);
            this.btnUpisFajl.TabIndex = 7;
            this.btnUpisFajl.Text = "Upisi u fajl";
            this.btnUpisFajl.UseVisualStyleBackColor = true;
            this.btnUpisFajl.Click += new System.EventHandler(this.btnUpisFajl_Click);
            // 
            // btnUcitajFajl
            // 
            this.btnUcitajFajl.Location = new System.Drawing.Point(99, 367);
            this.btnUcitajFajl.Name = "btnUcitajFajl";
            this.btnUcitajFajl.Size = new System.Drawing.Size(322, 40);
            this.btnUcitajFajl.TabIndex = 8;
            this.btnUcitajFajl.Text = "Ucitaj iz fajla";
            this.btnUcitajFajl.UseVisualStyleBackColor = true;
            this.btnUcitajFajl.Click += new System.EventHandler(this.btnUcitajFajl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Godina izdanja";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lista zanrova";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lista ocena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Naziv fajla";
            // 
            // lbListaKnjiga
            // 
            this.lbListaKnjiga.FormattingEnabled = true;
            this.lbListaKnjiga.Location = new System.Drawing.Point(19, 424);
            this.lbListaKnjiga.Name = "lbListaKnjiga";
            this.lbListaKnjiga.ScrollAlwaysVisible = true;
            this.lbListaKnjiga.Size = new System.Drawing.Size(428, 173);
            this.lbListaKnjiga.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 614);
            this.Controls.Add(this.lbListaKnjiga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitajFajl);
            this.Controls.Add(this.btnUpisFajl);
            this.Controls.Add(this.tbUpisFajl);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbListaOcena);
            this.Controls.Add(this.tbListaZanrova);
            this.Controls.Add(this.tbGodinaIzdanja);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbGodinaIzdanja;
        private System.Windows.Forms.TextBox tbListaZanrova;
        private System.Windows.Forms.TextBox tbListaOcena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbUpisFajl;
        private System.Windows.Forms.Button btnUpisFajl;
        private System.Windows.Forms.Button btnUcitajFajl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbListaKnjiga;
    }
}

