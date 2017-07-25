using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading.Models
{
    public class Consumer : INotifyPropertyChanged
    {

        private string _name;       
        public string Name
        {
            get { return _name; }

            set
            {
                if( value != _name)
                {
                    _name = value;
                    onPropertyChanged("Name");
                }
            }
        }
        
        public List<EquityShare> ShareDetails { get; set; }

        public decimal NPV { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
