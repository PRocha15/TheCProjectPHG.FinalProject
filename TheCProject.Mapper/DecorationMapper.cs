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
    public static class DecorationMapper
    {
        public static DecorationViewModel DecorationToDecorationViewModel(Decoration entity)
        {
            return (DecorationViewModel)CakeElementMapper.CakeElementToCakeElementViewModel(entity, new DecorationViewModel());
        }

        public static Decoration DecorationViewModelToDecorationEntity(DecorationViewModel viewModel)
        {
            return (Decoration)CakeElementMapper.CakeElementViewModelToCakeElementEntity(viewModel, new Decoration());
        }

        public static List<DecorationViewModel> DecorationListToDecorationViewModelList(List<Decoration> decorations)
        {
            List<DecorationViewModel> decorationViewModelList = new List<DecorationViewModel>();
            decorations.ForEach(decoration =>
            {
                decorationViewModelList.Add(DecorationToDecorationViewModel(decoration));
            });
            return decorationViewModelList;
        }
    }
}
