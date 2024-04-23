﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace ShopContent.Modell
{
    public class Items : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged("Name"); } }

        private double price;
        public double Price {  get { return price; } set { price = value; OnPropertyChanged("Price"); } }

        private Categories category;
        public Categories Category { get { return category; } set { category = value; OnPropertyChanged("Category"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
