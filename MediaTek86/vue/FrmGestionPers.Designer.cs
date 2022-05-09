
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
            this.LblDgv = new System.Windows.Forms.Label();
            this.GrpGestionPers = new System.Windows.Forms.GroupBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CboService = new System.Windows.Forms.ComboBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblService = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.GrpAbsence = new System.Windows.Forms.GroupBox();
            this.BtnSupprimer2 = new System.Windows.Forms.Button();
            this.BtnModifier2 = new System.Windows.Forms.Button();
            this.BtnAjouter2 = new System.Windows.Forms.Button();
            this.LblDebut = new System.Windows.Forms.Label();
            this.LblMotif = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblNom2 = new System.Windows.Forms.Label();
            this.CboMotif = new System.Windows.Forms.ComboBox();
            this.CboNom = new System.Windows.Forms.ComboBox();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.BtnAbsence = new System.Windows.Forms.Button();
            this.BtnValider1 = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValider2 = new System.Windows.Forms.Button();
            this.BtnAnnuler2 = new System.Windows.Forms.Button();
            this.BtnAfficherListe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).BeginInit();
            this.GrpGestionPers.SuspendLayout();
            this.GrpAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListePersonnel
            // 
            this.DgvListePersonnel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListePersonnel.Location = new System.Drawing.Point(12, 35);
            this.DgvListePersonnel.Name = "DgvListePersonnel";
            this.DgvListePersonnel.RowHeadersWidth = 62;
            this.DgvListePersonnel.RowTemplate.Height = 28;
            this.DgvListePersonnel.Size = new System.Drawing.Size(880, 433);
            this.DgvListePersonnel.TabIndex = 0;
            // 
            // LblDgv
            // 
            this.LblDgv.AutoSize = true;
            this.LblDgv.Location = new System.Drawing.Point(12, 9);
            this.LblDgv.Name = "LblDgv";
            this.LblDgv.Size = new System.Drawing.Size(139, 20);
            this.LblDgv.TabIndex = 1;
            this.LblDgv.Text = "Liste du personnel";
            // 
            // GrpGestionPers
            // 
            this.GrpGestionPers.BackColor = System.Drawing.SystemColors.Control;
            this.GrpGestionPers.Controls.Add(this.BtnAnnuler);
            this.GrpGestionPers.Controls.Add(this.BtnValider1);
            this.GrpGestionPers.Controls.Add(this.BtnSupprimer);
            this.GrpGestionPers.Controls.Add(this.BtnModifier);
            this.GrpGestionPers.Controls.Add(this.BtnAjouter);
            this.GrpGestionPers.Controls.Add(this.LblTel);
            this.GrpGestionPers.Controls.Add(this.LblMail);
            this.GrpGestionPers.Controls.Add(this.LblService);
            this.GrpGestionPers.Controls.Add(this.LblPrenom);
            this.GrpGestionPers.Controls.Add(this.LblNom);
            this.GrpGestionPers.Controls.Add(this.CboService);
            this.GrpGestionPers.Controls.Add(this.TxtMail);
            this.GrpGestionPers.Controls.Add(this.TxtTel);
            this.GrpGestionPers.Controls.Add(this.TxtPrenom);
            this.GrpGestionPers.Controls.Add(this.TxtNom);
            this.GrpGestionPers.Location = new System.Drawing.Point(12, 474);
            this.GrpGestionPers.Name = "GrpGestionPers";
            this.GrpGestionPers.Size = new System.Drawing.Size(880, 162);
            this.GrpGestionPers.TabIndex = 2;
            this.GrpGestionPers.TabStop = false;
            this.GrpGestionPers.Text = "Gestion du personnel";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(85, 34);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(246, 26);
            this.TxtNom.TabIndex = 0;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(84, 72);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(246, 26);
            this.TxtPrenom.TabIndex = 1;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(406, 72);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(246, 26);
            this.TxtTel.TabIndex = 2;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(406, 34);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(357, 26);
            this.TxtMail.TabIndex = 3;
            // 
            // CboService
            // 
            this.CboService.FormattingEnabled = true;
            this.CboService.Location = new System.Drawing.Point(85, 110);
            this.CboService.Name = "CboService";
            this.CboService.Size = new System.Drawing.Size(246, 28);
            this.CboService.TabIndex = 4;
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
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(3, 75);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(72, 20);
            this.LblPrenom.TabIndex = 6;
            this.LblPrenom.Text = "Prénom :";
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
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(355, 37);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(45, 20);
            this.LblMail.TabIndex = 8;
            this.LblMail.Text = "Mail :";
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
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(406, 110);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(130, 34);
            this.BtnAjouter.TabIndex = 10;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(569, 110);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(130, 34);
            this.BtnModifier.TabIndex = 11;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(725, 110);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(130, 34);
            this.BtnSupprimer.TabIndex = 12;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // GrpAbsence
            // 
            this.GrpAbsence.BackColor = System.Drawing.SystemColors.Control;
            this.GrpAbsence.Controls.Add(this.BtnAfficherListe);
            this.GrpAbsence.Controls.Add(this.BtnAnnuler2);
            this.GrpAbsence.Controls.Add(this.BtnValider2);
            this.GrpAbsence.Controls.Add(this.BtnAbsence);
            this.GrpAbsence.Controls.Add(this.DtpFin);
            this.GrpAbsence.Controls.Add(this.DtpDebut);
            this.GrpAbsence.Controls.Add(this.CboNom);
            this.GrpAbsence.Controls.Add(this.BtnSupprimer2);
            this.GrpAbsence.Controls.Add(this.BtnModifier2);
            this.GrpAbsence.Controls.Add(this.BtnAjouter2);
            this.GrpAbsence.Controls.Add(this.LblDebut);
            this.GrpAbsence.Controls.Add(this.LblMotif);
            this.GrpAbsence.Controls.Add(this.LblFin);
            this.GrpAbsence.Controls.Add(this.LblNom2);
            this.GrpAbsence.Controls.Add(this.CboMotif);
            this.GrpAbsence.Location = new System.Drawing.Point(12, 642);
            this.GrpAbsence.Name = "GrpAbsence";
            this.GrpAbsence.Size = new System.Drawing.Size(880, 162);
            this.GrpAbsence.TabIndex = 13;
            this.GrpAbsence.TabStop = false;
            this.GrpAbsence.Text = "Gestion des absences";
            // 
            // BtnSupprimer2
            // 
            this.BtnSupprimer2.Location = new System.Drawing.Point(725, 110);
            this.BtnSupprimer2.Name = "BtnSupprimer2";
            this.BtnSupprimer2.Size = new System.Drawing.Size(130, 34);
            this.BtnSupprimer2.TabIndex = 12;
            this.BtnSupprimer2.Text = "Supprimer";
            this.BtnSupprimer2.UseVisualStyleBackColor = true;
            // 
            // BtnModifier2
            // 
            this.BtnModifier2.Location = new System.Drawing.Point(569, 110);
            this.BtnModifier2.Name = "BtnModifier2";
            this.BtnModifier2.Size = new System.Drawing.Size(130, 34);
            this.BtnModifier2.TabIndex = 11;
            this.BtnModifier2.Text = "Modifier";
            this.BtnModifier2.UseVisualStyleBackColor = true;
            // 
            // BtnAjouter2
            // 
            this.BtnAjouter2.Location = new System.Drawing.Point(406, 110);
            this.BtnAjouter2.Name = "BtnAjouter2";
            this.BtnAjouter2.Size = new System.Drawing.Size(130, 34);
            this.BtnAjouter2.TabIndex = 10;
            this.BtnAjouter2.Text = "Ajouter";
            this.BtnAjouter2.UseVisualStyleBackColor = true;
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
            // CboNom
            // 
            this.CboNom.FormattingEnabled = true;
            this.CboNom.Location = new System.Drawing.Point(84, 34);
            this.CboNom.Name = "CboNom";
            this.CboNom.Size = new System.Drawing.Size(246, 28);
            this.CboNom.TabIndex = 13;
            // 
            // DtpDebut
            // 
            this.DtpDebut.Location = new System.Drawing.Point(406, 34);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(200, 26);
            this.DtpDebut.TabIndex = 14;
            // 
            // DtpFin
            // 
            this.DtpFin.Location = new System.Drawing.Point(406, 67);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(200, 26);
            this.DtpFin.TabIndex = 15;
            // 
            // BtnAbsence
            // 
            this.BtnAbsence.Location = new System.Drawing.Point(672, 37);
            this.BtnAbsence.Name = "BtnAbsence";
            this.BtnAbsence.Size = new System.Drawing.Size(130, 49);
            this.BtnAbsence.TabIndex = 16;
            this.BtnAbsence.Text = "Afficher les absences";
            this.BtnAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnValider1
            // 
            this.BtnValider1.Location = new System.Drawing.Point(725, 110);
            this.BtnValider1.Name = "BtnValider1";
            this.BtnValider1.Size = new System.Drawing.Size(130, 34);
            this.BtnValider1.TabIndex = 13;
            this.BtnValider1.Text = "Valider";
            this.BtnValider1.UseVisualStyleBackColor = true;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(569, 110);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(130, 34);
            this.BtnAnnuler.TabIndex = 14;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // BtnValider2
            // 
            this.BtnValider2.Location = new System.Drawing.Point(725, 110);
            this.BtnValider2.Name = "BtnValider2";
            this.BtnValider2.Size = new System.Drawing.Size(130, 34);
            this.BtnValider2.TabIndex = 15;
            this.BtnValider2.Text = "Valider";
            this.BtnValider2.UseVisualStyleBackColor = true;
            // 
            // BtnAnnuler2
            // 
            this.BtnAnnuler2.Location = new System.Drawing.Point(569, 110);
            this.BtnAnnuler2.Name = "BtnAnnuler2";
            this.BtnAnnuler2.Size = new System.Drawing.Size(130, 34);
            this.BtnAnnuler2.TabIndex = 15;
            this.BtnAnnuler2.Text = "Annuler";
            this.BtnAnnuler2.UseVisualStyleBackColor = true;
            // 
            // BtnAfficherListe
            // 
            this.BtnAfficherListe.Location = new System.Drawing.Point(672, 37);
            this.BtnAfficherListe.Name = "BtnAfficherListe";
            this.BtnAfficherListe.Size = new System.Drawing.Size(130, 49);
            this.BtnAfficherListe.TabIndex = 17;
            this.BtnAfficherListe.Text = "Retour liste du personnel";
            this.BtnAfficherListe.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 809);
            this.Controls.Add(this.GrpAbsence);
            this.Controls.Add(this.GrpGestionPers);
            this.Controls.Add(this.LblDgv);
            this.Controls.Add(this.DgvListePersonnel);
            this.Name = "FrmGestionPers";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).EndInit();
            this.GrpGestionPers.ResumeLayout(false);
            this.GrpGestionPers.PerformLayout();
            this.GrpAbsence.ResumeLayout(false);
            this.GrpAbsence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListePersonnel;
        private System.Windows.Forms.Label LblDgv;
        private System.Windows.Forms.GroupBox GrpGestionPers;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.ComboBox CboService;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.GroupBox GrpAbsence;
        private System.Windows.Forms.ComboBox CboNom;
        private System.Windows.Forms.Button BtnSupprimer2;
        private System.Windows.Forms.Button BtnModifier2;
        private System.Windows.Forms.Button BtnAjouter2;
        private System.Windows.Forms.Label LblDebut;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblNom2;
        private System.Windows.Forms.ComboBox CboMotif;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpDebut;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnValider1;
        private System.Windows.Forms.Button BtnAnnuler2;
        private System.Windows.Forms.Button BtnValider2;
        private System.Windows.Forms.Button BtnAbsence;
        private System.Windows.Forms.Button BtnAfficherListe;
    }
}