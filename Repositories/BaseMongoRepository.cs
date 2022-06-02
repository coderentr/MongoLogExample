using MongoDB.Driver;

public class BaseMongoRepository<TModel> where TModel : BaseMongoModel
{
    protected readonly IMongoCollection<TModel> mongoCollection;
    public BaseMongoRepository(string mongoDBConnectionString, string dbName, string collectionName)
    {
        var client = new MongoClient(mongoDBConnectionString);
        var database = client.GetDatabase(dbName);
        mongoCollection = database.GetCollection<TModel>(collectionName);
    }
    public virtual TModel Create(TModel model)
    {
        mongoCollection.InsertOne(model);
        return model;
    }
    //Sadece kayıt atma işlemi yapacağımız için Create fonksiyonunu yazıyorum. 
    
}