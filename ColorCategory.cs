using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace List
{
    class ColorCategory : BindableObject
    {
        private Color _SelectedColor;

        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set
            {
                _SelectedColor = value;
                OnPropertyChanged(nameof(SelectedColor));
            }
        }
    }
}
