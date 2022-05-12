
namespace MediaTek86.vue
{
    partial class FrmAuthentification
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
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblPwd = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.BtnConnecter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnecter)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(89, 40);
            this.TxtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(217, 20);
            this.TxtPwd.TabIndex = 9;
            this.TxtPwd.UseSystemPasswordChar = true;
            this.TxtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPwd_KeyPress);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(89, 8);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(217, 20);
            this.TxtLogin.TabIndex = 8;
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(11, 42);
            this.LblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(71, 13);
            this.LblPwd.TabIndex = 7;
            this.LblPwd.Text = "Mot de passe";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(11, 10);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(33, 13);
            this.LblLogin.TabIndex = 6;
            this.LblLogin.Text = "Login";
            // 
            // BtnConnecter
            // 
            this.BtnConnecter.Location = new System.Drawing.Point(196, 72);
            this.BtnConnecter.Name = "BtnConnecter";
            this.BtnConnecter.Size = new System.Drawing.Size(110, 26);
            this.BtnConnecter.TabIndex = 10;
            this.BtnConnecter.TabStop = false;
            this.BtnConnecter.Click += new System.EventHandler(this.BtnConnecter_Click);
            this.BtnConnecter.MouseEnter += new System.EventHandler(this.BtnConnecter_MouseEnter);
            this.BtnConnecter.MouseLeave += new System.EventHandler(this.BtnConnecter_MouseLeave);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 105);
            this.Controls.Add(this.BtnConnecter);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.BtnConnecter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.PictureBox BtnConnecter;
    }
}