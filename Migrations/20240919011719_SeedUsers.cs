using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnidadVI.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 28, "New York", "John Doe", 45000.50m },
                    { 2, 34, "Los Angeles", "Jane Smith", 60000.00m },
                    { 3, 22, "Chicago", "Mike Johnson", 30000.00m },
                    { 4, 30, "Houston", "Emily Davis", 48000.75m },
                    { 5, 40, "Phoenix", "Chris Brown", 85000.00m },
                    { 6, 27, "San Francisco", "Anna Lee", 52000.30m },
                    { 7, 35, "Miami", "David Wilson", 70000.10m },
                    { 8, 25, "Seattle", "Laura Taylor", 35000.00m },
                    { 9, 33, "Boston", "James White", 62000.45m },
                    { 10, 29, "Denver", "Sarah Green", 46000.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
