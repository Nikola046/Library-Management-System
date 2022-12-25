namespace Biblioteka
{
    partial class pretraziknjige
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
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pisac = new System.Windows.Forms.TextBox();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.dgv_pretrazi_knjige = new System.Windows.Forms.DataGridView();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.btn_izdaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pretrazi_knjige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAZIV:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_naziv.Location = new System.Drawing.Point(159, 22);
            this.tb_naziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(394, 35);
            this.tb_naziv.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "PISAC:";
            // 
            // tb_pisac
            // 
            this.tb_pisac.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pisac.Location = new System.Drawing.Point(159, 82);
            this.tb_pisac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pisac.Name = "tb_pisac";
            this.tb_pisac.Size = new System.Drawing.Size(394, 35);
            this.tb_pisac.TabIndex = 10;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi.Location = new System.Drawing.Point(684, 68);
            this.btn_pretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(144, 45);
            this.btn_pretrazi.TabIndex = 15;
            this.btn_pretrazi.Text = "PRETRAŽI";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // dgv_pretrazi_knjige
            // 
            this.dgv_pretrazi_knjige.AllowUserToDeleteRows = false;
            this.dgv_pretrazi_knjige.AllowUserToResizeRows = false;
            this.dgv_pretrazi_knjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pretrazi_knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pretrazi_knjige.Location = new System.Drawing.Point(10, 153);
            this.dgv_pretrazi_knjige.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_pretrazi_knjige.MultiSelect = false;
            this.dgv_pretrazi_knjige.Name = "dgv_pretrazi_knjige";
            this.dgv_pretrazi_knjige.RowHeadersWidth = 51;
            this.dgv_pretrazi_knjige.RowTemplate.Height = 29;
            this.dgv_pretrazi_knjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pretrazi_knjige.Size = new System.Drawing.Size(900, 215);
            this.dgv_pretrazi_knjige.TabIndex = 16;
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(1015, 338);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(96, 30);
            this.btn_nazad.TabIndex = 17;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // btn_izdaj
            // 
            this.btn_izdaj.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_izdaj.Location = new System.Drawing.Point(971, 72);
            this.btn_izdaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izdaj.Name = "btn_izdaj";
            this.btn_izdaj.Size = new System.Drawing.Size(140, 45);
            this.btn_izdaj.TabIndex = 18;
            this.btn_izdaj.Text = "IZDAJ";
            this.btn_izdaj.UseVisualStyleBackColor = true;
            this.btn_izdaj.Click += new System.EventHandler(this.btn_izdaj_Click);
            // 
            // pretraziknjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1122, 377);
            this.Controls.Add(this.btn_izdaj);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.dgv_pretrazi_knjige);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.tb_pisac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pretraziknjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pretrazi_knjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_naziv;
        private Label label2;
        private TextBox tb_pisac;
        private Button btn_pretrazi;
        private DataGridView dgv_pretrazi_knjige;
        private Button btn_nazad;
        private Button btn_izdaj;
    }
}