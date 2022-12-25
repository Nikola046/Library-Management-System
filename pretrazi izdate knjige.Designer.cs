namespace Biblioteka
{
    partial class pretrazi_izdate_knjige
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
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_pisac = new System.Windows.Forms.TextBox();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.dgv_pretrazi_izdate_knjige = new System.Windows.Forms.DataGridView();
            this.btn_nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pretrazi_izdate_knjige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAZIV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "PISAC:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_naziv.Location = new System.Drawing.Point(167, 26);
            this.tb_naziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(394, 35);
            this.tb_naziv.TabIndex = 7;
            // 
            // tb_pisac
            // 
            this.tb_pisac.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pisac.Location = new System.Drawing.Point(167, 88);
            this.tb_pisac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pisac.Name = "tb_pisac";
            this.tb_pisac.Size = new System.Drawing.Size(394, 35);
            this.tb_pisac.TabIndex = 8;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pretrazi.Location = new System.Drawing.Point(696, 74);
            this.btn_pretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(144, 45);
            this.btn_pretrazi.TabIndex = 14;
            this.btn_pretrazi.Text = "PRETRAŽI";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.btn_pretrazi_Click);
            // 
            // dgv_pretrazi_izdate_knjige
            // 
            this.dgv_pretrazi_izdate_knjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pretrazi_izdate_knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pretrazi_izdate_knjige.Location = new System.Drawing.Point(10, 159);
            this.dgv_pretrazi_izdate_knjige.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_pretrazi_izdate_knjige.Name = "dgv_pretrazi_izdate_knjige";
            this.dgv_pretrazi_izdate_knjige.RowHeadersWidth = 51;
            this.dgv_pretrazi_izdate_knjige.RowTemplate.Height = 29;
            this.dgv_pretrazi_izdate_knjige.Size = new System.Drawing.Size(690, 202);
            this.dgv_pretrazi_izdate_knjige.TabIndex = 15;
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Red;
            this.btn_nazad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nazad.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_nazad.Location = new System.Drawing.Point(875, 338);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(96, 30);
            this.btn_nazad.TabIndex = 16;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // pretrazi_izdate_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(982, 377);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.dgv_pretrazi_izdate_knjige);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.tb_pisac);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pretrazi_izdate_knjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretrazi izdate knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pretrazi_izdate_knjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_naziv;
        private TextBox tb_pisac;
        private Button btn_pretrazi;
        private DataGridView dgv_pretrazi_izdate_knjige;
        private Button btn_nazad;
    }
}