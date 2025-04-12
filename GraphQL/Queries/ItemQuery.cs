using GraphQLMongoDemo.Data;
using GraphQLMongoDemo.Models;
using MongoDB.Driver;

namespace GraphQLMongoDemo.GraphQL.Queries
{
    public class ItemQuery
    {
        public IQueryable<Item> GetItems([Service] MongoContext context)
            => context.Items.AsQueryable();
    }
}
