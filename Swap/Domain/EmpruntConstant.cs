using System;
using System.Windows.Media.Animation;
using Swap.Domain;

namespace Swap
{
    public class EmpruntConstant : Emprunt, IEmpruntConstant
    {
        protected readonly decimal Taux;
        public EmpruntConstant(decimal montant, int duree, DateTime dateDepart, decimal taux): base(montant, duree, dateDepart)
        {
            Taux = taux;
        }

        public decimal CalculEcheance()
        {
            return Taux* Montant;
        }
    }
}