using MediaTek86.dal;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controleur
{
    public class Controle
    {
        /// <summary>
        /// fenêtre d'authentification
        /// </summary>
        private readonly FrmAuthentification frmAuthentification;
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>true or false</returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmAuthentification.Hide();
                (new FrmGestionPers(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
