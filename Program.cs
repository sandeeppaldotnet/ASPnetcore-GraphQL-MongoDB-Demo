using GraphQLMongoDemo.Data;
using GraphQLMongoDemo.GraphQL.Mutations;
using GraphQLMongoDemo.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<MongoContext>();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<ItemQuery>()
    .AddMutationType<ItemMutation>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapGraphQL();
app.Run();
