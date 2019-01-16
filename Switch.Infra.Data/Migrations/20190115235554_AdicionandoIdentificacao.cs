using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AdicionandoIdentificacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Usuarios",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySQL:AutoIncrement", true)
                .OldAnnotation("MySQL:AutoIncrement", true);

            migrationBuilder.CreateTable(
                name: "Identificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TipoDocumento = table.Column<int>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identificacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identificacao_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identificacao_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identificacao");

            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySQL:AutoIncrement", true)
                .OldAnnotation("MySQL:AutoIncrement", true);
        }
    }
}
