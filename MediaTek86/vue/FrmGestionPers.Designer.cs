
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
            this.GrpAbsence = new System.Windows.Forms.GroupBox();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.LblDebut = new System.Windows.Forms.Label();
            this.LblMotif = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.CboMotif = new System.Windows.Forms.ComboBox();
            this.GrpListe = new System.Windows.Forms.GroupBox();
            this.BtnAfficher = new System.Windows.Forms.PictureBox();
            this.BtnRetour = new System.Windows.Forms.PictureBox();
            this.BtnModifier = new System.Windows.Forms.PictureBox();
            this.BtnSupprimer = new System.Windows.Forms.PictureBox();
            this.BtnAjouter = new System.Windows.Forms.PictureBox();
            this.BtnValiderPers = new System.Windows.Forms.PictureBox();
            this.BtnAnnulerPers = new System.Windows.Forms.PictureBox();
            this.BtnAnnulerAbsence = new System.Windows.Forms.PictureBox();
            this.BtnValiderAbsence = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).BeginInit();
            this.GrpAjoutPers.SuspendLayout();
            this.GrpAbsence.SuspendLayout();
            this.GrpListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAfficher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnValiderPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnnulerPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnnulerAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnValiderAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListePersonnel
            // 
            this.DgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListePersonnel.Location = new System.Drawing.Point(7, 14);
            this.DgvListePersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvListePersonnel.Name = "DgvListePersonnel";
            this.DgvListePersonnel.RowHeadersWidth = 62;
            this.DgvListePersonnel.RowTemplate.Height = 28;
            this.DgvListePersonnel.Size = new System.Drawing.Size(583, 241);
            this.DgvListePersonnel.TabIndex = 0;
            // 
            // GrpAjoutPers
            // 
            this.GrpAjoutPers.BackColor = System.Drawing.Color.White;
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
            this.GrpAjoutPers.Location = new System.Drawing.Point(9, 305);
            this.GrpAjoutPers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpAjoutPers.Name = "GrpAjoutPers";
            this.GrpAjoutPers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpAjoutPers.Size = new System.Drawing.Size(602, 105);
            this.GrpAjoutPers.TabIndex = 2;
            this.GrpAjoutPers.TabStop = false;
            this.GrpAjoutPers.Text = "Ajout d\'un personnel";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(241, 49);
            this.LblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(28, 13);
            this.LblTel.TabIndex = 9;
            this.LblTel.Text = "Tél :";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(237, 24);
            this.LblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(32, 13);
            this.LblMail.TabIndex = 8;
            this.LblMail.Text = "Mail :";
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(4, 73);
            this.LblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(49, 13);
            this.LblService.TabIndex = 7;
            this.LblService.Text = "Service :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(2, 49);
            this.LblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(49, 13);
            this.LblPrenom.TabIndex = 6;
            this.LblPrenom.Text = "Prénom :";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(4, 26);
            this.LblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(35, 13);
            this.LblNom.TabIndex = 5;
            this.LblNom.Text = "Nom :";
            // 
            // CboService
            // 
            this.CboService.FormattingEnabled = true;
            this.CboService.Location = new System.Drawing.Point(57, 71);
            this.CboService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboService.Name = "CboService";
            this.CboService.Size = new System.Drawing.Size(165, 21);
            this.CboService.TabIndex = 4;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(271, 22);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(239, 20);
            this.TxtMail.TabIndex = 3;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(271, 47);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(165, 20);
            this.TxtTel.TabIndex = 2;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(56, 47);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(165, 20);
            this.TxtPrenom.TabIndex = 1;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(57, 22);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(165, 20);
            this.TxtNom.TabIndex = 0;
            // 
            // GrpAbsence
            // 
            this.GrpAbsence.BackColor = System.Drawing.Color.White;
            this.GrpAbsence.Controls.Add(this.BtnValiderAbsence);
            this.GrpAbsence.Controls.Add(this.BtnAnnulerAbsence);
            this.GrpAbsence.Controls.Add(this.DtpFin);
            this.GrpAbsence.Controls.Add(this.DtpDebut);
            this.GrpAbsence.Controls.Add(this.LblDebut);
            this.GrpAbsence.Controls.Add(this.LblMotif);
            this.GrpAbsence.Controls.Add(this.LblFin);
            this.GrpAbsence.Controls.Add(this.CboMotif);
            this.GrpAbsence.Location = new System.Drawing.Point(9, 417);
            this.GrpAbsence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpAbsence.Name = "GrpAbsence";
            this.GrpAbsence.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpAbsence.Size = new System.Drawing.Size(602, 81);
            this.GrpAbsence.TabIndex = 13;
            this.GrpAbsence.TabStop = false;
            this.GrpAbsence.Text = "Gestion des absences";
            // 
            // DtpFin
            // 
            this.DtpFin.CustomFormat = "";
            this.DtpFin.Location = new System.Drawing.Point(445, 23);
            this.DtpFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFin.MaxDate = new System.DateTime(9922, 5, 10, 0, 0, 0, 0);
            this.DtpFin.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(135, 20);
            this.DtpFin.TabIndex = 15;
            this.DtpFin.Value = new System.DateTime(2022, 5, 10, 15, 58, 6, 0);
            // 
            // DtpDebut
            // 
            this.DtpDebut.Location = new System.Drawing.Point(271, 23);
            this.DtpDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(135, 20);
            this.DtpDebut.TabIndex = 14;
            this.DtpDebut.Value = new System.DateTime(2022, 5, 10, 15, 58, 15, 0);
            // 
            // LblDebut
            // 
            this.LblDebut.AutoSize = true;
            this.LblDebut.Location = new System.Drawing.Point(226, 24);
            this.LblDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDebut.Name = "LblDebut";
            this.LblDebut.Size = new System.Drawing.Size(42, 13);
            this.LblDebut.TabIndex = 8;
            this.LblDebut.Text = "Début :";
            // 
            // LblMotif
            // 
            this.LblMotif.AutoSize = true;
            this.LblMotif.Location = new System.Drawing.Point(8, 25);
            this.LblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMotif.Name = "LblMotif";
            this.LblMotif.Size = new System.Drawing.Size(36, 13);
            this.LblMotif.TabIndex = 7;
            this.LblMotif.Text = "Motif :";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Location = new System.Drawing.Point(415, 24);
            this.LblFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(27, 13);
            this.LblFin.TabIndex = 6;
            this.LblFin.Text = "Fin :";
            // 
            // CboMotif
            // 
            this.CboMotif.FormattingEnabled = true;
            this.CboMotif.Location = new System.Drawing.Point(56, 22);
            this.CboMotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboMotif.Name = "CboMotif";
            this.CboMotif.Size = new System.Drawing.Size(165, 21);
            this.CboMotif.TabIndex = 4;
            // 
            // GrpListe
            // 
            this.GrpListe.BackColor = System.Drawing.Color.White;
            this.GrpListe.Controls.Add(this.BtnModifier);
            this.GrpListe.Controls.Add(this.BtnSupprimer);
            this.GrpListe.Controls.Add(this.BtnAjouter);
            this.GrpListe.Controls.Add(this.BtnRetour);
            this.GrpListe.Controls.Add(this.BtnAfficher);
            this.GrpListe.Controls.Add(this.DgvListePersonnel);
            this.GrpListe.Location = new System.Drawing.Point(9, 8);
            this.GrpListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpListe.Name = "GrpListe";
            this.GrpListe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpListe.Size = new System.Drawing.Size(602, 290);
            this.GrpListe.TabIndex = 14;
            this.GrpListe.TabStop = false;
            this.GrpListe.Text = "Liste";
            // 
            // BtnAfficher
            // 
            this.BtnAfficher.Location = new System.Drawing.Point(320, 262);
            this.BtnAfficher.Name = "BtnAfficher";
            this.BtnAfficher.Size = new System.Drawing.Size(150, 20);
            this.BtnAfficher.TabIndex = 15;
            this.BtnAfficher.TabStop = false;
            this.BtnAfficher.Click += new System.EventHandler(this.BtnAfficher_Click);
            this.BtnAfficher.MouseEnter += new System.EventHandler(this.BtnAfficher_MouseEnter);
            this.BtnAfficher.MouseLeave += new System.EventHandler(this.BtnAfficher_MouseLeave);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Location = new System.Drawing.Point(320, 262);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(150, 20);
            this.BtnRetour.TabIndex = 15;
            this.BtnRetour.TabStop = false;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            this.BtnRetour.MouseEnter += new System.EventHandler(this.BtnRetour_MouseEnter);
            this.BtnRetour.MouseLeave += new System.EventHandler(this.BtnRetour_MouseLeave);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(5, 262);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(85, 20);
            this.BtnModifier.TabIndex = 17;
            this.BtnModifier.TabStop = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            this.BtnModifier.MouseEnter += new System.EventHandler(this.BtnModifier_MouseEnter);
            this.BtnModifier.MouseLeave += new System.EventHandler(this.BtnModifier_MouseLeave);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(108, 262);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(85, 20);
            this.BtnSupprimer.TabIndex = 18;
            this.BtnSupprimer.TabStop = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            this.BtnSupprimer.MouseEnter += new System.EventHandler(this.BtnSupprimer_MouseEnter);
            this.BtnSupprimer.MouseLeave += new System.EventHandler(this.BtnSupprimer_MouseLeave);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(213, 262);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(85, 20);
            this.BtnAjouter.TabIndex = 19;
            this.BtnAjouter.TabStop = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            this.BtnAjouter.MouseEnter += new System.EventHandler(this.BtnAjouter_MouseEnter);
            this.BtnAjouter.MouseLeave += new System.EventHandler(this.BtnAjouter_MouseLeave);
            // 
            // BtnValiderPers
            // 
            this.BtnValiderPers.Location = new System.Drawing.Point(381, 73);
            this.BtnValiderPers.Name = "BtnValiderPers";
            this.BtnValiderPers.Size = new System.Drawing.Size(85, 20);
            this.BtnValiderPers.TabIndex = 15;
            this.BtnValiderPers.TabStop = false;
            this.BtnValiderPers.Click += new System.EventHandler(this.BtnValiderPers_Click);
            this.BtnValiderPers.MouseEnter += new System.EventHandler(this.BtnValiderPers_MouseEnter);
            this.BtnValiderPers.MouseLeave += new System.EventHandler(this.BtnValiderPers_MouseLeave);
            // 
            // BtnAnnulerPers
            // 
            this.BtnAnnulerPers.Location = new System.Drawing.Point(491, 73);
            this.BtnAnnulerPers.Name = "BtnAnnulerPers";
            this.BtnAnnulerPers.Size = new System.Drawing.Size(85, 20);
            this.BtnAnnulerPers.TabIndex = 16;
            this.BtnAnnulerPers.TabStop = false;
            this.BtnAnnulerPers.Click += new System.EventHandler(this.BtnAnnulerPers_Click);
            this.BtnAnnulerPers.MouseEnter += new System.EventHandler(this.BtnAnnulerPers_MouseEnter);
            this.BtnAnnulerPers.MouseLeave += new System.EventHandler(this.BtnAnnulerPers_MouseLeave);
            // 
            // BtnAnnulerAbsence
            // 
            this.BtnAnnulerAbsence.Location = new System.Drawing.Point(491, 53);
            this.BtnAnnulerAbsence.Name = "BtnAnnulerAbsence";
            this.BtnAnnulerAbsence.Size = new System.Drawing.Size(85, 20);
            this.BtnAnnulerAbsence.TabIndex = 17;
            this.BtnAnnulerAbsence.TabStop = false;
            this.BtnAnnulerAbsence.Click += new System.EventHandler(this.BtnAnnulerAbsence_Click);
            this.BtnAnnulerAbsence.MouseEnter += new System.EventHandler(this.BtnAnnulerAbsence_MouseEnter);
            this.BtnAnnulerAbsence.MouseLeave += new System.EventHandler(this.BtnAnnulerAbsence_MouseLeave);
            // 
            // BtnValiderAbsence
            // 
            this.BtnValiderAbsence.Location = new System.Drawing.Point(381, 53);
            this.BtnValiderAbsence.Name = "BtnValiderAbsence";
            this.BtnValiderAbsence.Size = new System.Drawing.Size(85, 20);
            this.BtnValiderAbsence.TabIndex = 18;
            this.BtnValiderAbsence.TabStop = false;
            this.BtnValiderAbsence.Click += new System.EventHandler(this.BtnValiderAbsence_Click);
            this.BtnValiderAbsence.MouseEnter += new System.EventHandler(this.BtnValiderAbsence_MouseEnter);
            this.BtnValiderAbsence.MouseLeave += new System.EventHandler(this.BtnValiderAbsence_MouseLeave);
            // 
            // FrmGestionPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 507);
            this.Controls.Add(this.GrpAbsence);
            this.Controls.Add(this.GrpAjoutPers);
            this.Controls.Add(this.GrpListe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGestionPers";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePersonnel)).EndInit();
            this.GrpAjoutPers.ResumeLayout(false);
            this.GrpAjoutPers.PerformLayout();
            this.GrpAbsence.ResumeLayout(false);
            this.GrpAbsence.PerformLayout();
            this.GrpListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAfficher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnValiderPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnnulerPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnnulerAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnValiderAbsence)).EndInit();
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
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.GroupBox GrpAbsence;
        private System.Windows.Forms.Label LblDebut;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.ComboBox CboMotif;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpDebut;
        private System.Windows.Forms.GroupBox GrpListe;
        private System.Windows.Forms.PictureBox BtnAfficher;
        private System.Windows.Forms.PictureBox BtnRetour;
        private System.Windows.Forms.PictureBox BtnModifier;
        private System.Windows.Forms.PictureBox BtnSupprimer;
        private System.Windows.Forms.PictureBox BtnAjouter;
        private System.Windows.Forms.PictureBox BtnAnnulerPers;
        private System.Windows.Forms.PictureBox BtnValiderPers;
        private System.Windows.Forms.PictureBox BtnValiderAbsence;
        private System.Windows.Forms.PictureBox BtnAnnulerAbsence;
    }
}