using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap.ViewModel.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void AfficherEmpruntFixeTest()
        {
            ViewModelMenu vmm = new ViewModelMenu();
            vmm.AfficherEmpruntFixe(null);

            Assert.Fail();
        }
    }
}