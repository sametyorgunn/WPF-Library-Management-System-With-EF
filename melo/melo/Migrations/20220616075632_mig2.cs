using Microsoft.EntityFrameworkCore.Migrations;

namespace melo.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publisher_phone",
                table: "publishers",
                newName: "publisherphone");

            migrationBuilder.RenameColumn(
                name: "publisher_name",
                table: "publishers",
                newName: "publishername");

            migrationBuilder.RenameColumn(
                name: "publisher_mail",
                table: "publishers",
                newName: "publishermail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publisherphone",
                table: "publishers",
                newName: "publisher_phone");

            migrationBuilder.RenameColumn(
                name: "publishername",
                table: "publishers",
                newName: "publisher_name");

            migrationBuilder.RenameColumn(
                name: "publishermail",
                table: "publishers",
                newName: "publisher_mail");
        }
    }
}
