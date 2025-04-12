using GraphQLMongoDemo.Data;
using GraphQLMongoDemo.Models;
using MongoDB.Driver;

namespace GraphQLMongoDemo.GraphQL.Mutations
{
    public class ItemInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class ItemMutation
    {
        public async Task<Item> AddItemAsync(ItemInput input, [Service] MongoContext context)
        {
            var item = new Item
            {
                Title = input.Title,
                Description = input.Description
            };
            await context.Items.InsertOneAsync(item);
            return item;
        }

        public async Task<Item> UpdateItemAsync(string id, ItemInput input, [Service] MongoContext context)
        {
            var update = Builders<Item>.Update
                .Set(i => i.Title, input.Title)
                .Set(i => i.Description, input.Description);

            var result = await context.Items.FindOneAndUpdateAsync<Item>(
                i => i.Id == id, update, new FindOneAndUpdateOptions<Item> { ReturnDocument = ReturnDocument.After });

            return result;
        }

        public async Task<bool> DeleteItemAsync(string id, [Service] MongoContext context)
        {
            var result = await context.Items.DeleteOneAsync(i => i.Id == id);
            return result.DeletedCount > 0;
        }
    }
}
