﻿using BaguetteUserInterfaceWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaguetteUserInterfaceWPF.Classes
{
    public class ViewModel : INotifyPropertyChanged
    {
        private IModel _model;
        public ViewModel(IModel model)
        {
            _model = model;
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

        private RelayCommand _countPriceCommand;

        public RelayCommand CountPriceCommand
        {
            get
            {
                return _countPriceCommand ?? (new RelayCommand(obj => 
                {
                    CountPrice();
                }));
            }
        }

        private double _price;
        public string Price
        {
            get => Convert.ToString(_price);
            set { _price = Convert.ToDouble(value); }
        }

        private List<string> _types;
        public List<string> Types
        {
            get => _model.GetBaguetteTypes();
            set { _types = value; }
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
