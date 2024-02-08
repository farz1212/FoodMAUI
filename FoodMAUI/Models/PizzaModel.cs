using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodMAUI.Models
{
	public partial class PizzaModel : ObservableObject
	{
		public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _cartQuantity;

        public double Amount => CartQuantity * Price;

        public PizzaModel clone() => MemberwiseClone() as PizzaModel;
    }
}

