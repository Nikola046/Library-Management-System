namespace Biblioteka
{
    partial class Izdavanje
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
            this.tb_id_knjiga = new System.Windows.Forms.TextBox();
            this.btn_potvrdi = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_clan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite ID knjige:";
            // 
            // tb_id_knjiga
            // 
            this.tb_id_knjiga.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_knjiga.Location = new System.Drawing.Point(382, 32);
            this.tb_id_knjiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id_knjiga.Name = "tb_id_knjiga";
            this.tb_id_knjiga.Size = new System.Drawing.Size(224, 35);
            this.tb_id_knjiga.TabIndex = 8;
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_potvrdi.Location = new System.Drawing.Point(307, 219);
            this.btn_potvrdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(144, 45);
            this.btn_potvrdi.TabIndex = 15;
            this.btn_potvrdi.Text = "POTVRDI";
            this.btn_potvrdi.UseVisualStyleBackColor = true;
            this.btn_potvrdi.Click += new System.EventHandler(this.btn_potvrdi_Click);
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
            this.btn_nazad.TabIndex = 17;
            this.btn_nazad.Text = "NAZAD";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Unesite ID člana:";
            // 
            // tb_id_clan
            // 
            this.tb_id_clan.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id_clan.Location = new System.Drawing.Point(382, 111);
            this.tb_id_clan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id_clan.Name = "tb_id_clan";
            this.tb_id_clan.Size = new System.Drawing.Size(224, 35);
            this.tb_id_clan.TabIndex = 19;
            // 
            // Izdavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(982, 377);
            this.Controls.Add(this.tb_id_clan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.tb_id_knjiga);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Izdavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_id_knjiga;
        private Button btn_potvrdi;
        private Button btn_nazad;
        private Label label2;
        private TextBox tb_id_clan;
    }
}