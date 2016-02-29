using System;
using System.ComponentModel;
using Swap.Helpers;

namespace Swap.ViewModel
{
    public class EmpruntFixeVm : EmpruntVm, IDataErrorInfo
    {
       
        private decimal _taux;
        public decimal Echeance { get; set; }

        
        public EmpruntFixeVm()
        {
            Taux = 0;
        }



        public decimal Taux
        {
            get
            {
                return _taux;
            }

            set
            {
                _taux = value;
                OnPropertyChanged("Taux");
            }
        }

        public string this[string columnName]
        {
            get
            {
                decimal n;
                switch (columnName)
                {
                    case "Montantg":
                        if (this.Montant < 0 )
                            return "The age must be between 10 and 100";
                        break;
                }

                return string.Empty;
            }

        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}