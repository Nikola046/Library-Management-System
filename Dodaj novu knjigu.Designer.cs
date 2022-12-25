namespace Biblioteka
{
    partial class Dodaj_novu_knjigu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_pisac = new System.Windows.Forms.TextBox();
            this.tb_zanr = new System.Windows.Forms.TextBox();
            this.tb_broj_strana = new System.Windows.Forms.TextBox();
            this.btn_ponisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAZIV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "PISAC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŽANR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "BROJ STRANA:";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.Color.Lime;
            this.btn_dodaj.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dodaj.Location = new System.Drawing.Point(787, 116);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(160, 60);
            this.btn_dodaj.TabIndex = 4;
            this.btn_dodaj.Text = "DODAJ";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1000, 451);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(110, 40);
            this.btn_nazad.TabIndex = 5;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // tb_naziv
            // 
            this.tb_naziv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_naziv.Location = new System.Drawing.Point(187, 44);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(450, 42);
            this.tb_naziv.TabIndex = 6;
            // 
            // tb_pisac
            // 
            this.tb_pisac.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pisac.Location = new System.Drawing.Point(187, 134);
            this.tb_pisac.Name = "tb_pisac";
            this.tb_pisac.Size = new System.Drawing.Size(450, 42);
            this.tb_pisac.TabIndex = 7;
            // 
            // tb_zanr
            // 
            this.tb_zanr.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_zanr.Location = new System.Drawing.Point(187, 249);
            this.tb_zanr.Name = "tb_zanr";
            this.tb_zanr.Size = new System.Drawing.Size(450, 42);
            this.tb_zanr.TabIndex = 8;
            this.tb_zanr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_broj_strana
            // 
            this.tb_broj_strana.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_broj_strana.Location = new System.Drawing.Point(352, 359);
            this.tb_broj_strana.Name = "tb_broj_strana";
            this.tb_broj_strana.Size = new System.Drawing.Size(155, 42);
            this.tb_broj_strana.TabIndex = 9;
            // 
            // btn_ponisti
            // 
            this.btn_ponisti.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ponisti.Location = new System.Drawing.Point(787, 231);
            this.btn_ponisti.Name = "btn_ponisti";
            this.btn_ponisti.Size = new System.Drawing.Size(165, 60);
            this.btn_ponisti.TabIndex = 13;
            this.btn_ponisti.Text = "PONIŠTI";
            this.btn_ponisti.UseVisualStyleBackColor = true;
            this.btn_ponisti.Click += new System.EventHandler(this.btn_ponisti_Click);
            // 
            // Dodaj_novu_knjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1122, 503);
            this.Controls.Add(this.btn_ponisti);
            this.Controls.Add(this.tb_broj_strana);
            this.Controls.Add(this.tb_zanr);
            this.Controls.Add(this.tb_pisac);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj_novu_knjigu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novu knjigu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_dodaj;
        private Button btn_nazad;
        private TextBox tb_naziv;
        private TextBox tb_pisac;
        private TextBox tb_zanr;
        private TextBox tb_broj_strana;
        private Button btn_ponisti;
    }
}