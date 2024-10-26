using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class staffmigrationupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DepNo",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DepNo",
                table: "Staffs");
        }
    }
}
