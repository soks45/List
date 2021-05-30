using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace List 
{
    class Item: BindableObject
    {
        private string _Name;

        public string Name      
        {
            get { return _Name; }
            set 
            { 
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _Number;

        public int Number
        {
            get { return _Number; }
            set 
            { 
                _Number = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private Color _ColorName;

        public Color ColorName
        {
            get { return _ColorName; }
            set 
            { 
                _ColorName = value;
                OnPropertyChanged(nameof(ColorName));
            }
        }

        private bool _Done;

        public bool Done
        {
            get { return _Done; }
            set 
            { 
                _Done = value;
                OnPropertyChanged(nameof(Done));
            }
        }


    }
}
