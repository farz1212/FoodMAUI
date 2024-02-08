using System;
using FoodMAUI.Models;

namespace FoodMAUI.Services
{
	public class PizzaService
	{
		private readonly static IEnumerable<PizzaModel> _pizzas = new List<PizzaModel>
		{
			new PizzaModel
			{
				Name = "Burger",
				Image = "burger.png",
				Price = 5.99
			},
			new PizzaModel
			{
				Name = "Cake",
				Image = "cake.png",
				Price = 4.49
			},
            new PizzaModel
            {
                Name = "Chicken",
                Image = "chicken.png",
                Price = 8.99

            },
            new PizzaModel
            {
                Name = "Donut",
                Image = "donut.png",
                Price = 2.99

            },
            new PizzaModel
            {
                Name = "Fish",
                Image = "fish.png",
                Price = 9.49

            },
            new PizzaModel
            {
                Name = "Fries",
                Image = "fries.png",
                Price = 2.99

            },
            new PizzaModel
            {
                Name = "Hotdog",
                Image = "hotdog.png",
                Price = 3.49

            },
            new PizzaModel
            {
                Name = "Pancake",
                Image = "pancake.png",
                Price = 4.49

            },
            new PizzaModel
            {
                Name = "Pie",
                Image = "pie.png",
                Price = 7.49

            },
            new PizzaModel
            {
                Name = "Pizza",
                Image = "pizza.png",
                Price = 9.99

            },
            new PizzaModel
            {
                Name = "Rice",
                Image = "rice.png",
                Price = 8.49

            },
            new PizzaModel
            {
                Name = "Salad",
                Image = "salad.png",
                Price = 3.99

            },
            new PizzaModel
            {
                Name = "Sandwich",
                Image = "sandwich.png",
                Price = 4.99

            },
            new PizzaModel
            {
                Name = "Spaghetti",
                Image = "spaghetti.png",
                Price = 6.99

            },
            new PizzaModel
            {
                Name = "Wrap",
                Image = "wrap.png",
                Price = 5.99

            },
        };

        public IEnumerable<PizzaModel> GetAllPizzas() => _pizzas;

        public IEnumerable<PizzaModel> GetPopularPizzas(int count = 6) =>
            _pizzas.OrderBy(p => Guid.NewGuid())
            .Take(count);

        public IEnumerable<PizzaModel> SearchPizzas(string searchTerm) =>
            string.IsNullOrEmpty(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }
}

