using BaguetteUserInterfaceWPF.Classes;
using BLL_new.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaguetteUserInterfaceWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void CountPriceDelegate();
        public event CountPriceDelegate CountPrice;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel(new Model(new JoinContainer()), this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CountPrice();
        }
    }
}
