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
using System.Data.OracleClient;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para MainWindowRecovery.xaml
    /// </summary>
    public partial class MainWindowRecovery : Window
    {
        public MainWindowRecovery()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow c = new MainWindow();
            Close();
            c.ShowDialog();
        }
    }
}