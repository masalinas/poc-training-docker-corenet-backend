
using System.Runtime.Serialization;
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
    [DataMember]
    public string Name { get; set; } = null!;

    [BsonElement("description")]
    [DataMember]
    public String Description { get; set; } = null!;

    [BsonElement("price")]
    [DataMember]
    public float Price { get; set; }

    [BsonElement("active")]
    [DataMember]
    public Boolean Active { get; set; }

}