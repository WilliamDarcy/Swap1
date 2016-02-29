using System.Collections.Generic;
using Swap.Helpers;

namespace Swap.ViewModel
{
    public class SwapVm : ObservableObject
    {
        private decimal _tauxVariable;
        private decimal _echeanceFixe;
        private decimal _echeanceVariable;
        private decimal _differenceFixeVariable;
        private decimal _differenceVariableFixe;

        public decimal TauxVariable
        {
            get
            {
                return _tauxVariable;
            }

            set
            {
                _tauxVariable = value;
                OnPropertyChanged("TauxVariable");
            }
        }

        public decimal EcheanceFixe
        {
            get
            {
                return _echeanceFixe;
            }

            set
            {
                _echeanceFixe = value;
                OnPropertyChanged("EcheanceFixe");
            }
        }

        public decimal EcheanceVariable
        {
            get
            {
                return _echeanceVariable;
            }

            set
            {
                _echeanceVariable = value;
                OnPropertyChanged("EcheanceVariable");
            }
        }

        public decimal DifferenceFixeVariable
        {
            get
            {
                return _differenceFixeVariable;
            }

            set
            {
                _differenceFixeVariable = value;
                OnPropertyChanged("DifferenceFixeVariable");
            }
        }

        public decimal DifferenceVariableFixe
        {
            get
            {
                return _differenceVariableFixe;
            }

            set
            {
                _differenceVariableFixe = value;
                OnPropertyChanged("DifferenceVariableFixe");
            }
        }
    }
}