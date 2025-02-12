using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Answers.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixIdentityColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
          name: "YourColumnName",
          table: "YourTableName");

         
            migrationBuilder.AddColumn<int>(
                name: "YourColumnName",
                table: "YourTableName",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
          name: "YourColumnName",
          table: "YourTableName");

            migrationBuilder.AddColumn<int>(
                name: "YourColumnName",
                table: "YourTableName",
                nullable: false);

        }
    }
}
