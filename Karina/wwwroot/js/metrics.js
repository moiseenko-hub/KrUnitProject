$(document).ready(function () {
    // Обработчик удаления с делегированием
    $('.metrics-card').on('click', '.delete-button', function () {
        const metricCard = $(this).closest(".metric-card");
        const id = metricCard.data("id");

        $.get(`/api/HomeApi/RemoveMetric?id=${id}`)
            .then(function (result) {
                if (result) {
                    metricCard.remove();
                    alert("Элемент был удален!");
                }
            });
    });
    
    $(".sort-button").click(function () {
        const value = $("#sort-select").val();
        $.get(`/api/HomeApi/SortBy?sortOrder=${value}`)
            .then(function (result) {
                document.querySelectorAll('.metric-card').forEach(element => {
                    element.remove();
                });

                result.forEach(item => {
                    const newCard = document.createElement('div');
                    newCard.className = 'metric-card';
                    newCard.dataset.id = item.id;

                    newCard.innerHTML = `
                        <div class="metric-content">
                            <div>${item.campaignName}</div>
                            <div>Конверсия: ${item.conversionRate}%</div>
                            <div>LTV: ${item.lifetimeValue}</div>
                            <div>CTR: ${item.clickThroughRate}%</div>
                            <div>CPC: ${item.costPerClick}</div>
                            <div>CPI: ${item.costPerInstall}</div>
                            <div>CAC: ${item.customerAcquisitionCost}</div>
                            <div>ROMI: ${item.returnOnMarketingInvestment}%</div>
                            <div>ARPPU: ${item.averageRevenuePerPayingUser}</div>
                        </div>
                        <button class="delete-button">Удалить</button>
                    `;

                    document.querySelector('.metrics-card').appendChild(newCard);
                });
            });
    });
});
