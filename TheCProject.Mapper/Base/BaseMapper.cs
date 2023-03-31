using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Commons;
using TheCProject.Database.DbEntities;
using TheCProject.Database.DbEntities.Base;
using TheCProject.ViewModels;
using TheCProject.ViewModels.Base;
using HashidsNet;

namespace TheCProject.Mapper.Base
{
    public class BaseMapper
    {
        public static BaseViewModel BaseToBaseViewModel(BaseEntity entity, BaseViewModel viewModel)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var _salt = config["HashIdSalt"];

            var hashIdGenerator = new Hashids(_salt);

            viewModel.Identifier = entity.Identifier.ToHtmlIdentifier();
            viewModel.HashedId = hashIdGenerator.Encode(entity.Id);

            viewModel.CreateDate = entity.CreateDate;
            viewModel.CreateUser = entity.CreateUser;
            viewModel.UpdateDate = entity.UpdateDate;
            viewModel.UpdateUser = entity.UpdateUser;

            return viewModel;
        }

        public static BaseEntity BaseViewModelToBaseEntity(BaseViewModel viewModel, BaseEntity entity)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var _salt = config["HashIdSalt"];
            var hashIdGenerator = new Hashids(_salt);

            entity.Identifier = viewModel.Identifier.FromHtmlIdentifier();

            entity.CreateDate = viewModel.CreateDate;
            entity.CreateUser = viewModel.CreateUser;
            entity.UpdateDate = viewModel.UpdateDate;
            entity.UpdateUser = viewModel.UpdateUser;

            
            if (viewModel.HashedId != null)
            {
                hashIdGenerator.TryDecodeSingle(viewModel.HashedId, out var hashId);
                entity.Id = hashId;
            }
            return entity;

        }
        
    }
}
