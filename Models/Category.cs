using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingCartApi.Models
{
    public class Category
    {
        [BsonElement("_id")]
        public MongoDB.Bson.ObjectId Id { get; set; }

        [BsonElement("cat_id")]
        public string CatId { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
