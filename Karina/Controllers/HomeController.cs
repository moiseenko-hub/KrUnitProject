using System.Diagnostics;
using DatabaseAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using Karina.Models;
using Karina.Services;

namespace Karina.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MetricsRepository _metricsRepository;
    private readonly MapService _mapService;

    public HomeController(ILogger<HomeController> logger, MetricsRepository metricsRepository, MapService mapService)
    {
        _logger = logger;
        _metricsRepository = metricsRepository;
        _mapService = mapService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Forecast()
    {
        return View();
    }


    [HttpGet]
    public IActionResult Metrics()
    {
        var metrics = _metricsRepository.GetAll();
        var metricsViewModel = metrics
            .Select(_mapService.MapToMetricsViewModel)
            .ToList();
        return View(metricsViewModel);
    }    
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}