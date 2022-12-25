namespace Biblioteka
{
    partial class Clanovi
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
            this.dgv_clanovi = new System.Windows.Forms.DataGridView();
            this.btn_uclani = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clanovi
            // 
            this.dgv_clanovi.AllowUserToDeleteRows = false;
            this.dgv_clanovi.AllowUserToResizeRows = false;
            this.dgv_clanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clanovi.Location = new System.Drawing.Point(12, 12);
            this.dgv_clanovi.MultiSelect = false;
            this.dgv_clanovi.Name = "dgv_clanovi";
            this.dgv_clanovi.ReadOnly = true;
            this.dgv_clanovi.RowHeadersWidth = 51;
            this.dgv_clanovi.RowTemplate.Height = 29;
            this.dgv_clanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clanovi.Size = new System.Drawing.Size(1350, 554);
            this.dgv_clanovi.TabIndex = 0;
            this.dgv_clanovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clanovi_CellContentClick);
            // 
            // btn_uclani
            // 
            this.btn_uclani.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_uclani.Location = new System.Drawing.Point(1391, 31);
            this.btn_uclani.Name = "btn_uclani";
            this.btn_uclani.Size = new System.Drawing.Size(160, 60);
            this.btn_uclani.TabIndex = 1;
            this.btn_uclani.Text = "UČLANI";
            this.btn_uclani.UseVisualStyleBackColor = true;
            this.btn_uclani.Click += new System.EventHandler(this.btn_uclani_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izbrisi.Location = new System.Drawing.Point(1391, 289);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(160, 60);
            this.btn_izbrisi.TabIndex = 2;
            this.btn_izbrisi.Text = "IZBRIŠI";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi.Location = new System.Drawing.Point(1391, 150);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(160, 60);
            this.btn_pretrazi.TabIndex = 3;
            this.btn_pretrazi.Text = "PRETRAŽI";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1460, 551);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(110, 40);
            this.btn_nazad.TabIndex = 4;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // Clanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1582, 603);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_uclani);
            this.Controls.Add(this.dgv_clanovi);
            this.Name = "Clanovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Članovi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_clanovi;
        private Button btn_uclani;
        private Button btn_izbrisi;
        private Button btn_pretrazi;
        private Button btn_nazad;
    }
}