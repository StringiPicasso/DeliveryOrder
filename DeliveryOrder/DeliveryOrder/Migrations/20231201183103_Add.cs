using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryOrder.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "exa",
                table: "Deliveries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exa",
                table: "Deliveries");
        }
    }
}
