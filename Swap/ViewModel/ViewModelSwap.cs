using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Swap.ViewModel
{
    public class ViewModelSwap 
    {
        public EmpruntConstant Ec { get; set; }
        public EmpruntVariable Ev { get; set; }
        public ObservableCollection<SwapVm> ListeSwap;

        public ViewModelSwap(EmpruntConstant ec, EmpruntVariable ev)
        {
            Ec = ec;
            Ev = ev;
            ListeSwap = new ObservableCollection<SwapVm>();
            CalculSwap();
        }

        public void CalculSwap()
        {
            var listeEcheanceVariable = Ev.CalculTauxVariable();
            var echeanceFixe = Ec.CalculEcheance();
            for (int i = 0; i < Ev.ListeTaux.Count; i++)
            {
                ListeSwap.Add(new SwapVm() {EcheanceFixe = echeanceFixe, TauxVariable = Ev.ListeTaux[i].Taux, EcheanceVariable = listeEcheanceVariable[i]});
            }
        }


    }
}