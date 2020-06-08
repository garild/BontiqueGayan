using BoutiqueShopp.Domain;
using Dapper;
using SkyReg.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace BoutiqueShopp.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Product Create(Product data)
        {
            var result = _connection.QueryFirst<Product>("Product_CreateNew", new
            {
                data.Name,
                data.Code,
                data.Quantity,
                data.Category,
                data.Color,
                data.Image,
                data.Size,
                data.GeneralSize,
                data.Description

            }, commandType: CommandType.StoredProcedure); ;

            return result;
        }

        public List<Product> GetAll()
        {
            var result = _connection.Query<Product>("Product_GetAll", null, commandType: CommandType.StoredProcedure).AsList();
            return result;
        }

        public Product Update(Product data)
        {
            throw new NotImplementedException();
        }

        public Image UpdateImage(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
