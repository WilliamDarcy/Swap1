using System;
using System.Collections.Generic;
using System.Linq;
using Swap.Domain;

namespace Swap
{
    public class TauxEmpruntVariable
    {
        public decimal Taux { get; set; }
    }


    public class EmpruntVariable : Emprunt, IEmpruntVariable
    {

        public  List<TauxEmpruntVariable> ListeTaux { get; set; }
    

        public EmpruntVariable(decimal montant, int duree, DateTime dateDepart, List<TauxEmpruntVariable> listeTaux) : base(montant, duree, dateDepart)
        {
          
            this.ListeTaux = listeTaux;
        }

        public List<decimal> CalculTauxVariable()
        {
            List<Decimal> listeTaux = ListeTaux.Select(x => Montant* x.Taux).ToList();
            return listeTaux;
        }
    }
}