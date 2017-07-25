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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            FillInstitutions();
            FillDataGrid();
            FillSymbols();
        }

        private void FillInstitutions()
        {
            List<string> exchanges = new List<string>();
            exchanges.Add("NSE");
            exchanges.Add("BSE");
            cboExchange.ItemsSource = exchanges;
        }

        private void FillDataGrid()
        {
            List<EquityShare> dataItems = new List<EquityShare>();
            dataItems.Add(new EquityShare() { Company = "State Bank Of India", NoOfShares = 100, Symbol = "SBI" });
            dataItems.Add(new EquityShare() { Company = "Infosys Technologies", NoOfShares = 500, Symbol = "Infy" });
            dataItems.Add(new EquityShare() { Company = "Wipro Technologies", NoOfShares = 1000, Symbol = "WIP" });
            dataItems.Add(new EquityShare() { Company = "Microsoft", NoOfShares = 1000, Symbol = "MSI" });
            dataItems.Add(new EquityShare() { Company = "Riversand", NoOfShares = 10, Symbol = "RST" });
            dataItems.Add(new EquityShare() { Company = "Unibiz Software", NoOfShares = 100, Symbol = "UBS" });
            dataItems.Add(new EquityShare() { Company = "ITC Infotech", NoOfShares = 10000, Symbol = "ITC" });
            dataItems.Add(new EquityShare() { Company = "Goldman Sachs", NoOfShares = 100000, Symbol = "GSI" });

            dgShareDetails.ItemsSource = dataItems;

        }

        private void FillSymbols()
        {
            List<string> symbolsList = new List<string>();
            symbolsList.Add("SBI");
            symbolsList.Add("RBI");
            symbolsList.Add("UTI");
            symbolsList.Add("GTB");
            symbolsList.Add("SBT");
            symbolsList.Add("IOB");
            symbolsList.Add("IND");
            symbolsList.Add("YES");
            symbolsList.Add("ABN");

            comboBox.ItemsSource = symbolsList;

        }


    }
}
