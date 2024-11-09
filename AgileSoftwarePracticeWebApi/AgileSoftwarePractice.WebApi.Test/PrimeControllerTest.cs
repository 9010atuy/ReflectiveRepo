using AgileSoftwarePracticeWebApi.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AgileSoftwarePracticeWebApi.Test;

public class PrimeControllerTest
{
    private readonly IServiceProvider _serviceProvider;
    public PrimeControllerTest()
    {
        _serviceProvider = BuildServiceProvier();
    }

    private IServiceProvider BuildServiceProvier()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddLogging();
        return services.BuildServiceProvider();
    }

    [Fact]
    public void TestGet()
    {
        var input = 10;
        var logger = _serviceProvider.GetRequiredService<ILogger<PrimeController>>();
        PrimeController controller = new(logger);
        IEnumerable<int> act = controller.Get(input);
        Assert.Equal([2, 3, 5, 7], act);
    }
}