namespace DatabaseAccessLayer.Models;

public class MetricsData : BaseModel
{
    public string CampaignName { get; set; } = string.Empty;
    /// <summary>
    /// CPC (cost per click) = затраты на рекламу / количество кликов
    /// </summary>
    public decimal CostPerClick { get; set; }
    /// <summary>
    /// CTR (click-through rate) = количество кликов / количество показов * 100%
    /// Per procent
    /// </summary>
    public float ClickThroughRate { get; set; }
    /// <summary>
    /// CR (Сonversion Rate) = количество установок приложения / количество кликов * 100%
    /// Per procent
    /// </summary>
    public float ConversionRate { get; set; }
    /// <summary>
    /// CPI (Cost Per Install) = затраты на рекламу / количество установок приложения
    /// </summary>
    public decimal CostPerInstall { get; set; }
    /// <summary>
    /// CAC (Customer Acquisition Cost) = затраты на рекламу / количество покупателей в приложении
    /// </summary>
    public decimal CustomerAcquisitionCost { get; set; }
    /// <summary>
    /// ROMI (Return on Marketing Investment) = (доход с рекламы - затраты на рекламу) / затраты на рекламу * 100%
    /// Per procent
    /// </summary>
    public float ReturnOnMarketingInvestment { get; set; }
    /// <summary>
    /// ARPPU (Average Revenue Per Paying User) = доход с рекламы / количество покупателей в приложении
    /// </summary>
    public decimal AverageRevenuePerPayingUser { get; set; }
    /// <summary>
    /// LTV (Lifetime Value) = ARPPU * средняя продолжительность использования приложения
    /// </summary>
    public float LifetimeValue { get; set; }
}