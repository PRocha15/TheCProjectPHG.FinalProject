using Microsoft.Extensions.Configuration;
using TheCProject.Database.DbEntities;
using TheCProject.ViewModels;
using HashidsNet;
using TheCProject.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TheCProject.Mapper.Base;

namespace TheCProject.Mapper
{
    public static class CakeMapper
    {

        public static CakeViewModel CakeToCakeViewModel(Cake entity)
        {
            CakeViewModel viewModel = (CakeViewModel)BaseMapper.BaseToBaseViewModel(entity, new CakeViewModel());
            viewModel.Name = entity.Name;
            viewModel.Description = entity.Description;
            viewModel.Author= entity.Author;
            viewModel.ImageURL = entity.ImageURL;
            
            return viewModel;
        }

        public static Cake CakeViewModelToCakeEntity(CakeViewModel viewModel)
        {

            Cake cake = (Cake)BaseMapper.BaseViewModelToBaseEntity(viewModel, new Cake());
            cake.Name= viewModel.Name;
            cake.Description= viewModel.Description;
            cake.Author= viewModel.Author;
            cake.ImageURL = viewModel.ImageURL;

            return cake;
        }

        public static List<CakeViewModel> CakeListToCakeViewModelList(List<Cake> cakes)
        {
            List<CakeViewModel> cakeViewModelList = new List<CakeViewModel>();
            cakes.ForEach(cake =>
            {
                cakeViewModelList.Add(CakeToCakeViewModel(cake));
            });
            return cakeViewModelList;
        }


    }
}