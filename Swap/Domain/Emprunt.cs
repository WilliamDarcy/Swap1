using System;

namespace Swap.Domain
{
    public class Emprunt
    {
        protected readonly decimal Montant;
        protected readonly int Duree;
        protected readonly DateTime DateDepart;

        public Emprunt(decimal montant, int duree, DateTime dateDepart )
        {
            Montant = montant;
            Duree = duree;
            DateDepart = dateDepart;
        }


    }
}