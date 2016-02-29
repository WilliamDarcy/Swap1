using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
    /// Logique d'interaction pour EmpruntFixeDialog.xaml
    /// </summary>
    public partial class EmpruntFixeDialog : Window
    {
        public EmpruntFixeDialog(ViewModelEmpruntFixe vmef)
        {
            InitializeComponent();
            this.DataContext = vmef;
            vmef.Close = (sender, args) => this.Close();
        }
    }
}
