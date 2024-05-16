using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ititans_App1.Migrations
{
    /// <inheritdoc />
    public partial class AddingClassColumnInStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(name: "Class", table: "Student", nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Class", table: "Student");
        }
    }
}
