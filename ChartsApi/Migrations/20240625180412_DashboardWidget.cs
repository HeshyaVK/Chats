using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChartsApi.Migrations
{
    /// <inheritdoc />
    public partial class DashboardWidget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DashboardWidgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChartType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionRow = table.Column<int>(type: "int", nullable: false),
                    PositionCol = table.Column<int>(type: "int", nullable: false),
                    SizeRows = table.Column<int>(type: "int", nullable: false),
                    SizeCols = table.Column<int>(type: "int", nullable: false),
                    Labels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatasetLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatasetData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorderColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fill = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardWidgets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardWidgets");
        }
    }
}
