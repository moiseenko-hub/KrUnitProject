using DatabaseAccessLayer.Models;
using Karina.Models;

namespace Karina.Services;

public class MapService
{
    public CalculateResultViewModel MapToResultViewModel(CalculatorViewModel viewModel)
    {
        return new CalculateResultViewModel()
        {
            CostPerClick = Math.Round(viewModel.AdCost / viewModel.Clicks, 2, MidpointRounding.AwayFromZero),
            AverageRevenuePerPayingUser = Math.Round(viewModel.AdRevenue / viewModel.Buyers, 2, MidpointRounding.AwayFromZero),
            ClickThroughRate = (float)Math.Round(
                (viewModel.Clicks * 100.0) / viewModel.Views, 
                2, 
                MidpointRounding.AwayFromZero
            ),
            ConversionRate = (float)Math.Round((double)(viewModel.Installs / viewModel.Clicks * 100), 2, MidpointRounding.AwayFromZero),
            CostPerInstall = Math.Round(viewModel.AdCost / viewModel.Installs, 2, MidpointRounding.AwayFromZero),
            CustomerAcquisitionCost = Math.Round(viewModel.AdCost / viewModel.Buyers, 2, MidpointRounding.AwayFromZero),
            LifetimeValue = (float)Math.Round((double)((viewModel.AvgUseTime * viewModel.AdRevenue) / viewModel.Buyers), 2, MidpointRounding.AwayFromZero),
            ReturnOnMarketingInvestment = (float)Math.Round((double)((viewModel.AdRevenue - viewModel.AdCost) / viewModel.AdCost * 100), 2, MidpointRounding.AwayFromZero)
        };
    }

    public MetricsData MapToData(CalculateResultViewModel viewModel, string name)
    {
        return new MetricsData()
        {
            AverageRevenuePerPayingUser = viewModel.AverageRevenuePerPayingUser,
            CampaignName = name,
            ClickThroughRate = viewModel.ClickThroughRate,
            ConversionRate = viewModel.ConversionRate,
            CostPerInstall = viewModel.CostPerInstall,
            CostPerClick = viewModel.CostPerInstall,
            CustomerAcquisitionCost = viewModel.CustomerAcquisitionCost,
            ReturnOnMarketingInvestment = viewModel.ReturnOnMarketingInvestment,
            LifetimeValue = viewModel.LifetimeValue
        };
    }

    public MetricsViewModel MapToMetricsViewModel(MetricsData data)
    {
        return new MetricsViewModel()
        {
            AverageRevenuePerPayingUser = data.AverageRevenuePerPayingUser,
            CampaignName = data.CampaignName,
            ClickThroughRate = data.ClickThroughRate,
            ConversionRate = data.ConversionRate,
            CostPerInstall = data.CostPerInstall,
            CostPerClick = data.CostPerInstall,
            CustomerAcquisitionCost = data.CustomerAcquisitionCost,
            ReturnOnMarketingInvestment = data.ReturnOnMarketingInvestment,
            LifetimeValue = data.LifetimeValue,
            Id = data.Id
        };
    }
}