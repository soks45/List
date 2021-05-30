using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace List
{
    class ViewModel : BindableObject
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
                OnPropertyChanged(nameof(Number));
            }
        }





        public ICommand Add { get; }


        public ICommand Delete { get; }


        public ObservableCollection<Item> ItemList { get; } = new ObservableCollection<Item>();


        private ColorCategory _SelectedColor;

        public ColorCategory SelectedColor
        {
            get { return _SelectedColor; }
            set
            {
                _SelectedColor = value;
 
                OnPropertyChanged(nameof(SelectedColor));
            }
        }



        public void ClickButton1()
        {
            if (SelectedColor == null)
                return;
            if (Number < 1)
                Number = 1;
            if (string.IsNullOrEmpty(Name))
                return;
            Item NewItem = new Item
            {
                Name = Name,
                Number = Number,
                ColorName = SelectedColor.SelectedColor,
                Done = false
            };
            ItemList.Add(NewItem);
            Name = null;
            Number = 1;
        }


        public void ClickButton2()
        {
            for (int i = ItemList.Count -1; i >= 0; i--)
            {
                if (ItemList[i].Done == true)
                    ItemList.RemoveAt(i);
            }
        }


        public ViewModel()
        {
            Add = new Command(ClickButton1);
            Delete = new Command(ClickButton2);
        }

        public ObservableCollection<ColorCategory> ColorList { get; } = new ObservableCollection<ColorCategory>()
        {
            new ColorCategory() { SelectedColor = Color.Aqua },
            new ColorCategory() { SelectedColor = Color.Yellow },
            new ColorCategory() { SelectedColor = Color.GreenYellow },
            new ColorCategory() { SelectedColor = Color.FloralWhite },
            new ColorCategory() { SelectedColor = Color.RoyalBlue },
            new ColorCategory() { SelectedColor = Color.SeaGreen }
        };
    }
}
