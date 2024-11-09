using Microsoft.AspNetCore.Mvc;

namespace AgileSoftwarePracticeWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PrimeController : ControllerBase
{
    private readonly ILogger<PrimeController> _logger;

    public PrimeController(ILogger<PrimeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<int> Get(int max)
    {
        return [2, 3, 5, 7];
    }
}
