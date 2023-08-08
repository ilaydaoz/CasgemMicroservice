using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservice.Services.Catalog.Models
{
    public class Product
    {
        [BsonId]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductSock { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }
       
        [BsonIgnore]
        public Category Category { get; set; }  
    }
}
