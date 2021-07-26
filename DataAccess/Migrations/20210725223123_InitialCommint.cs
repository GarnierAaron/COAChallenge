using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCommint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Telefono",
                table: "Usuarios",
                type: "BIGINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Usuarios",
                type: "INT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BIGINT");
        }
    }
}
