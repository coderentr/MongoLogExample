using ExampleWorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        IConfiguration configuration = hostContext.Configuration;
        MongoConnectionModel _mongoConnectionModel = configuration.GetSection("MongoDb").Get<MongoConnectionModel>();
        #region Mongo Configuration
        services.AddTransient(_ => new InformationLogRepository(
             _mongoConnectionModel.ConnectionString,
             _mongoConnectionModel.DbName,
             "InformationLog"
        ));
        #endregion

        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
