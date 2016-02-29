using System;
using System.Collections.Generic;
using System.Linq;
using Swap.Helpers;

namespace Swap.ViewModel
{
    public class ViewModelEmpruntVariable : EmpruntVariableVm
    {
        public RelayCommand CommandButtonOk { get; set; }
        public RelayCommand CommandButtonTaux { get; set; }


        public ViewModelEmpruntVariable()
        {
            CommandButtonOk = new RelayCommand(FermerDialog);
            CommandButtonTaux = new RelayCommand(AffichageTaux, AffichageBouton);
        }

        private bool AffichageBouton(object obj)
        {
            return true;
        }

        private void AffichageTaux(object obj)
        {
            for (int i = 1; i <= Duree; i++)
            {
                TauxEmprunt.Add(new TauxEmpruntVariable() {Taux = 0M});
            }
        }

        private void FermerDialog(object obj)
        {     
            OnClose();
        }

        public EmpruntVariable ObtenirEmpruntVariable()
        {
            return new EmpruntVariable(Montant, Duree, DateDepart, new List<TauxEmpruntVariable>(TauxEmprunt));
        }
    }
}