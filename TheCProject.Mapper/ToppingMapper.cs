using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;
using TheCProject.Mapper.Base;
using TheCProject.ViewModels;

namespace TheCProject.Mapper
{
    public static class ToppingMapper
    {
        public static ToppingViewModel ToppingToToppingViewModel(Topping entity)
        {
            return (ToppingViewModel)CakeElementMapper.CakeElementToCakeElementViewModel(entity, new ToppingViewModel());
        }

        public static Topping ToppingViewModelToToppingEntity(ToppingViewModel viewModel)
        {
            return (Topping)CakeElementMapper.CakeElementViewModelToCakeElementEntity(viewModel, new Topping());
        }

        public static List<ToppingViewModel> ToppingListToToppingViewModelList(List<Topping> toppings)
        {
            List<ToppingViewModel> toppingViewModelList = new List<ToppingViewModel>();
            toppings.ForEach(topping =>
            {
                toppingViewModelList.Add(ToppingToToppingViewModel(topping));
            });
            return toppingViewModelList;
        }
    }
}

