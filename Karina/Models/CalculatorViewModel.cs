namespace Karina.Models;

public class CalculatorViewModel
{
    public string CampaignName { get; set; } = string.Empty;
    /// <summary>
    /// Количество показов рекламы.
    /// </summary>
    public int Views { get; set; }

    /// <summary>
    /// Количество кликов на рекламу.
    /// </summary>
    public int Clicks { get; set; }

    /// <summary>
    /// Затраты на рекламу.
    /// </summary>
    public decimal AdCost { get; set; }

    /// <summary>
    /// Количество установок приложения.
    /// </summary>
    public int Installs { get; set; }

    /// <summary>
    /// Количество покупателей в приложении.
    /// </summary>
    public int Buyers { get; set; }

    /// <summary>
    /// Доход с рекламы.
    /// </summary>
    public decimal AdRevenue { get; set; }

    /// <summary>
    /// Средняя продолжительность использования приложения.
    /// </summary>
    public decimal AvgUseTime { get; set; }
    
}

