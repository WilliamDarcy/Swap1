using System;
using Swap.Helpers;

namespace Swap.ViewModel
{
    public class EmpruntVm :ObservableObject
    {
        private decimal _montant;
        private int _duree;
        private DateTime _dateDepart;



        public EmpruntVm()
        {
            Montant = 0;
            Duree = 0;
          
            DateDepart = DateTime.Now;
        }

        public EventHandler Close { get; set; }

        protected virtual void OnClose()
        {
            EventHandler handler = Close;
            handler?.Invoke(this, EventArgs.Empty);
        }

        public decimal Montant
        {
            get
            {
                return _montant;
            }

            set
            {
                _montant = value;
                OnPropertyChanged("Montant");
            }
        }

        public int Duree
        {
            get
            {
                return _duree;
            }

            set
            {
                _duree = value;
                OnPropertyChanged("Duree");
            }
        }

        public DateTime DateDepart
        {
            get
            {
                return _dateDepart;
            }

            set
            {
                _dateDepart = value;
                OnPropertyChanged("DateDepart");
            }
        }

       
    }
}