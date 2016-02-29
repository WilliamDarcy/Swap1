using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swap;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_Calcul_Taux_fixe()
        {
            EmpruntConstant ec = new EmpruntConstant(10000, 5,new DateTime(2016,5,1), 0.05M );
            decimal result = ec.CalculEcheance();

            Assert.AreEqual(500, result);

        }

        [TestMethod]
        public void Test_Calcul_Taux_variable()
        {
            List<decimal> listeTaux = new List<decimal>() {0.045M, 0.05M, 0.055M, 0.06M, 0.065M};
            EmpruntVariable ev = new EmpruntVariable(10000, 5, new DateTime(2016,5,1), listeTaux);

            List<decimal> listeResult = ev.CalculTauxVariable();
            var listeAttendu = new List<decimal>() {450, 500, 550, 600, 650};
            CollectionAssert.AreEqual(listeAttendu, listeResult);
        }

        [TestMethod]
        public void Test_Calcul_Swap_Emprunt_Constant()
        {
            IEmpruntConstant ec = new EmpruntConstant(10000, 5, new DateTime(2016, 5, 1), 0.05M);
            List<decimal> listeTaux = new List<decimal>() { 0.045M, 0.05M, 0.055M, 0.06M, 0.065M };
            IEmpruntVariable ev = new EmpruntVariable(10000, 5, new DateTime(2016, 5, 1), listeTaux);


            SwapEmprunt s = new SwapEmprunt(ec, ev);
            List<decimal> resultatsEmpruntConstant = s.DifferenceEmpruntConstant();
            var listeAttendu = new List<decimal>() { 50, 0, -50, -100, -150 };
            CollectionAssert.AreEqual(listeAttendu, resultatsEmpruntConstant);

        }

        [TestMethod]
        public void Test_Calcul_Swap_Emprunt_Variable()
        {
            IEmpruntConstant ec = new EmpruntConstant(10000, 5, new DateTime(2016, 5, 1), 0.05M);
            List<decimal> listeTaux = new List<decimal>() { 0.045M, 0.05M, 0.055M, 0.06M, 0.065M };
            IEmpruntVariable ev = new EmpruntVariable(10000, 5, new DateTime(2016, 5, 1), listeTaux);


            SwapEmprunt s = new SwapEmprunt(ec, ev);
            List<decimal> resultatsEmpruntVariable = s.DifferenceEmpruntVariable();
            var listeAttendu = new List<decimal>() { -50, 0, 50, 100, 150 };

            CollectionAssert.AreEqual(listeAttendu, resultatsEmpruntVariable);
        }
    }
}
