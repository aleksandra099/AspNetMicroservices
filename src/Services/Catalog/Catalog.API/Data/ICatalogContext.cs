using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    //any class that inherits this interface should provide products collection
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
