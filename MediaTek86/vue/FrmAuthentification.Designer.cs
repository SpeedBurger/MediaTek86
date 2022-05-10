
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
            this.BtnConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(133, 62);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(324, 26);
            this.TxtPwd.TabIndex = 9;
            this.TxtPwd.UseSystemPasswordChar = true;
            this.TxtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPwd_KeyPress);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(133, 12);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(324, 26);
            this.TxtLogin.TabIndex = 8;
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(17, 65);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(105, 20);
            this.LblPwd.TabIndex = 7;
            this.LblPwd.Text = "Mot de passe";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(17, 15);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(48, 20);
            this.LblLogin.TabIndex = 6;
            this.LblLogin.Text = "Login";
            // 
            // BtnConnecter
            // 
            this.BtnConnecter.Location = new System.Drawing.Point(292, 105);
            this.BtnConnecter.Name = "BtnConnecter";
            this.BtnConnecter.Size = new System.Drawing.Size(165, 40);
            this.BtnConnecter.TabIndex = 5;
            this.BtnConnecter.Text = "Connecter";
            this.BtnConnecter.UseVisualStyleBackColor = true;
            this.BtnConnecter.Click += new System.EventHandler(this.BtnConnecter_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 162);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.BtnConnecter);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Button BtnConnecter;
    }
}