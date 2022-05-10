using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier concernant les personnels.
    /// </summary>
    public class Personnel
    {
        private readonly int idpersonnel;
        private readonly string nom;
        private readonly string prenom;
        private readonly string tel;
        private readonly string mail;
        private readonly int idservice;
        private readonly string service;

        /// <summary>
        /// Getter sur idpersonnel
        /// </summary>
        public int IdPersonnel { get => idpersonnel; }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Getter sur prénom
        /// </summary>
        public string Prenom { get => prenom; }
        /// <summary>
        /// Getter sur tel
        /// </summary>
        public string Tel { get => tel; }
        /// <summary>
        /// Getter sur mail
        /// </summary>
        public string Mail { get => mail; }
        /// <summary>
        /// Getter sur service
        /// </summary>
        public int IdService { get => idservice; }
        /// <summary>
        /// Getter sur service
        /// </summary>
        public string Service { get => service; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service">nom du service</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
            this.service = service; 
        }
    }
}
