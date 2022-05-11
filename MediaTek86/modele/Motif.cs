namespace MediaTek86.modele
{
    /// <summary>
    /// Classe Metier concernant les motifs d'absences.
    /// </summary>
    public class Motif
    {
        private readonly int idmotif;
        private readonly string libelle;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
        /// <summary>
        /// Getter sur idmotif
        /// </summary>
        public int IdMotif { get => idmotif; }
        /// <summary>
        /// Getter sur libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
