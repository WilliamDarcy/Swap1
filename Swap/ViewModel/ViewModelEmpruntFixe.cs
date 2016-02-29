using System;
using Swap.Helpers;

namespace Swap.ViewModel
{
    public class ViewModelEmpruntFixe : EmpruntFixeVm
    {
        public RelayCommand CommandButtonOk { get; set; }


        public ViewModelEmpruntFixe()
        {
            CommandButtonOk = new RelayCommand(FermerDialog, ExecuteButton);

        }

        private bool ExecuteButton(object obj)
        {
            return true;

        }

        private void FermerDialog(object obj)
        {
            OnClose();
        }

        public EmpruntConstant ObtenirEmpruntConstant()
        {
            return new EmpruntConstant(Montant, Duree, DateDepart, Taux);
        }
    }
}