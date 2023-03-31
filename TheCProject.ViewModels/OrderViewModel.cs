using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCProject.ViewModels
{
    public class OrderViewModel
    {
        public List<DecorationViewModel> Decorations { get; set; }
        public List<FillingViewModel> Fillings { get; set; }
        public List<IngredientViewModel> Ingredients { get; set;}
        public List<ToppingViewModel> Toppings { get; set;}
        public List<WeightViewModel> Weights { get; set; }

    }
}
