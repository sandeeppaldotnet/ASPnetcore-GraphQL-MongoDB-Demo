using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GraphQLMongoDemo.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
