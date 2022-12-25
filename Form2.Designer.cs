namespace Biblioteka
{
    partial class Form2
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
            this.btn_clanovi = new System.Windows.Forms.Button();
            this.btn_knjige = new System.Windows.Forms.Button();
            this.btn_dodaj_novu_knjigu = new System.Windows.Forms.Button();
            this.btn_odjavi_se = new System.Windows.Forms.Button();
            this.btn_izdate_knjige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clanovi
            // 
            this.btn_clanovi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clanovi.Location = new System.Drawing.Point(166, 47);
            this.btn_clanovi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clanovi.Name = "btn_clanovi";
            this.btn_clanovi.Size = new System.Drawing.Size(230, 60);
            this.btn_clanovi.TabIndex = 0;
            this.btn_clanovi.Text = "ČLANOVI";
            this.btn_clanovi.UseVisualStyleBackColor = true;
            this.btn_clanovi.Click += new System.EventHandler(this.btn_clanovi_Click);
            // 
            // btn_knjige
            // 
            this.btn_knjige.AutoSize = true;
            this.btn_knjige.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_knjige.Location = new System.Drawing.Point(166, 167);
            this.btn_knjige.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_knjige.Name = "btn_knjige";
            this.btn_knjige.Size = new System.Drawing.Size(230, 60);
            this.btn_knjige.TabIndex = 1;
            this.btn_knjige.Text = "KNJIGE";
            this.btn_knjige.UseVisualStyleBackColor = true;
            this.btn_knjige.Click += new System.EventHandler(this.btn_knjige_Click);
            // 
            // btn_dodaj_novu_knjigu
            // 
            this.btn_dodaj_novu_knjigu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dodaj_novu_knjigu.Location = new System.Drawing.Point(166, 283);
            this.btn_dodaj_novu_knjigu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dodaj_novu_knjigu.Name = "btn_dodaj_novu_knjigu";
            this.btn_dodaj_novu_knjigu.Size = new System.Drawing.Size(230, 60);
            this.btn_dodaj_novu_knjigu.TabIndex = 2;
            this.btn_dodaj_novu_knjigu.Text = "DODAJ NOVU KNJIGU";
            this.btn_dodaj_novu_knjigu.UseVisualStyleBackColor = true;
            this.btn_dodaj_novu_knjigu.Click += new System.EventHandler(this.btn_dodaj_novu_knjigu_Click);
            // 
            // btn_odjavi_se
            // 
            this.btn_odjavi_se.BackColor = System.Drawing.Color.Red;
            this.btn_odjavi_se.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_odjavi_se.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_odjavi_se.Location = new System.Drawing.Point(421, 521);
            this.btn_odjavi_se.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_odjavi_se.Name = "btn_odjavi_se";
            this.btn_odjavi_se.Size = new System.Drawing.Size(114, 40);
            this.btn_odjavi_se.TabIndex = 3;
            this.btn_odjavi_se.Text = "Odjavi se";
            this.btn_odjavi_se.UseVisualStyleBackColor = false;
            this.btn_odjavi_se.Click += new System.EventHandler(this.btn_odjavi_se_Click);
            // 
            // btn_izdate_knjige
            // 
            this.btn_izdate_knjige.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izdate_knjige.Location = new System.Drawing.Point(166, 396);
            this.btn_izdate_knjige.Name = "btn_izdate_knjige";
            this.btn_izdate_knjige.Size = new System.Drawing.Size(230, 60);
            this.btn_izdate_knjige.TabIndex = 4;
            this.btn_izdate_knjige.Text = "IZDATE KNJIGE";
            this.btn_izdate_knjige.UseVisualStyleBackColor = true;
            this.btn_izdate_knjige.Click += new System.EventHandler(this.btn_izdate_knjige_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(549, 577);
            this.Controls.Add(this.btn_izdate_knjige);
            this.Controls.Add(this.btn_odjavi_se);
            this.Controls.Add(this.btn_dodaj_novu_knjigu);
            this.Controls.Add(this.btn_knjige);
            this.Controls.Add(this.btn_clanovi);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_clanovi;
        private Button btn_knjige;
        private Button btn_dodaj_novu_knjigu;
        private Button btn_odjavi_se;
        private Button btn_izdate_knjige;
    }
}