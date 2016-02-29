using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Swap.ViewModel;

namespace Swap.Views
{
    /// <summary>
    /// Logique d'interaction pour EmpruntVariableDialog.xaml
    /// </summary>
    public partial class EmpruntVariableDialog : Window
    {
        public EmpruntVariableDialog(ViewModelEmpruntVariable vmv)
        {
            InitializeComponent();
            this.DataContext = vmv;
            vmv.Close = (sender, args) => this.Close();
        }
    }
}
