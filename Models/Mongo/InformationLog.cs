using MongoDB.Bson.Serialization.Attributes;

public class InformationLog : BaseMongoModel
{
    [BsonElement("GId")]
    public string GId { get; set; }
    [BsonElement("Method")]
    public string Method { get; set; }

    [BsonElement("Message")]
    public string Message { get; set; }
}