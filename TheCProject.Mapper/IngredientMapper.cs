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
    public static class IngredientMapper
    {
        public static IngredientViewModel IngredientToIngredientViewModel(Ingredient entity)
        {
            return (IngredientViewModel)CakeElementMapper.CakeElementToCakeElementViewModel(entity, new IngredientViewModel());
        }

        public static Ingredient IngredientViewModelToIngredientEntity(IngredientViewModel viewModel)
        {
            return (Ingredient)CakeElementMapper.CakeElementViewModelToCakeElementEntity(viewModel, new Ingredient());
        }

        public static List<IngredientViewModel> IngredientListToIngredientViewModelList(List<Ingredient> ingredients)
        {
            List<IngredientViewModel> ingredientViewModelList = new List<IngredientViewModel>();
            ingredients.ForEach(ingredient =>
            {
                ingredientViewModelList.Add(IngredientToIngredientViewModel(ingredient));
            });
            return ingredientViewModelList;
        }
    }
}

