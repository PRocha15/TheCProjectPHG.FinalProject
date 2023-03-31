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
    public static class FillingMapper
    {
        public static FillingViewModel FillingToFillingViewModel(Filling entity)
        {
            return (FillingViewModel)CakeElementMapper.CakeElementToCakeElementViewModel(entity, new FillingViewModel());
        }

        public static Filling FillingViewModelToFillingEntity(FillingViewModel viewModel)
        {
            return (Filling)CakeElementMapper.CakeElementViewModelToCakeElementEntity(viewModel, new Filling());
        }

        public static List<FillingViewModel> FillingListToFillingViewModelList(List<Filling> fillings)
        {
            List<FillingViewModel> fillingViewModelList = new List<FillingViewModel>();
            fillings.ForEach(filling =>
            {
                fillingViewModelList.Add(FillingToFillingViewModel(filling));
            });
            return fillingViewModelList;
        }
    }
}

