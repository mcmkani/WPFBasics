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
using Trading.Models;

namespace Trading.UI
{
    /// <summary>
    /// Interaction logic for DataTemplateWindow.xaml
    /// </summary>
    public partial class DataTemplateWindow : Window
    {
        Consumer dataSource = new Consumer() { Name = "Chinu", NPV = 100, ShareDetails = new List<EquityShare>() };
        List<Consumer> Consumers = new List<Consumer>();
        
        public DataTemplateWindow()
        {
            InitializeComponent();
            Consumers.Add(dataSource);
            Consumers.Add(new Consumer() { Name = "Manjaiah", NPV = 101, ShareDetails = new List<EquityShare>() });
            Consumers.Add(new Consumer() { Name = "Kani", NPV = 102, ShareDetails = new List<EquityShare>() });
            

            this.DataContext = Consumers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dataSource.Name);
        }
    }
}
