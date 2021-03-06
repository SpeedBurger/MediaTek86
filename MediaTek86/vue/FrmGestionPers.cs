using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        /// Objet pour gérer la liste des services
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Variable contenant l'idpersonnel d'une personne
        /// </summary>
        private int IdPersonnel;

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
            GestionAbsence = false;
            GrpListe.Text = "Liste du personnel";
            RemplirListePersonnel();
            RemplissageCboService();
            RemplissageCboMotif();
            GestionAffichage("Init");
            ViderChamps();
            InitialisationBoutons();
        }

        /// <summary>
        /// Initialisation des différents boutons.
        /// </summary>
        public void InitialisationBoutons()
        {
            BtnAfficher.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsence.png"));
            BtnAfficher.Visible = true;
            BtnRetour.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsenceRetour.png"));
            BtnRetour.Visible = false;
            BtnAjouter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAjouter.png"));
            BtnModifier.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnModifier.png"));
            BtnSupprimer.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnSupprimer.png"));
            BtnValiderPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValider.png"));
            BtnAnnulerPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnuler.png"));
            BtnValiderAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValider.png"));
            BtnAnnulerAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnuler.png"));
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
            List<Absence> lesAbsences = controle.GetLesAbsences(IdPersonnel);
            bdgAbsence.DataSource = lesAbsences;
            DgvListePersonnel.DataSource = bdgAbsence;
            DgvListePersonnel.Columns["idpersonnel"].Visible = false;
            DgvListePersonnel.Columns["idmotif"].Visible = false;
            DgvListePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        ///  Remplit le combo des servcices
        /// </summary>
        public void RemplissageCboService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            CboService.DataSource = bdgService;
        }

        /// <summary>
        /// Remplit le combo des motifs
        /// </summary>
        public void RemplissageCboMotif()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            CboMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// méthode pour vider les champs
        /// </summary>
        private void ViderChamps()
        {
            TxtMail.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtTel.Text = "";
            CboMotif.SelectedIndex = -1;
            CboService.SelectedIndex = -1;
            DtpDebut.Value = DateTime.Now;
            DtpFin.Value = DateTime.Now;
        }

        /// <summary>
        /// methode permettant de gerer les accessibilité en cours d'ajout ou de modif d'un personnel ou d'une absence
        /// </summary>
        /// <param name="type"></param>
        private void GestionAffichage(string type)
        {
            switch (type)
            {
                case "Ajout":
                    GrpAbsence.Enabled = false;
                    GrpAjoutPers.Enabled = true;
                    DgvListePersonnel.Enabled = false;
                    GrpListe.Enabled = false;
                    BtnValiderPers.Visible = true;
                    BtnAnnulerPers.Visible = true;
                    BtnValiderAbsence.Visible = false;
                    BtnAnnulerAbsence.Visible = false;
                    BtnModifier.Visible = false;
                    BtnAjouter.Visible = false;
                    BtnSupprimer.Visible = false;
                    BtnAfficher.Visible = false;
                    break;
                case "Absence":
                    GrpAbsence.Enabled = true;
                    GrpAjoutPers.Enabled = false;
                    DgvListePersonnel.Enabled = false;
                    GrpListe.Enabled = false;
                    BtnValiderPers.Visible = false;
                    BtnAnnulerPers.Visible = false;
                    BtnValiderAbsence.Visible = true;
                    BtnAnnulerAbsence.Visible = true;
                    BtnModifier.Visible = false;
                    BtnAjouter.Visible = false;
                    BtnSupprimer.Visible = false;
                    BtnAfficher.Visible = false;
                    BtnRetour.Visible = false;
                    break;
                case "Init":
                    GrpAbsence.Enabled = false;
                    GrpAjoutPers.Enabled = false;
                    DgvListePersonnel.Enabled = true;
                    GrpListe.Enabled = true;
                    BtnValiderPers.Visible = false;
                    BtnAnnulerPers.Visible = false;
                    BtnValiderAbsence.Visible = false;
                    BtnAnnulerAbsence.Visible = false;
                    BtnModifier.Visible = true;
                    BtnAjouter.Visible = true;
                    BtnSupprimer.Visible = true;
                    BtnAfficher.Visible = true;
                    break;
                case "RetourListe":
                    GrpAbsence.Enabled = false;
                    GrpAjoutPers.Enabled = false;
                    DgvListePersonnel.Enabled = true;
                    GrpListe.Enabled = true;
                    BtnValiderPers.Visible = false;
                    BtnAnnulerPers.Visible = false;
                    BtnValiderAbsence.Visible = false;
                    BtnAnnulerAbsence.Visible = false;
                    BtnModifier.Visible = true;
                    BtnAjouter.Visible = true;
                    BtnSupprimer.Visible = true;
                    BtnAfficher.Visible = false;
                    BtnRetour.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Methode permettant d'annuler un ajout en cours et revenir dans un état initial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerPers_Click(object sender, EventArgs e)
        {
            Init();
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
                    if (MessageBox.Show("Voulez-vous vraiment modifier le personnel ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.UpdatePersonnel(unPersonnel);
                        Modif = false;
                    }
                }
                else
                {
                    controle.AjoutPersonnel(unPersonnel);
                }
                Init();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Evenement clic sur le bouton ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (!GestionAbsence)
            {
                GestionAffichage("Ajout");
            }
            else
            {
                GestionAffichage("Absence");
            }
        }

        /// <summary>
        /// clic sur le bouton supprimer
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
            else
            {
                if (DgvListePersonnel.SelectedRows.Count > 0)
                {
                    Absence uneAbsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.SuppAbsence(uneAbsence);
                        RemplirListeAbsence();
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
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
                    Modif = true;
                    GestionAffichage("Ajout");
                    Personnel unPersonnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    TxtNom.Text = unPersonnel.Nom;
                    TxtPrenom.Text = unPersonnel.Prenom;
                    TxtMail.Text = unPersonnel.Mail;
                    TxtTel.Text = unPersonnel.Tel;
                    CboService.SelectedIndex = unPersonnel.IdService - 1;
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
            else
            {
                if (DgvListePersonnel.SelectedRows.Count > 0)
                {
                    Modif = true;
                    GestionAffichage("Absence");
                    Absence uneAbsence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    DtpDebut.Value = uneAbsence.DateDebut;
                    DtpFin.Value = uneAbsence.DateFin;
                    CboMotif.SelectedIndex = uneAbsence.IdMotif - 1;
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
        }

        /// <summary>
        /// Clic sur le BtnAnnulerAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            if (Modif)
            {
                Modif = false;
            }
            ViderChamps();
            GestionAffichage("RetourListe");
        }
        /// <summary>
        /// Clic sur BtnValiderAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderAbsence_Click(object sender, EventArgs e)
        {
            if (CboMotif.SelectedIndex != -1)
            {
                if (DtpFin.Value > DtpDebut.Value)
                {
                    Motif unMotif = (Motif)bdgMotif.List[bdgMotif.Position];
                    Absence uneAbsence = new Absence(IdPersonnel, unMotif.IdMotif, unMotif.Libelle, DtpDebut.Value, DtpFin.Value);

                    if (Modif)
                    {
                        if (MessageBox.Show("Voulez-vous vraiment modifier l'absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DateTime uneDate = (DateTime)DgvListePersonnel.SelectedRows[0].Cells["datedebut"].Value;
                            controle.UpdateAbsence(uneAbsence, uneDate);
                            Modif = false;
                        }
                    }
                    else
                    {
                        controle.AjoutAbsence(uneAbsence);
                    }
                    RemplirListeAbsence();
                    GestionAffichage("RetourListe");
                }
                else
                {
                    MessageBox.Show("La date de fin est antérieure à la date dé début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// Evenement lors du clic sur le BtnRetour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            BtnRetour.Visible = false;
            Init();
        }
        /// <summary>
        /// Evenement lors du clic sur le BtnAfficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            if (DgvListePersonnel.SelectedRows.Count > 0)
            {
                IdPersonnel = (int)DgvListePersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                RemplirListeAbsence();
                GestionAbsence = true;
                BtnAfficher.Visible = false;
                BtnRetour.Visible = true;
                GrpListe.Text = "Liste des absences";
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnRetour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRetour_MouseEnter(object sender, EventArgs e)
        {
            BtnRetour.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsenceRetourHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnRetour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRetour_MouseLeave(object sender, EventArgs e)
        {
            BtnRetour.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsenceRetour.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnAfficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficher_MouseEnter(object sender, EventArgs e)
        {
            BtnAfficher.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsenceHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnAfficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficher_MouseLeave(object sender, EventArgs e)
        {
            BtnAfficher.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAbsence.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnModifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_MouseEnter(object sender, EventArgs e)
        {
            BtnModifier.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnModifierHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sotant BtnModifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifier_MouseLeave(object sender, EventArgs e)
        {
            BtnModifier.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnModifier.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnSupprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            BtnSupprimer.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnSupprimerHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnSupprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            BtnSupprimer.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnSupprimer.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnAjouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_MouseEnter(object sender, EventArgs e)
        {
            BtnAjouter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAjouterHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnAjouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_MouseLeave(object sender, EventArgs e)
        {
            BtnAjouter.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAjouter.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnValiderAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderAbsence_MouseEnter(object sender, EventArgs e)
        {
            BtnValiderAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValiderHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnValiderAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderAbsence_MouseLeave(object sender, EventArgs e)
        {
            BtnValiderAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValider.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnAnnulerAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerAbsence_MouseEnter(object sender, EventArgs e)
        {
            BtnAnnulerAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnulerHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnAnnulerAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerAbsence_MouseLeave(object sender, EventArgs e)
        {
            BtnAnnulerAbsence.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnuler.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnValiderPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderPers_MouseEnter(object sender, EventArgs e)
        {
            BtnValiderPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValiderHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnValiderPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValiderPers_MouseLeave(object sender, EventArgs e)
        {
            BtnValiderPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnValider.png"));
        }
        /// <summary>
        /// Evenement lors du survol entrant BtnAnnulerPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerPers_MouseEnter(object sender, EventArgs e)
        {
            BtnAnnulerPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnulerHover.png"));
        }
        /// <summary>
        /// Evenement lors du survol sortant BtnAnnulerPers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnulerPers_MouseLeave(object sender, EventArgs e)
        {
            BtnAnnulerPers.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/BtnAnnuler.png"));
        }
    }
}
