using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Commons;
using TheCProject.Database.DbEntities;
using TheCProject.Database.DbEntities.Base;
using TheCProject.ViewModels.Base;
using HashidsNet;

namespace TheCProject.Mapper.Base
{
    public static class CakeElementMapper
    {
        public static CakeElementViewModel CakeElementToCakeElementViewModel(CakeElement entity, CakeElementViewModel viewModel)
        {
            
            viewModel = (CakeElementViewModel)BaseMapper.BaseToBaseViewModel(entity, viewModel);
            viewModel.Name = entity.Name;
            viewModel.Price = entity.Price;

            return viewModel;
        }

        public static CakeElement CakeElementViewModelToCakeElementEntity(CakeElementViewModel viewModel, CakeElement entity)
        {
            entity = (CakeElement)BaseMapper.BaseViewModelToBaseEntity(viewModel, entity);

            entity.Name = viewModel.Name;
            entity.Price = viewModel.Price;

            return entity;
        }

    }
}
