using DatabaseAccessLayer.Models;
using DatabaseAccessLayer.Repositories;
using Karina.Models;
using Karina.Services;
using Microsoft.AspNetCore.Mvc;

namespace Karina.Controllers.ApiControllers;

[Route("/api/[controller]/[action]")]
[ApiController]
public class HomeApiController : ControllerBase
{
    private readonly MetricsRepository _metricsRepository;
    private readonly MapService _mapService;

    public HomeApiController(MetricsRepository metricsRepository, MapService mapService)
    {
        _metricsRepository = metricsRepository;
        _mapService = mapService;
    }

    [HttpPost]
    public CalculateResultViewModel Calculate([FromForm] CalculatorViewModel viewModel)
    {
        var resultViewModel = _mapService.MapToResultViewModel(viewModel);
        var data = _mapService.MapToData(resultViewModel, viewModel.CampaignName);
        _metricsRepository.Add(data);
        return resultViewModel;
    }
    
    public bool RemoveMetric([FromQuery]int id)
    {
        _metricsRepository.Remove(id);
        return true;
    }

    public List<MetricsViewModel> SortBy(string sortOrder)
    {
        var result = _metricsRepository
            .GetAll()
            .OrderBy(m => m.CampaignName);
        switch (sortOrder)
        {
            case "CampaignName":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.CampaignName);
                break;
            case "ConversionRate":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.ConversionRate);
                break;
            case "LifetimeValue":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.LifetimeValue);
                break;
            case "ClickThroughRate":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.ClickThroughRate);
                break;
            case "CostPerClick":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.CostPerClick);
                break;
            case "CostPerInstall":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.CostPerInstall);
                break;
            case "CustomerAcquisitionCost":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.CustomerAcquisitionCost);
                break;
            case "ReturnOnMarketingInvestment":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.ReturnOnMarketingInvestment);
                break;
            case "AverageRevenuePerPayingUser":
                result = _metricsRepository
                    .GetAll()
                    .OrderBy(m => m.AverageRevenuePerPayingUser);
                break;
        }

        var viewModel = result
            .Select(m => _mapService.MapToMetricsViewModel(m))
            .ToList();
        return viewModel;
    }
    
}