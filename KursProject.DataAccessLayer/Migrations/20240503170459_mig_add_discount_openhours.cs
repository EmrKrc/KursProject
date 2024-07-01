using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_discount_openhours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpenMours",
                table: "Contacts",
                newName: "OpenHours");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpenHours",
                table: "Contacts",
                newName: "OpenMours");
        }
    }
}
