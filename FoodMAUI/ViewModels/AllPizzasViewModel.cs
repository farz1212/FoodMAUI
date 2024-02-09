using System;

namespace FoodMAUI.ViewModels
{
	[QueryProperty(nameof(FromSearch), nameof(FromSearch))]
	public partial class AllPizzasViewModel : ObservableObject
	{
		private readonly PizzaService _pizzaService;
		public AllPizzasViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(pizzaService.GetAllPizzas());
		}
		public ObservableCollection<PizzaModel> Pizzas { get; set; }

        [ObservableProperty]
		private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

		[RelayCommand]
		private async Task SearchPizzas(string searchTerm)
		{
			Pizzas.Clear();
			Searching = true;
			await Task.Delay(1000);
			foreach (var pizza in _pizzaService.SearchPizzas(searchTerm))
			{
				Pizzas.Add(pizza);
			}
			Searching = false;
		}
    }
}

