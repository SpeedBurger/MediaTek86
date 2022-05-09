using MediaTek86.controleur;
using System;
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

        public FrmGestionPers(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
