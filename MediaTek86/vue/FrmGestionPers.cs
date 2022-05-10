using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// vue de l'application servant à la gestion du personnel et des abscences
    /// </summary>
    public partial class FrmGestionPers : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private readonly Controle controle;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean Modif = false;
        /// <summary>
        /// Booléen pour savoir si l'on est dans la partie gestion des absences
        /// </summary>
        private Boolean GestionAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// constructeur de la FrmGestionPers
        /// </summary>
        /// <param name="controle">Instance de la classe Controle</param>
        public FrmGestionPers(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListePersonnel();
            GestionAbsence = false;
            GrpListe.Enabled = true;
            DgvListePersonnel.Enabled = true;
            GrpAbsence.Enabled = false;
            GrpAjoutPers.Enabled = false;
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            DgvListePersonnel.DataSource = bdgPersonnels;
            DgvListePersonnel.Columns["idservice"].Visible = false;
            DgvListePersonnel.Columns["idpersonnel"].Visible = false;
            DgvListePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirListeAbsence()
        {
            int idpersonnel = (int)DgvListePersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
            List<Absence> lesAbsences = controle.GetLesAbsences(idpersonnel);
            bdgAbsence.DataSource = lesAbsences;
            DgvListePersonnel.DataSource = bdgAbsence;
            DgvListePersonnel.Columns["idpersonnel"].Visible = false;
            DgvListePersonnel.Columns["idmotif"].Visible = false;
            DgvListePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les profils
        /// </summary>
        public void RemplissageCboService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            CboService.DataSource = bdgService;
            if (CboService.Items.Count > 0)
            {
                CboService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evenement clic sur le bouton ajout personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (!GestionAbsence)
            {
                RemplissageCboService();
                GestionAffichage("Ajout");
            }
        }

        /// <summary>
        /// methode permettant de gerer les accessibilité en cours d'ajout ou de modif d'un personnel ou d'une absence
        /// </summary>
        /// <param name="type"></param>
        private void GestionAffichage(string type)
        {
            GrpListe.Enabled = false;
            if (type.Equals("Ajout"))
            {
                GrpAbsence.Enabled = false;
                GrpAjoutPers.Enabled = true;
                DgvListePersonnel.Enabled = false;
            }
            else
            {
                GrpAjoutPers.Enabled = false;
                GrpAbsence.Enabled = true;
                DgvListePersonnel.Enabled = false;
            }
        }

        /// <summary>
        /// Methode permettant d'annuler un ajout en cours et revenir dans un état initial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerAjoutPers_Click(object sender, EventArgs e)
        {
            Init();
            ViderChamps("Ajout");
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderPers_Click(object sender, EventArgs e)
        {
            if (!TxtNom.Text.Equals("") && !TxtPrenom.Text.Equals("") && !TxtTel.Text.Equals("") && !TxtMail.Text.Equals("") && CboService.SelectedIndex != -1)
            {
                Service unService = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = 0;
                if (Modif)
                {
                    idpersonnel = (int)DgvListePersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel unPersonnel = new Personnel(idpersonnel, TxtNom.Text, TxtPrenom.Text, TxtTel.Text, TxtMail.Text, unService.Idservice, unService.Nom);

                if (Modif)
                {
                    controle.UpdatePersonnel(unPersonnel);
                    Modif = false;
                }
                else
                {
                    controle.AjoutPersonnel(unPersonnel);
                }
                Init();
                ViderChamps("Ajout");
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// méthode pour vider les champs
        /// </summary>
        /// <param name="type"></param>
        private void ViderChamps(string type)
        {
            if (type.Equals("Ajout"))
            {
                TxtMail.Text = "";
                TxtNom.Text = "";
                TxtPrenom.Text = "";
                TxtTel.Text = "";
            }
        }

        /// <summary>
        /// clic sur le bouton pour supprimer un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (!GestionAbsence)
            {
                if (DgvListePersonnel.SelectedRows.Count > 0)
                {
                    Personnel unPersonnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    if (MessageBox.Show("Voulez-vous vraiment supprimer " + unPersonnel.Nom + " " + unPersonnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.SuppPersonnel(unPersonnel);
                        Init();
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
                Init();
            }
        }

        /// <summary>
        /// Bouton servant a modifier les données d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (!GestionAbsence)
            {
                if (DgvListePersonnel.SelectedRows.Count > 0)
                {
                    DgvListePersonnel.Enabled = false;
                    Modif = true;
                    GestionAffichage("Ajout");
                    RemplissageCboService();
                    Personnel unPersonnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    TxtNom.Text = unPersonnel.Nom;
                    TxtPrenom.Text = unPersonnel.Prenom;
                    TxtMail.Text = unPersonnel.Mail;
                    TxtTel.Text = unPersonnel.Tel;
                    CboService.SelectedItem = unPersonnel.IdService;
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
        }

        /// <summary>
        /// Bouton pour gerer les absences d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsence_Click(object sender, EventArgs e)
        {
            if (BtnAbsence.Text.Equals("Retour à la liste"))
            {
                Init();
                BtnAbsence.Text = "Afficher les absences";
            }
            else
            {
                if (DgvListePersonnel.SelectedRows.Count > 0)
                {
                    RemplirListeAbsence();
                    GestionAbsence = true;
                    BtnAbsence.Text = "Retour à la liste";
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
        } 
    }
}
