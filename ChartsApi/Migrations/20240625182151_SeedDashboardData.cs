using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChartsApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDashboardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DashboardWidgets",
                columns: new[] { "Id", "BackgroundColor", "BorderColor", "ChartType", "DatasetData", "DatasetLabel", "Fill", "Labels", "PositionCol", "PositionRow", "SizeCols", "SizeRows" },
                values: new object[,]
                {
                    { 1, "#FF6384,#36A2EB,#FFCE56", null, "pie", "300,50,100", null, null, "A,B,C", 0, 0, 3, 2 },
                    { 2, "#FF6384,#36A2EB,#FFCE56", null, "bar", "65,59,80", "Sales", null, "January,February,March", 9, 0, 3, 2 },
                    { 3, "#FF6384,#36A2EB,#FFCE56", "#4bc0c0", "line", "65,59,80", "Sales", false, "January,February,March", 0, 2, 3, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DashboardWidgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DashboardWidgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DashboardWidgets",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
