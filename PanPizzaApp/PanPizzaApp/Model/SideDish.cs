using System.Collections.Generic;

namespace PanPizzaApp.Model
{
    /// <summary>
    /// Model for side dishes for pizzaModel
    /// </summary>
    class SideDish
    {
        public string Ingredient { get; set; }
        public double IngredientPrice { get; set; }
        public bool IsSelectedIngredient { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public SideDish() { }
        /// <summary>
        /// Consturctor taking 2  paramethers for creating side dish object 
        /// </summary>
        /// <param name="name">Ingredient name</param>
        /// <param name="price">Ingredient price</param>
        public SideDish(string name, double price)
        {
            Ingredient = name;
            IngredientPrice = price;
        }

        
    }
}
