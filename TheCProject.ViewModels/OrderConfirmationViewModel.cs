using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCProject.ViewModels
{
    public class OrderConfirmationViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public DecorationViewModel Decoration { get; set; }
        public FillingViewModel Filling { get; set; }
        public IngredientViewModel Ingredient { get; set; }
        public ToppingViewModel Topping { get; set; }
        public WeightViewModel Weight { get; set; }

        public double Cost
        {
            get
            {
                if(Decoration == null || Filling == null || Ingredient == null || Topping == null || Weight == null)
                {
                    return 0;
                }
                return Decoration.Price + Filling.Price + Ingredient.Price + Topping.Price + Weight.Price;
            }
        }
    }
}
