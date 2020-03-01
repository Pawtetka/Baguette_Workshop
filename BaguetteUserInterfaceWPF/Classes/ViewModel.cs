using BaguetteUserInterfaceWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaguetteUserInterfaceWPF.Classes
{
    class ViewModel : INotifyPropertyChanged
    {
        private IModel _model;
        public ViewModel(IModel model, MainWindow main)
        {
            _model = model;
            main.CountPrice += CountPrice;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CountPrice()
        {
            double pr = _model.GetPrice(Type, Width, Height);
            Price = pr.ToString();
            OnPropertyChanged("Price");
        }

        private double _price;
        public string Price
        {
            get => Convert.ToString(_price/*_model.GetPrice(Type, Width, Height)*/);
            /*{
                if (Type != null)
                {
                    return Convert.ToString(_model.GetPrice(Type, Width, Height));
                }
                else return Convert.ToString(_price);
            }*/
            set { _price = Convert.ToDouble(value); }
        }

        private string _type;
        private double _width;
        private double _height;

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                _width = Convert.ToDouble(value);
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                _height = Convert.ToDouble(value);
            }
        }
    }
}
