using System;
using System.Collections.ObjectModel;
using Swap.Helpers;

namespace Swap.ViewModel
{

    //public class TauxEmpruntVariable : ObservableObject
    //{
    //    private DateTime _dateEcheance;
    //    private decimal _taux;

    //    public DateTime DateEcheance
    //    {
    //        get
    //        {
    //            return _dateEcheance;
    //        }

    //        set
    //        {
    //            _dateEcheance = value;
    //            OnPropertyChanged("DateEcheance");
    //        }
    //    }

    //    public decimal Taux
    //    {
    //        get
    //        {
    //            return _taux;
    //        }

    //        set
    //        {
    //            _taux = value;
    //            OnPropertyChanged("Taux");
    //        }
    //    }
    //}

    public class EmpruntVariableVm : EmpruntVm
    {
        public ObservableCollection<TauxEmpruntVariable> TauxEmprunt { get; set; }

        public EmpruntVariableVm()
        {
            TauxEmprunt = new ObservableCollection<TauxEmpruntVariable>() {new TauxEmpruntVariable() {Taux = 0.045M}, new TauxEmpruntVariable() { Taux = 0.050M }, new TauxEmpruntVariable() { Taux = 0.055M }, new TauxEmpruntVariable() { Taux = 0.060M }, new TauxEmpruntVariable() { Taux = 0.065M } };
        }

    }
}