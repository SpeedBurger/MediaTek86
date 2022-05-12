using MediaTek86.controleur;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// vue qui sert a se connecter à l'application avec un couple login pwd
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private readonly Controle controle;

        /// <summary>
        /// Constructeur de la FrmAuthentificiation
        /// </summary>
        /// <param name="controle"></param>
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            BtnConnecter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnConnecter.png"));
        }

        /// <summary>
        /// Clic sur le bouton connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnecter_Click(object sender, EventArgs e)
        {
            if (!TxtLogin.Text.Equals("") && !TxtPwd.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(TxtLogin.Text, TxtPwd.Text))
                {
                    MessageBox.Show("Login ou mot de passe éronnés, veuillez recommencer.", "Alerte");
                    TxtLogin.Text = "";
                    TxtPwd.Text = "";
                    TxtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Appuie sur la touche entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnConnecter_Click(null, null);
            }
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnConnecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnecter_MouseEnter(object sender, EventArgs e)
        {
            BtnConnecter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnConnecterHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant du BtnConnecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnecter_MouseLeave(object sender, EventArgs e)
        {
            BtnConnecter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnConnecter.png"));
        }
    }
}
