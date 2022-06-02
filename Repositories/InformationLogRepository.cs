public class InformationLogRepository : BaseMongoRepository<InformationLog>
{
    public InformationLogRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
    {
    }
}