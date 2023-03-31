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
    public static class WeightMapper
    {
        public static WeightViewModel WeightToWeightViewModel(Weight entity)
        {
            return (WeightViewModel)CakeElementMapper.CakeElementToCakeElementViewModel(entity, new WeightViewModel());
        }

        public static Weight WeightViewModelToWeightEntity(WeightViewModel viewModel)
        {
            return (Weight)CakeElementMapper.CakeElementViewModelToCakeElementEntity(viewModel, new Weight());
        }

        public static List<WeightViewModel> WeightListToWeightViewModelList(List<Weight> weights)
        {
            List<WeightViewModel> weightViewModelList = new List<WeightViewModel>();
            weights.ForEach(weight =>
            {
                weightViewModelList.Add(WeightToWeightViewModel(weight));
            });
            return weightViewModelList;
        }
    }
}

