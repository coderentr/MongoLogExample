public abstract class BaseMongoModel
{
    public Object Id { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
}