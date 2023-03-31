using TheCProject.Database.Context;
using TheCProject.ViewModels;
using TheCProject.Mapper;
using TheCProject.Dal.Interfaces;
using TheCProject.Commons;

namespace TheCProject.Web.Helpers
{
    public static class DatabaseHelper
    {

        public static List<CakeViewModel> Cakes(ICakeRepository cakeRepository)
        {
            var cakesList = cakeRepository.Cakes.ToList();
            var cakes = CakeMapper.CakeListToCakeViewModelList(cakesList);
            return cakes;
            
        }
        public static void CreateCake(ICakeRepository cakeRepository, CakeViewModel cake)
        {
            cake.HashedId = null;
            cake.Identifier = Guid.NewGuid().ToHtmlIdentifier();

            var cakeEntity = CakeMapper.CakeViewModelToCakeEntity(cake);
            cakeRepository.Insert(cakeEntity);
        }
        public static CakeViewModel Cake(ICakeRepository cakeRepository, string identifier)
        {
            var cake = cakeRepository.Cake(identifier.FromHtmlIdentifier());
            return CakeMapper.CakeToCakeViewModel(cake);
        }

        public static void UpdateCake(ICakeRepository cakeRepository, CakeViewModel cake)
        {
            var cakeEntity = CakeMapper.CakeViewModelToCakeEntity(cake);
            cakeRepository.Update(cakeEntity);
        } 

        public static void DeleteCake(ICakeRepository cakeRepository, string identifier)
        {

            cakeRepository.Delete(identifier.FromHtmlIdentifier());


        }

        public static List<DecorationViewModel> Decorations(IDecorationRepository decorationRepository)
        {
            var decorationList = decorationRepository.Decorations.ToList();
            var decorations = DecorationMapper.DecorationListToDecorationViewModelList(decorationList);
            return decorations;
        }
        public static void DeleteDecoration(IDecorationRepository decorationRepository, string identifier)
        {

            decorationRepository.Delete(identifier.FromHtmlIdentifier());

            
        }


        public static List<FillingViewModel> Fillings(IFillingRepository fillingRepository)
        {
            var fillingList = fillingRepository.Fillings.ToList();
            var fillings = FillingMapper.FillingListToFillingViewModelList(fillingList);
            return fillings;
        }

        public static List<IngredientViewModel> Ingredients(IIngredientRepository ingredientRepository)
        {
            var ingredientList = ingredientRepository.Ingredients.ToList();
            var ingredients = IngredientMapper.IngredientListToIngredientViewModelList(ingredientList);
            return ingredients;
        }

        public static List<ToppingViewModel> Toppings(IToppingRepository toppingRepository)
        {
            var toppingList = toppingRepository.Toppings.ToList();
            var toppings = ToppingMapper.ToppingListToToppingViewModelList(toppingList);
            return toppings;
        }

        public static List<WeightViewModel> Weights(IWeightRepository weightRepository)
        {
            var weightList = weightRepository.Weights.ToList();
            var weights = WeightMapper.WeightListToWeightViewModelList(weightList);
            return weights;
        }

        public static OrderViewModel OrderViewModel(IDecorationRepository decorationRepository,
            IFillingRepository fillingRepository, IIngredientRepository ingredientRepository,
            IToppingRepository toppingRepository, IWeightRepository weightRepository)
        {
            OrderViewModel order = new OrderViewModel();
            order.Decorations = Decorations(decorationRepository);
            order.Fillings = Fillings(fillingRepository);
            order.Ingredients = Ingredients(ingredientRepository);
            order.Toppings = Toppings(toppingRepository);
            order.Weights = Weights(weightRepository);
            return order;

        }

        public static OrderConfirmationViewModel OrderConfirmationViewModel(IDecorationRepository decorationRepository,
            IFillingRepository fillingRepository, IIngredientRepository ingredientRepository,
            IToppingRepository toppingRepository, IWeightRepository weightRepository, OrderFormViewModel order)
        {
            OrderConfirmationViewModel orderConfirmation = new OrderConfirmationViewModel();

            // Encontrar o filling
            orderConfirmation.Decoration = Decorations(decorationRepository).FindAll(decoration =>
            {
                return decoration.Identifier == order.DecorationId;
            }).First();
            
            // Encontrar o filling
            orderConfirmation.Filling = Fillings(fillingRepository).FindAll(filling => 
            {
                return filling.Identifier == order.FillingId;
            }).First();

            // encontrar o ingrediente
            orderConfirmation.Ingredient = Ingredients(ingredientRepository).FindAll(ingredient =>
            {
                return ingredient.Identifier == order.IngredientId;
            }).First();

            // encontrar o Topping
            orderConfirmation.Topping = Toppings(toppingRepository).FindAll(topping =>
            {
                return topping.Identifier == order.ToppingId;
            }).First();

            // encontrar o weight
            orderConfirmation.Weight = Weights(weightRepository).FindAll(weight =>
            {
                return weight.Identifier == order.WeightId;
            }).First();


            return orderConfirmation;

        }
    }
}
