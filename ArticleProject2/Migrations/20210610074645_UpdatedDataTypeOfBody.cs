using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleProject2.Migrations
{
    public partial class UpdatedDataTypeOfBody : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Articles",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Articles",
                type: "varchar (250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (250)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Articles",
                type: "varchar (250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Articles",
                type: "varchar (250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar (250)");
        }
    }
}
