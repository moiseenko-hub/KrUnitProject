$(document).ready(function (){
    $("#submit").click(function (event){
        event.preventDefault()
        const calcForm = $(this).closest("#calculator-form")
        const views = calcForm.find("#views").val();
        const clicks = calcForm.find("#clicks").val();
        const adCost = calcForm.find("#ad-cost").val();
        const installs = calcForm.find("#installs").val();
        const buyers = calcForm.find("#buyers").val();
        const adRevenue = calcForm.find("#ad-revenue").val();
        const avgUseTime = calcForm.find("#avg-use-time").val();
        const campaignName = calcForm.find("#name").val();
        const req = {
            CampaignName : campaignName,
            Views: views,
            Clicks: clicks,
            AdCost: adCost,
            Installs: installs,
            Buyers: buyers,
            AdRevenue: adRevenue,
            AvgUseTime: avgUseTime
        };

        if (views && clicks && adCost && installs && buyers && adRevenue && avgUseTime){
            alert("Данные успешно сохранены!")
            $.post("/api/HomeApi/Calculate", req).then(function(result) {
                $("#cpc-value").text(`${result.costPerClick} ₽`);
                $("#ctr-value").text(`${result.clickThroughRate}%`);
                $("#cr-value").text(`${result.conversionRate}%`);
                $("#cpi-value").text(`${result.costPerInstall} ₽`);
                $("#cac-value").text(`${result.customerAcquisitionCost} ₽`);
                $("#romi-value").text(`${result.returnOnMarketingInvestment}%`);
                $("#arppu-value").text(`${result.averageRevenuePerPayingUser} ₽`);
                $("#ltv-value").text(`${result.lifetimeValue} ₽`);
            });

        }else{
            alert("Пожалуйста, заполните все поля!");
        }
        
    })
})