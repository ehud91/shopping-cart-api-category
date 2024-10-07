using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShoppingCartApi.Models;

namespace ShoppingCartApi.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDbSettings> mongoDbSettings)
        {
             var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            _database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
        }

        public IMongoCollection<Category> Categories =>
            _database.GetCollection<Category>(nameof(Category));
    }
}
