using Microsoft.Extensions.Options;
using MongoDB.Driver;

using poc_training_docker_corenet_backend.Models;
using poc_training_docker_corenet_backend.Config;

namespace poc_training_docker_corenet_backend.Services;

public class ProductService
{
    private readonly IMongoCollection<Product> productCollection;

    public ProductService(
        IOptions<DatabaseConfig> databaseConfig)
    {
        var mongoClient = new MongoClient(
            databaseConfig.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            databaseConfig.Value.DatabaseName);

        productCollection = mongoDatabase.GetCollection<Product>(
            databaseConfig.Value.ProductCollectionName);
    }


    public async Task<List<Product>> GetAsync() =>
        await productCollection.Find(_ => true).ToListAsync();

    public async Task<Product?> GetAsync(string id) =>
        await productCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Product product) =>
        await productCollection.InsertOneAsync(product);

    public async Task UpdateAsync(string id, Product product) =>
        await productCollection.ReplaceOneAsync(x => x.Id == id, product);

    public async Task RemoveAsync(string id) =>
        await productCollection.DeleteOneAsync(x => x.Id == id);

}