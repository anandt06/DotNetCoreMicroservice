
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using Catalog.API.Entities;

namespace Catalog.API.Data;

public class MongoDbService : ICatalogContext
{

    public MongoDbService(IOptions<MongoDbSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        Products = database.GetCollection<Product>(mongoDBSettings.Value.CollectionName);
        CatalogContextSeed.SeedData(Products);
    }
}