namespace CleanArchitecture.Infrastructure.BackgroundJobs
{
    public class MyBackgroundService : BackgroundService
    {
        private readonly ILogger<MyBackgroundService> _logger;

        public MyBackgroundService(ILogger<MyBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("MyBackgroundService is starting. FROM CleanArcitecture.Infrastructre.BackgroundJobs");

            while (!stoppingToken.IsCancellationRequested)
            {
                // Your background job logic here
                
                _logger.LogInformation("MyBackgroundService is running. FROM CleanArcitecture.Infrastructre.BackgroundJobs");

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken); // Adjust the delay as needed
            }

            _logger.LogInformation("MyBackgroundService is stopping. FROM CleanArcitecture.Infrastructre.BackgroundJobs");
        }
    }
}