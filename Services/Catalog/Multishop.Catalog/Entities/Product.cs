using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Multishop.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProducImageUrl { get; set; } = string.Empty;
        public string ProducDescrition { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        [BsonIgnore]
        public Category Category { get; set; } = new Category();
    }
}
