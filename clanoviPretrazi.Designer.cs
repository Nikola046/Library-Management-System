namespace Biblioteka
{
    partial class clanoviPretrazi
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
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.dgv_clanovi_pretrazi = new System.Windows.Forms.DataGridView();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clanovi_pretrazi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "IME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "PREZIME:";
            // 
            // tb_ime
            // 
            this.tb_ime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ime.Location = new System.Drawing.Point(142, 28);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(450, 42);
            this.tb_ime.TabIndex = 6;
            // 
            // tb_prezime
            // 
            this.tb_prezime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_prezime.Location = new System.Drawing.Point(241, 108);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(450, 42);
            this.tb_prezime.TabIndex = 7;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi.Location = new System.Drawing.Point(843, 12);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(165, 60);
            this.btn_pretrazi.TabIndex = 13;
            this.btn_pretrazi.Text = "PRETRAŽI";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // dgv_clanovi_pretrazi
            // 
            this.dgv_clanovi_pretrazi.AllowUserToAddRows = false;
            this.dgv_clanovi_pretrazi.AllowUserToDeleteRows = false;
            this.dgv_clanovi_pretrazi.AllowUserToResizeRows = false;
            this.dgv_clanovi_pretrazi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clanovi_pretrazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clanovi_pretrazi.Location = new System.Drawing.Point(12, 213);
            this.dgv_clanovi_pretrazi.MultiSelect = false;
            this.dgv_clanovi_pretrazi.Name = "dgv_clanovi_pretrazi";
            this.dgv_clanovi_pretrazi.ReadOnly = true;
            this.dgv_clanovi_pretrazi.RowHeadersWidth = 51;
            this.dgv_clanovi_pretrazi.RowTemplate.Height = 29;
            this.dgv_clanovi_pretrazi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clanovi_pretrazi.Size = new System.Drawing.Size(1215, 348);
            this.dgv_clanovi_pretrazi.TabIndex = 14;
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izbrisi.Location = new System.Drawing.Point(843, 100);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(160, 60);
            this.btn_izbrisi.TabIndex = 15;
            this.btn_izbrisi.Text = "IZBRIŠI";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1260, 551);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(110, 40);
            this.btn_nazad.TabIndex = 16;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // clanoviPretrazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.dgv_clanovi_pretrazi);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.tb_prezime);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clanoviPretrazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clanovi_pretrazi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_ime;
        private TextBox tb_prezime;
        private Button btn_pretrazi;
        private DataGridView dgv_clanovi_pretrazi;
        private Button btn_izbrisi;
        private Button btn_nazad;
    }
}