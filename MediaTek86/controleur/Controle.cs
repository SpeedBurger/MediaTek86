using MediaTek86.dal;
using MediaTek86.modele;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controleur
{
    /// <summary>
    /// Classe s'occupant des dialogues entre modele et vue conformement au MVC
    /// </summary>
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

        /// <summary>
        /// Récupère et retourne les infos des personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les noms des services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les noms des motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            return AccesDonnees.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AjoutPersonnel(Personnel personnel)
        {
            AccesDonnees.AjoutPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="unPersonnel"></param>
        public void SuppPersonnel(Personnel unPersonnel)
        {
            AccesDonnees.SuppPersonnel(unPersonnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="unPersonnel"></param>
        public void UpdatePersonnel(Personnel unPersonnel)
        {
            AccesDonnees.UpdatePersonnel(unPersonnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="uneAbsence"></param>
        public void SuppAbsence(Absence uneAbsence)
        {
            AccesDonnees.SuppAbsence(uneAbsence);
        }
    }
}
