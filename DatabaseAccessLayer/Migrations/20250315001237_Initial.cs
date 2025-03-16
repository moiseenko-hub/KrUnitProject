using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DatabaseAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Metrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CampaignName = table.Column<string>(type: "text", nullable: false),
                    CostPerClick = table.Column<decimal>(type: "numeric", nullable: false),
                    ClickThroughRate = table.Column<float>(type: "real", nullable: false),
                    ConversionRate = table.Column<float>(type: "real", nullable: false),
                    CostPerInstall = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerAcquisitionCost = table.Column<decimal>(type: "numeric", nullable: false),
                    ReturnOnMarketingInvestment = table.Column<float>(type: "real", nullable: false),
                    AverageRevenuePerPayingUser = table.Column<decimal>(type: "numeric", nullable: false),
                    LifetimeValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metrics", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Metrics");
        }
    }
}
