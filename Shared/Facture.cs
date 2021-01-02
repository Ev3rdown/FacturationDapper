using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturation.Shared
{
    public class Facture
    {
        [Required(ErrorMessage = "Numéro de facture unique requis")]
        [RegularExpression("f.{1,10}")]
        public string NumeroFacture { get; }
        [Required(ErrorMessage = "Nom du client (personne ou entreprise) requis")]
        [RegularExpression("f.{1,10}")]
        public string NomClient { get; }
        [Required(ErrorMessage = "La facture requiert une date d'émission")]
        public DateTime DateEmission { get; }
        [Required(ErrorMessage = "La facture requiert une date limite de paiement")]
        public DateTime DateAttenduReglement { get; }
        [Required(ErrorMessage = "Un montant dû est requis")]
        public double MontantDu { get; }
        public double MontantRegle { get; }
        public Facture(string numeroFacture, string nomClient,DateTime dateEmission, DateTime dateAttenduReglement, double montantDu, double montantRegle = 0)
        {
            NumeroFacture = numeroFacture;
            NomClient = nomClient;
            DateEmission = dateEmission;
            DateAttenduReglement = dateAttenduReglement;
            MontantDu = montantDu;
            MontantRegle = montantRegle;
        }
        public bool estPaye => MontantRegle >= MontantDu;
        public bool enRetard => DateAttenduReglement < DateTime.Now;
    }
}
