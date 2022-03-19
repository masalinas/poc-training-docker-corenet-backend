
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace poc_training_docker_corenet_backend.Models;

[BsonIgnoreExtraElements]
public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; } = null!;

    [BsonElement("description")]
    public String Description { get; set; } = null!;

    [BsonElement("price")]
    [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
    public float Price { get; set; }

    [BsonElement("active")]
    public Boolean Active { get; set; }

}