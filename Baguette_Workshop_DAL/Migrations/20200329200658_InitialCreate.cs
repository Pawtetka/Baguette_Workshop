using Microsoft.EntityFrameworkCore.Migrations;

namespace Baguette_Workshop_DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaguetteModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaguetteType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaguetteModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaguetteMaterialModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaguetteModelId = table.Column<int>(nullable: false),
                    MaterialModelId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaguetteMaterialModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaguetteMaterialModels_BaguetteModels_BaguetteModelId",
                        column: x => x.BaguetteModelId,
                        principalTable: "BaguetteModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaguetteMaterialModels_MaterialModels_MaterialModelId",
                        column: x => x.MaterialModelId,
                        principalTable: "MaterialModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaguetteMaterialModels_BaguetteModelId",
                table: "BaguetteMaterialModels",
                column: "BaguetteModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BaguetteMaterialModels_MaterialModelId",
                table: "BaguetteMaterialModels",
                column: "MaterialModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaguetteMaterialModels");

            migrationBuilder.DropTable(
                name: "BaguetteModels");

            migrationBuilder.DropTable(
                name: "MaterialModels");
        }
    }
}
