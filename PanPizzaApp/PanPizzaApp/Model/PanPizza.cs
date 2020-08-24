using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanPizzaApp.Model
{
    class PanPizza
    {
        public string PizzaSize { get; set; }
        public double Price { get; set; }
        public List<SideDish> Ingredients;

        public PanPizza() { }
        public PanPizza(string size, double price)
        {
            PizzaSize = size;
            Price = price;
        }
        public PanPizza(string size, double price, List<SideDish> ing)
        {
            PizzaSize = size;
            Price = price;
            Ingredients = ing;
        }

        public PanPizza(PanPizza pizza, List<SideDish> ing)
        {
            PizzaSize = pizza.PizzaSize;
            Price = pizza.Price;
            Ingredients= ing;
        }

        public List<PanPizza> GetAllPanPizzas()
        {
            List<PanPizza> allPizzas = new List<PanPizza>();
            allPizzas.Add(new PanPizza("small",300));
            allPizzas.Add(new PanPizza("medium", 500));
            allPizzas.Add(new PanPizza("large", 700));
            return allPizzas;
        }

        public double CalculateAmount()
        {
            double finalPrice = Price;
           
            for (int i = 0; i < Ingredients.Count; i++)
            {
                finalPrice += Ingredients[i].IngredientPrice;
            }
            return finalPrice;
        }
    }
}
