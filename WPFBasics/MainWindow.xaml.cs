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
using Trading.Models;

namespace Trading.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Consumer dataSource = new Consumer() { Name = "Chinu", NPV = 100, ShareDetails = new List<EquityShare>() };
        public MainWindow()
        {
            //InitializeComponent();
            this.DataContext = dataSource;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dataSource.Name);
        }
    }
}
