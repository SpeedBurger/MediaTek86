
namespace MediaTek86.vue
{
    partial class FrmGestionPers
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
            this.DgvListePersonnel = new System.Windows.Forms.DataGridView();
            this.GrpAjoutPers = new System.Windows.Forms.GroupBox();
            this.BtnAnnulerPers = new System.Windows.Forms.Button();
            this.BtnValiderPers = new System.Windows.Forms.Button();
            this.LblTel = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblService = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.CboService = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.BtnSupprimerPerso = new System.Windows.Forms.Button();
            this.BtnModifierPerso = new System.Windows.Forms.Button();
            this.BtnAjouterPersonnel = new System.Windows.Forms.Button();
            this.GrpAbsence = new System.Windows.Forms.GroupBox();
            this.BtnAnnulerAbsence = new System.Windows.Forms.Button();
            this.BtnValiderAbsence = new System.Windows.Forms.Button();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.CboNom = new System.Windows.Forms.ComboBox();
            this.LblDebut = new System.Windows.Forms.Label();
            this.LblMotif = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblNom2 = new System.Windows.Forms.Label();
            this.CboMotif = new System.Windows.Forms.ComboBox();
            this.BtnAbsence = new System.Windows.Forms.Button();
            this.BtnSupprimerAbsence = new System.Windows.Forms.Button();
            this.BtnModifierAbsence = new System.Windows.Forms.Button();
            this.BtnAjouterAbsence = new System.Windows.Forms.Button();
            this.GrpListe = new System.Windows.Forms.GroupBox();
            this.BtnRetourListe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).BeginInit();
            this.GrpAjoutPers.SuspendLayout();
            this.GrpAbsence.SuspendLayout();
            this.GrpListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListePersonnel
            // 
            this.DgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListePersonnel.Location = new System.Drawing.Point(12, 35);
            this.DgvListePersonnel.Name = "DgvListePersonnel";
            this.DgvListePersonnel.RowHeadersWidth = 62;
            this.DgvListePersonnel.RowTemplate.Height = 28;
            this.DgvListePersonnel.Size = new System.Drawing.Size(874, 371);
            this.DgvListePersonnel.TabIndex = 0;
            // 
            // GrpAjoutPers
            // 
            this.GrpAjoutPers.BackColor = System.Drawing.SystemColors.Control;
            this.GrpAjoutPers.Controls.Add(this.BtnAnnulerPers);
            this.GrpAjoutPers.Controls.Add(this.BtnValiderPers);
            this.GrpAjoutPers.Controls.Add(this.LblTel);
            this.GrpAjoutPers.Controls.Add(this.LblMail);
            this.GrpAjoutPers.Controls.Add(this.LblService);
            this.GrpAjoutPers.Controls.Add(this.LblPrenom);
            this.GrpAjoutPers.Controls.Add(this.LblNom);
            this.GrpAjoutPers.Controls.Add(this.CboService);
            this.GrpAjoutPers.Controls.Add(this.TxtMail);
            this.GrpAjoutPers.Controls.Add(this.TxtTel);
            this.GrpAjoutPers.Controls.Add(this.TxtPrenom);
            this.GrpAjoutPers.Controls.Add(this.TxtNom);
            this.GrpAjoutPers.Location = new System.Drawing.Point(0, 469);
            this.GrpAjoutPers.Name = "GrpAjoutPers";
            this.GrpAjoutPers.Size = new System.Drawing.Size(892, 162);
            this.GrpAjoutPers.TabIndex = 2;
            this.GrpAjoutPers.TabStop = false;
            this.GrpAjoutPers.Text = "Ajout d\'un personnel";
            // 
            // BtnAnnulerPers
            // 
            this.BtnAnnulerPers.Location = new System.Drawing.Point(725, 110);
            this.BtnAnnulerPers.Name = "BtnAnnulerPers";
            this.BtnAnnulerPers.Size = new System.Drawing.Size(130, 34);
            this.BtnAnnulerPers.TabIndex = 14;
            this.BtnAnnulerPers.Text = "Annuler";
            this.BtnAnnulerPers.UseVisualStyleBackColor = true;
            this.BtnAnnulerPers.Click += new System.EventHandler(this.BtnAnnulerAjoutPers_Click);
            // 
            // BtnValiderPers
            // 
            this.BtnValiderPers.Location = new System.Drawing.Point(569, 110);
            this.BtnValiderPers.Name = "BtnValiderPers";
            this.BtnValiderPers.Size = new System.Drawing.Size(130, 34);
            this.BtnValiderPers.TabIndex = 13;
            this.BtnValiderPers.Text = "Valider";
            this.BtnValiderPers.UseVisualStyleBackColor = true;
            this.BtnValiderPers.Click += new System.EventHandler(this.BtnValiderPers_Click);
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(362, 75);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(38, 20);
            this.LblTel.TabIndex = 9;
            this.LblTel.Text = "Tél :";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(355, 37);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(45, 20);
            this.LblMail.TabIndex = 8;
            this.LblMail.Text = "Mail :";
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(6, 113);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(69, 20);
            this.LblService.TabIndex = 7;
            this.LblService.Text = "Service :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(3, 75);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(72, 20);
            this.LblPrenom.TabIndex = 6;
            this.LblPrenom.Text = "Prénom :";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(6, 40);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(50, 20);
            this.LblNom.TabIndex = 5;
            this.LblNom.Text = "Nom :";
            // 
            // CboService
            // 
            this.CboService.FormattingEnabled = true;
            this.CboService.Location = new System.Drawing.Point(85, 110);
            this.CboService.Name = "CboService";
            this.CboService.Size = new System.Drawing.Size(246, 28);
            this.CboService.TabIndex = 4;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(406, 34);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(357, 26);
            this.TxtMail.TabIndex = 3;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(406, 72);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(246, 26);
            this.TxtTel.TabIndex = 2;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(84, 72);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(246, 26);
            this.TxtPrenom.TabIndex = 1;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(85, 34);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(246, 26);
            this.TxtNom.TabIndex = 0;
            // 
            // BtnSupprimerPerso
            // 
            this.BtnSupprimerPerso.Location = new System.Drawing.Point(158, 400);
            this.BtnSupprimerPerso.Name = "BtnSupprimerPerso";
            this.BtnSupprimerPerso.Size = new System.Drawing.Size(130, 34);
            this.BtnSupprimerPerso.TabIndex = 12;
            this.BtnSupprimerPerso.Text = "Supprimer";
            this.BtnSupprimerPerso.UseVisualStyleBackColor = true;
            this.BtnSupprimerPerso.Click += new System.EventHandler(this.BtnSupprimerPerso_Click);
            // 
            // BtnModifierPerso
            // 
            this.BtnModifierPerso.Location = new System.Drawing.Point(12, 401);
            this.BtnModifierPerso.Name = "BtnModifierPerso";
            this.BtnModifierPerso.Size = new System.Drawing.Size(130, 34);
            this.BtnModifierPerso.TabIndex = 11;
            this.BtnModifierPerso.Text = "Modifier";
            this.BtnModifierPerso.UseVisualStyleBackColor = true;
            this.BtnModifierPerso.Click += new System.EventHandler(this.BtnModifierPerso_Click);
            // 
            // BtnAjouterPersonnel
            // 
            this.BtnAjouterPersonnel.Location = new System.Drawing.Point(303, 400);
            this.BtnAjouterPersonnel.Name = "BtnAjouterPersonnel";
            this.BtnAjouterPersonnel.Size = new System.Drawing.Size(130, 34);
            this.BtnAjouterPersonnel.TabIndex = 10;
            this.BtnAjouterPersonnel.Text = "Ajouter";
            this.BtnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.BtnAjouterPersonnel.Click += new System.EventHandler(this.BtnAjouterPersonnel_Click);
            // 
            // GrpAbsence
            // 
            this.GrpAbsence.BackColor = System.Drawing.SystemColors.Control;
            this.GrpAbsence.Controls.Add(this.BtnAnnulerAbsence);
            this.GrpAbsence.Controls.Add(this.BtnValiderAbsence);
            this.GrpAbsence.Controls.Add(this.DtpFin);
            this.GrpAbsence.Controls.Add(this.DtpDebut);
            this.GrpAbsence.Controls.Add(this.CboNom);
            this.GrpAbsence.Controls.Add(this.LblDebut);
            this.GrpAbsence.Controls.Add(this.LblMotif);
            this.GrpAbsence.Controls.Add(this.LblFin);
            this.GrpAbsence.Controls.Add(this.LblNom2);
            this.GrpAbsence.Controls.Add(this.CboMotif);
            this.GrpAbsence.Location = new System.Drawing.Point(0, 642);
            this.GrpAbsence.Name = "GrpAbsence";
            this.GrpAbsence.Size = new System.Drawing.Size(892, 162);
            this.GrpAbsence.TabIndex = 13;
            this.GrpAbsence.TabStop = false;
            this.GrpAbsence.Text = "Gestion des absences";
            // 
            // BtnAnnulerAbsence
            // 
            this.BtnAnnulerAbsence.Location = new System.Drawing.Point(725, 110);
            this.BtnAnnulerAbsence.Name = "BtnAnnulerAbsence";
            this.BtnAnnulerAbsence.Size = new System.Drawing.Size(130, 34);
            this.BtnAnnulerAbsence.TabIndex = 15;
            this.BtnAnnulerAbsence.Text = "Annuler";
            this.BtnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnValiderAbsence
            // 
            this.BtnValiderAbsence.Location = new System.Drawing.Point(569, 110);
            this.BtnValiderAbsence.Name = "BtnValiderAbsence";
            this.BtnValiderAbsence.Size = new System.Drawing.Size(130, 34);
            this.BtnValiderAbsence.TabIndex = 15;
            this.BtnValiderAbsence.Text = "Valider";
            this.BtnValiderAbsence.UseVisualStyleBackColor = true;
            // 
            // DtpFin
            // 
            this.DtpFin.Location = new System.Drawing.Point(406, 67);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(200, 26);
            this.DtpFin.TabIndex = 15;
            // 
            // DtpDebut
            // 
            this.DtpDebut.Location = new System.Drawing.Point(406, 34);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(200, 26);
            this.DtpDebut.TabIndex = 14;
            // 
            // CboNom
            // 
            this.CboNom.FormattingEnabled = true;
            this.CboNom.Location = new System.Drawing.Point(84, 34);
            this.CboNom.Name = "CboNom";
            this.CboNom.Size = new System.Drawing.Size(246, 28);
            this.CboNom.TabIndex = 13;
            // 
            // LblDebut
            // 
            this.LblDebut.AutoSize = true;
            this.LblDebut.Location = new System.Drawing.Point(336, 37);
            this.LblDebut.Name = "LblDebut";
            this.LblDebut.Size = new System.Drawing.Size(61, 20);
            this.LblDebut.TabIndex = 8;
            this.LblDebut.Text = "Début :";
            // 
            // LblMotif
            // 
            this.LblMotif.AutoSize = true;
            this.LblMotif.Location = new System.Drawing.Point(6, 72);
            this.LblMotif.Name = "LblMotif";
            this.LblMotif.Size = new System.Drawing.Size(52, 20);
            this.LblMotif.TabIndex = 7;
            this.LblMotif.Text = "Motif :";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Location = new System.Drawing.Point(355, 69);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(39, 20);
            this.LblFin.TabIndex = 6;
            this.LblFin.Text = "Fin :";
            // 
            // LblNom2
            // 
            this.LblNom2.AutoSize = true;
            this.LblNom2.Location = new System.Drawing.Point(6, 40);
            this.LblNom2.Name = "LblNom2";
            this.LblNom2.Size = new System.Drawing.Size(50, 20);
            this.LblNom2.TabIndex = 5;
            this.LblNom2.Text = "Nom :";
            // 
            // CboMotif
            // 
            this.CboMotif.FormattingEnabled = true;
            this.CboMotif.Location = new System.Drawing.Point(85, 69);
            this.CboMotif.Name = "CboMotif";
            this.CboMotif.Size = new System.Drawing.Size(246, 28);
            this.CboMotif.TabIndex = 4;
            // 
            // BtnAbsence
            // 
            this.BtnAbsence.Location = new System.Drawing.Point(450, 400);
            this.BtnAbsence.Name = "BtnAbsence";
            this.BtnAbsence.Size = new System.Drawing.Size(197, 34);
            this.BtnAbsence.TabIndex = 16;
            this.BtnAbsence.Text = "Afficher les absences";
            this.BtnAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimerAbsence
            // 
            this.BtnSupprimerAbsence.Location = new System.Drawing.Point(158, 401);
            this.BtnSupprimerAbsence.Name = "BtnSupprimerAbsence";
            this.BtnSupprimerAbsence.Size = new System.Drawing.Size(130, 34);
            this.BtnSupprimerAbsence.TabIndex = 12;
            this.BtnSupprimerAbsence.Text = "Supprimer";
            this.BtnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnModifierAbsence
            // 
            this.BtnModifierAbsence.Location = new System.Drawing.Point(12, 400);
            this.BtnModifierAbsence.Name = "BtnModifierAbsence";
            this.BtnModifierAbsence.Size = new System.Drawing.Size(130, 34);
            this.BtnModifierAbsence.TabIndex = 11;
            this.BtnModifierAbsence.Text = "Modifier";
            this.BtnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnAjouterAbsence
            // 
            this.BtnAjouterAbsence.Location = new System.Drawing.Point(303, 401);
            this.BtnAjouterAbsence.Name = "BtnAjouterAbsence";
            this.BtnAjouterAbsence.Size = new System.Drawing.Size(130, 34);
            this.BtnAjouterAbsence.TabIndex = 10;
            this.BtnAjouterAbsence.Text = "Ajouter";
            this.BtnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // GrpListe
            // 
            this.GrpListe.BackColor = System.Drawing.SystemColors.Control;
            this.GrpListe.Controls.Add(this.BtnRetourListe);
            this.GrpListe.Controls.Add(this.BtnAbsence);
            this.GrpListe.Controls.Add(this.BtnAjouterPersonnel);
            this.GrpListe.Controls.Add(this.BtnModifierPerso);
            this.GrpListe.Controls.Add(this.BtnSupprimerPerso);
            this.GrpListe.Controls.Add(this.BtnAjouterAbsence);
            this.GrpListe.Controls.Add(this.BtnModifierAbsence);
            this.GrpListe.Controls.Add(this.BtnSupprimerAbsence);
            this.GrpListe.Location = new System.Drawing.Point(0, 12);
            this.GrpListe.Name = "GrpListe";
            this.GrpListe.Size = new System.Drawing.Size(892, 446);
            this.GrpListe.TabIndex = 14;
            this.GrpListe.TabStop = false;
            this.GrpListe.Text = "Liste du personnel";
            // 
            // BtnRetourListe
            // 
            this.BtnRetourListe.Location = new System.Drawing.Point(450, 400);
            this.BtnRetourListe.Name = "BtnRetourListe";
            this.BtnRetourListe.Size = new System.Drawing.Size(197, 34);
            this.BtnRetourListe.TabIndex = 17;
            this.BtnRetourListe.Text = "Retour à la liste";
            this.BtnRetourListe.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 803);
            this.Controls.Add(this.GrpAbsence);
            this.Controls.Add(this.GrpAjoutPers);
            this.Controls.Add(this.DgvListePersonnel);
            this.Controls.Add(this.GrpListe);
            this.Name = "FrmGestionPers";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).EndInit();
            this.GrpAjoutPers.ResumeLayout(false);
            this.GrpAjoutPers.PerformLayout();
            this.GrpAbsence.ResumeLayout(false);
            this.GrpAbsence.PerformLayout();
            this.GrpListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListePersonnel;
        private System.Windows.Forms.GroupBox GrpAjoutPers;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.ComboBox CboService;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Button BtnSupprimerPerso;
        private System.Windows.Forms.Button BtnModifierPerso;
        private System.Windows.Forms.Button BtnAjouterPersonnel;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.GroupBox GrpAbsence;
        private System.Windows.Forms.ComboBox CboNom;
        private System.Windows.Forms.Button BtnSupprimerAbsence;
        private System.Windows.Forms.Button BtnModifierAbsence;
        private System.Windows.Forms.Button BtnAjouterAbsence;
        private System.Windows.Forms.Label LblDebut;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblNom2;
        private System.Windows.Forms.ComboBox CboMotif;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpDebut;
        private System.Windows.Forms.Button BtnAnnulerPers;
        private System.Windows.Forms.Button BtnValiderPers;
        private System.Windows.Forms.Button BtnAnnulerAbsence;
        private System.Windows.Forms.Button BtnValiderAbsence;
        private System.Windows.Forms.Button BtnAbsence;
        private System.Windows.Forms.GroupBox GrpListe;
        private System.Windows.Forms.Button BtnRetourListe;
    }
}