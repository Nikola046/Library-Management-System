namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_dobrodosli = new System.Windows.Forms.Label();
            this.lbl_kor_ime = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.tb_kor_ime = new System.Windows.Forms.TextBox();
            this.tb_lozinka = new System.Windows.Forms.TextBox();
            this.btn_prijavi_se = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dobrodosli
            // 
            this.lbl_dobrodosli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dobrodosli.AutoSize = true;
            this.lbl_dobrodosli.BackColor = System.Drawing.Color.Azure;
            this.lbl_dobrodosli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_dobrodosli.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dobrodosli.Location = new System.Drawing.Point(95, 9);
            this.lbl_dobrodosli.Name = "lbl_dobrodosli";
            this.lbl_dobrodosli.Size = new System.Drawing.Size(283, 59);
            this.lbl_dobrodosli.TabIndex = 0;
            this.lbl_dobrodosli.Text = "Dobro došli";
            // 
            // lbl_kor_ime
            // 
            this.lbl_kor_ime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_kor_ime.AutoSize = true;
            this.lbl_kor_ime.BackColor = System.Drawing.Color.Azure;
            this.lbl_kor_ime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_kor_ime.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kor_ime.Location = new System.Drawing.Point(11, 101);
            this.lbl_kor_ime.Name = "lbl_kor_ime";
            this.lbl_kor_ime.Size = new System.Drawing.Size(268, 44);
            this.lbl_kor_ime.TabIndex = 1;
            this.lbl_kor_ime.Text = "Korisničko ime:";
            this.lbl_kor_ime.Click += new System.EventHandler(this.lbl_kor_ime_Click);
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.BackColor = System.Drawing.Color.Azure;
            this.lbl_lozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lozinka.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lozinka.Location = new System.Drawing.Point(11, 271);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(157, 44);
            this.lbl_lozinka.TabIndex = 2;
            this.lbl_lozinka.Text = "Lozinka:";
            this.lbl_lozinka.Click += new System.EventHandler(this.lbl_lozinka_Click);
            // 
            // tb_kor_ime
            // 
            this.tb_kor_ime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_kor_ime.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_kor_ime.Location = new System.Drawing.Point(11, 173);
            this.tb_kor_ime.Name = "tb_kor_ime";
            this.tb_kor_ime.Size = new System.Drawing.Size(247, 39);
            this.tb_kor_ime.TabIndex = 3;
            this.tb_kor_ime.TextChanged += new System.EventHandler(this.tb_kor_ime_TextChanged);
            // 
            // tb_lozinka
            // 
            this.tb_lozinka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_lozinka.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lozinka.Location = new System.Drawing.Point(11, 335);
            this.tb_lozinka.Name = "tb_lozinka";
            this.tb_lozinka.PasswordChar = '*';
            this.tb_lozinka.Size = new System.Drawing.Size(247, 39);
            this.tb_lozinka.TabIndex = 4;
            this.tb_lozinka.TextChanged += new System.EventHandler(this.tb_lozinka_TextChanged);
            // 
            // btn_prijavi_se
            // 
            this.btn_prijavi_se.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_prijavi_se.BackColor = System.Drawing.Color.Red;
            this.btn_prijavi_se.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_prijavi_se.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_prijavi_se.Location = new System.Drawing.Point(158, 411);
            this.btn_prijavi_se.Name = "btn_prijavi_se";
            this.btn_prijavi_se.Size = new System.Drawing.Size(170, 51);
            this.btn_prijavi_se.TabIndex = 5;
            this.btn_prijavi_se.Text = "Prijavi se";
            this.btn_prijavi_se.UseVisualStyleBackColor = false;
            this.btn_prijavi_se.Click += new System.EventHandler(this.btn_prijavi_se_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.btn_prijavi_se);
            this.Controls.Add(this.tb_lozinka);
            this.Controls.Add(this.tb_kor_ime);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_kor_ime);
            this.Controls.Add(this.lbl_dobrodosli);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_dobrodosli;
        private Label lbl_kor_ime;
        private Label lbl_lozinka;
        private TextBox tb_kor_ime;
        private TextBox tb_lozinka;
        private Button btn_prijavi_se;
    }
}