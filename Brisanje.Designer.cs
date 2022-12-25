namespace Biblioteka
{
    partial class Brisanje
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
            this.btn_nazad = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            this.dgv_brisanje = new System.Windows.Forms.DataGridView();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brisanje)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1102, 413);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(96, 30);
            this.btn_nazad.TabIndex = 24;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izbrisi.Location = new System.Drawing.Point(934, 61);
            this.btn_izbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(140, 45);
            this.btn_izbrisi.TabIndex = 23;
            this.btn_izbrisi.Text = "IZBRIŠI";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // dgv_brisanje
            // 
            this.dgv_brisanje.AllowUserToAddRows = false;
            this.dgv_brisanje.AllowUserToDeleteRows = false;
            this.dgv_brisanje.AllowUserToResizeRows = false;
            this.dgv_brisanje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_brisanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brisanje.Location = new System.Drawing.Point(10, 160);
            this.dgv_brisanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_brisanje.MultiSelect = false;
            this.dgv_brisanje.Name = "dgv_brisanje";
            this.dgv_brisanje.ReadOnly = true;
            this.dgv_brisanje.RowHeadersWidth = 51;
            this.dgv_brisanje.RowTemplate.Height = 29;
            this.dgv_brisanje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_brisanje.Size = new System.Drawing.Size(1063, 261);
            this.dgv_brisanje.TabIndex = 22;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ID.Location = new System.Drawing.Point(374, 45);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(322, 35);
            this.tb_ID.TabIndex = 19;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Azure;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(10, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(320, 35);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "Unesite ID korisinika:";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // Brisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1209, 452);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.dgv_brisanje);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Brisanje";
            this.Text = "Brisanje";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brisanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_nazad;
        private Button btn_izbrisi;
        private DataGridView dgv_brisanje;
        private TextBox tb_ID;
        private Label lbl_id;
    }
}