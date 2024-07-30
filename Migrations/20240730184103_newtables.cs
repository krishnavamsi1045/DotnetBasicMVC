using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace solidReference.Migrations
{
    /// <inheritdoc />
    public partial class newtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_city",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__city", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    city = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__student", x => x.Id);
                    table.ForeignKey(
                        name: "FK__student__city_city",
                        column: x => x.city,
                        principalTable: "_city",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__student__country_country",
                        column: x => x.country,
                        principalTable: "_country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__student_city",
                table: "_student",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "IX__student_country",
                table: "_student",
                column: "country");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_student");

            migrationBuilder.DropTable(
                name: "_city");

            migrationBuilder.DropTable(
                name: "_country");
        }
    }
}
