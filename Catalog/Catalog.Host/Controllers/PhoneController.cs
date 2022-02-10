using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class PhoneController : ControllerBase
{
    private static readonly Phone[] Phones = new[]
    {
        new Phone { Brand = "Apple", Model = "Xr", ReleaseDate = new DateTime(2018, 12, 2), ScreenSize = 6.3},
        new Phone { Brand = "Nokia", Model = "3010", ReleaseDate = new DateTime(2004, 1, 24), ScreenSize = 0.3},
        new Phone { Brand = "Xiaomi", Model = "Redmi 11", ReleaseDate = new DateTime(2019, 10, 8), ScreenSize = 5.7},
        new Phone { Brand = "Samsung", Model = "Galaxy s21", ReleaseDate = new DateTime(2021, 9, 23), ScreenSize = 6.8}
    };

    private readonly ILogger<PhoneController> _logger;

    public PhoneController(ILogger<PhoneController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPhones")]
    public IEnumerable<Phone> Get()
    {
        return Phones;
    }
}
