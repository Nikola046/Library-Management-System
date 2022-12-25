namespace Biblioteka
{
    partial class Knjige
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
            this.dgv_knjige = new System.Windows.Forms.DataGridView();
            this.btn_pretrazi_k = new System.Windows.Forms.Button();
            this.btn_izdaj = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_knjige)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_knjige
            // 
            this.dgv_knjige.AllowUserToDeleteRows = false;
            this.dgv_knjige.AllowUserToResizeRows = false;
            this.dgv_knjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_knjige.Location = new System.Drawing.Point(12, 12);
            this.dgv_knjige.MultiSelect = false;
            this.dgv_knjige.Name = "dgv_knjige";
            this.dgv_knjige.ReadOnly = true;
            this.dgv_knjige.RowHeadersWidth = 51;
            this.dgv_knjige.RowTemplate.Height = 29;
            this.dgv_knjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_knjige.Size = new System.Drawing.Size(863, 458);
            this.dgv_knjige.TabIndex = 0;
            this.dgv_knjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_knjige_CellContentClick);
            // 
            // btn_pretrazi_k
            // 
            this.btn_pretrazi_k.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi_k.Location = new System.Drawing.Point(932, 44);
            this.btn_pretrazi_k.Name = "btn_pretrazi_k";
            this.btn_pretrazi_k.Size = new System.Drawing.Size(160, 60);
            this.btn_pretrazi_k.TabIndex = 1;
            this.btn_pretrazi_k.Text = "PRETRAŽI";
            this.btn_pretrazi_k.UseVisualStyleBackColor = true;
            this.btn_pretrazi_k.Click += new System.EventHandler(this.btn_pretrazi_k_Click);
            // 
            // btn_izdaj
            // 
            this.btn_izdaj.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izdaj.Location = new System.Drawing.Point(932, 181);
            this.btn_izdaj.Name = "btn_izdaj";
            this.btn_izdaj.Size = new System.Drawing.Size(160, 60);
            this.btn_izdaj.TabIndex = 2;
            this.btn_izdaj.Text = "IZDAJ";
            this.btn_izdaj.UseVisualStyleBackColor = true;
            this.btn_izdaj.Click += new System.EventHandler(this.btn_izdaj_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1000, 451);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(110, 40);
            this.btn_nazad.TabIndex = 3;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1122, 503);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_izdaj);
            this.Controls.Add(this.btn_pretrazi_k);
            this.Controls.Add(this.dgv_knjige);
            this.Name = "Knjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_knjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_knjige;
        private Button btn_pretrazi_k;
        private Button btn_izdaj;
        private Button btn_nazad;
    }
}