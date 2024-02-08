using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FoodMAUI.Models;
using FoodMAUI.Services;

namespace FoodMAUI.ViewModels
{
	public partial class HomeViewModel : ObservableObject
	{
		private readonly PizzaService _pizzaService;
		public HomeViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(_pizzaService.GetPopularPizzas());
		}

		public ObservableCollection<PizzaModel> Pizzas { get; set; }

	}
}

