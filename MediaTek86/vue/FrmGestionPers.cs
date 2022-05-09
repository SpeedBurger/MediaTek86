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
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private readonly BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
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
            GrpListe.Enabled = true;
            GrpAbsence.Enabled = false;
            GrpAjoutPers.Enabled = false;
            BtnAjouterAbsence.Visible = false;
            BtnModifierAbsence.Visible = false;
            BtnSupprimerAbsence.Visible = false;
            BtnRetourListe.Visible = false;
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            DgvListePersonnel.DataSource = bdgPersonnels;
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
        private void BtnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            RemplissageCboService();
            EnCoursDeModif("Ajout");
        }

        /// <summary>
        /// methode permettant de gerer les accessibilité en cours d'ajout ou de modif d'un personnel ou d'une absence
        /// </summary>
        /// <param name="type"></param>
        private void EnCoursDeModif(string type)
        {
            GrpListe.Enabled = false;
            if (type.Equals("Ajout"))
            {
                GrpAbsence.Enabled = false;
                GrpAjoutPers.Enabled = true;
            }
            else
            {
                GrpAjoutPers.Enabled = false;
                GrpAbsence.Enabled = true;
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
            TxtMail.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtTel.Text = "";
        }
    }
}
