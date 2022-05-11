using System;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier concernant les absences.
    /// </summary>
    public class Absence
    {
        private readonly int idpersonnel;
        private readonly DateTime datedebut;
        private readonly DateTime datefin;
        private readonly int idmotif;
        private readonly string libelle;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="libelle"></param>
        public Absence(int idpersonnel, int idmotif, string libelle, DateTime datedebut, DateTime datefin)
        {
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.libelle = libelle;
        }
        /// <summary>
        /// Getter sur idservice
        /// </summary>
        public int IdPersonnel { get => idpersonnel; }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        public int IdMotif { get => idmotif; }
        /// <summary>
        /// Getter sur libelle
        /// </summary>
        public string Libelle { get => libelle; }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        public DateTime DateDebut { get => datedebut; }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        public DateTime DateFin { get => datefin; }

    }
}
