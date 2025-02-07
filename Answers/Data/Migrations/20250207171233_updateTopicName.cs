using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Answers.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTopicName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Topics",
                newName: "TopicName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicName",
                table: "Topics",
                newName: "Name");
        }
    }
}
