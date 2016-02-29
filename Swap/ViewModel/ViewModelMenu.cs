using System;
using System.Collections.ObjectModel;
using Swap.Helpers;
using Swap.Views;

namespace Swap.ViewModel
{
    public class ViewModelMenu : ObservableObject
    {
        public ViewModelEmpruntFixe VmEmpruntFixe { get; set; }
        public ViewModelEmpruntVariable VmEmpruntVariable { get; set; }
        //private ViewModelSwap _vmViewModelSwap;
        public ObservableCollection<SwapVm> ListeSwap { get; set; }


        public RelayCommand CommandEmpruntFixe { get; set; }
        public RelayCommand CommandEmpruntVariable { get; set; }
        public RelayCommand CommandSwap { get; set; }

        //public ViewModelSwap VmViewModelSwap
        //{
        //    get
        //    {
        //        return _vmViewModelSwap;
        //    }

        //    set
        //    {
        //        _vmViewModelSwap = value;
        //        OnPropertyChanged("VmViewModelSwap");
        //    }
        //}

        private EmpruntConstant _ef;
        private EmpruntVariable _ev;
     

        public ViewModelMenu()
        {
            CommandEmpruntFixe = new RelayCommand(AfficherEmpruntFixe);
            CommandEmpruntVariable = new RelayCommand(AfficherEmpruntVariable);
            CommandSwap = new RelayCommand(AfficherSwap, SwapEstPossible);
            ListeSwap = new ObservableCollection<SwapVm>();

        }

        private bool SwapEstPossible(object obj)
        {
            return _ef != null && _ev != null;
        }

        private void AfficherSwap(object obj)
        {
            CalculSwap();
        }

        private void AfficherEmpruntVariable(object obj)
        {
            ViewModelEmpruntVariable vmv = new ViewModelEmpruntVariable();
      
            new EmpruntVariableDialog(vmv).ShowDialog();
            _ev = vmv.ObtenirEmpruntVariable();

        }

        public void AfficherEmpruntFixe(object obj)
        {
            ViewModelEmpruntFixe vme = new ViewModelEmpruntFixe();

            new EmpruntFixeDialog(vme).ShowDialog();
            _ef = vme.ObtenirEmpruntConstant();


        }

        public void CalculSwap()
        {
            
            var listeEcheanceVariable = _ev.CalculTauxVariable();
            var echeanceFixe = _ef.CalculEcheance();
            for (int i = 0; i < _ev.ListeTaux.Count; i++)
            {
                ListeSwap.Add(new SwapVm() { EcheanceFixe = echeanceFixe, TauxVariable = _ev.ListeTaux[i].Taux, EcheanceVariable = listeEcheanceVariable[i] });
            }
        }

    }
}