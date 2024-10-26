using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudProjectApi.Migrations
{
    /// <inheritdoc />
    public partial class addcolumnDepNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "DepNo",
                table: "Staffs");
        }
    }
}
