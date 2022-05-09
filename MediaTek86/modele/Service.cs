using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// classe metier concernant les différents services.
    /// </summary>
    public class Service
    {
        private readonly int idservice;
        private readonly string nom;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
        /// <summary>
        /// Getter sur idservice
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        public string Nom { get => nom; }
    }
}
