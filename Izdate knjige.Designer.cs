namespace Biblioteka
{
    partial class Izdate_knjige
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
            this.dgv_izdate_knjige = new System.Windows.Forms.DataGridView();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_izdate_knjige)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_izdate_knjige
            // 
            this.dgv_izdate_knjige.AllowUserToDeleteRows = false;
            this.dgv_izdate_knjige.AllowUserToResizeRows = false;
            this.dgv_izdate_knjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_izdate_knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_izdate_knjige.Location = new System.Drawing.Point(11, 12);
            this.dgv_izdate_knjige.MultiSelect = false;
            this.dgv_izdate_knjige.Name = "dgv_izdate_knjige";
            this.dgv_izdate_knjige.RowHeadersWidth = 51;
            this.dgv_izdate_knjige.RowTemplate.Height = 29;
            this.dgv_izdate_knjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_izdate_knjige.Size = new System.Drawing.Size(855, 435);
            this.dgv_izdate_knjige.TabIndex = 0;
            this.dgv_izdate_knjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_izdate_knjige_CellContentClick);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1000, 451);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(110, 40);
            this.btn_nazad.TabIndex = 1;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi.Location = new System.Drawing.Point(893, 128);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(165, 60);
            this.btn_pretrazi.TabIndex = 14;
            this.btn_pretrazi.Text = "PRETRAŽI";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // Izdate_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1122, 503);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.dgv_izdate_knjige);
            this.Name = "Izdate_knjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdate knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_izdate_knjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_izdate_knjige;
        private Button btn_nazad;
        private Button btn_pretrazi;
    }
}