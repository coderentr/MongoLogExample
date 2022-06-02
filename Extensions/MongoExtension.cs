using System.Diagnostics;

public static class MongoLogExt
{
    public static void LogInformation(this ILogger logger, InformationLogRepository repository, string message, string method)
    {
        try
        {
            var model = new InformationLog
            {
                GId=Guid.NewGuid().ToString(),
                Id=Guid.NewGuid().ToString(),
                Message = message,
                Method = method
            };
            repository.Create(model);
        }
        catch (Exception ex)
        {

        }
    }
}