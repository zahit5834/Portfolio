using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_portfollio_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Portfollios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfollios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Portfollios",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfollios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Portfollios");
        }
    }
}
