namespace ExampleWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    public readonly InformationLogRepository  _informationlogRepository;

    public Worker(ILogger<Worker> logger, InformationLogRepository informationlogRepository)
    {
        _logger = logger;
        _informationlogRepository = informationlogRepository;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation(_informationlogRepository, "Started Worker Service", "ExecuteAsync");
            _logger.LogInformation(_informationlogRepository, "Set Test Log", "ExecuteAsync");
            await Task.Delay(10000, stoppingToken);
        }
    }
}
