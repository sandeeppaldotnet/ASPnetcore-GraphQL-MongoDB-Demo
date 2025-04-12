using GraphQLMongoDemo.Models;
using MongoDB.Driver;

namespace GraphQLMongoDemo.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDb:ConnectionString"]);
            _database = client.GetDatabase(config["MongoDb:Database"]);
        }

        public IMongoCollection<Item> Items => _database.GetCollection<Item>("Items");
    }
}
