using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Swap;

namespace UnitTestProject1
{
    public class SwapEmprunt
    {
        public IEmpruntConstant EmpruntConstant { get; set; }
        public IEmpruntVariable EmpruntVariable { get; set; }

        public SwapEmprunt(IEmpruntConstant ec, IEmpruntVariable ev)
        {
            EmpruntConstant = ec;
            EmpruntVariable = ev;
        }
        /// <summary>
        /// Calcul de la liste des différences entre un taux constant et un taux variable
        /// </summary>
        /// <returns>la liste des différences</returns>
        public List<decimal> DifferenceEmpruntConstant()
        {
            var echeanceEmpruntConstant = EmpruntConstant.CalculEcheance();
        
            return EmpruntVariable.CalculTauxVariable().Select(echeanceEmpruntVariable => echeanceEmpruntConstant - echeanceEmpruntVariable).ToList();
        }
        /// <summary>
        /// Calcul de la liste des différences entre un taux variable et un taux constant.
        /// </summary>
        /// <returns>la liste des différences</returns>
        public List<decimal> DifferenceEmpruntVariable()
        {
            var echeanceEmpruntConstant = EmpruntConstant.CalculEcheance();

            return EmpruntVariable.CalculTauxVariable().Select(echeanceEmpruntVariable => echeanceEmpruntVariable - echeanceEmpruntConstant).ToList();

        }
    }
}