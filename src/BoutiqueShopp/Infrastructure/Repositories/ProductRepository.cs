using BoutiqueShopp.Domain;
using Dapper;
using System;
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
                data.ShortName,
                data.Quantity,
                data.Category,
                data.Color,
                data.Image,
                data.Size,
                data.GeneralSize,
                data.Description

            }, commandType: CommandType.StoredProcedure);

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
