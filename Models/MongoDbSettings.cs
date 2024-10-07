using MongoDB.Driver;

namespace ShoppingCartApi.Models
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
    }
}
