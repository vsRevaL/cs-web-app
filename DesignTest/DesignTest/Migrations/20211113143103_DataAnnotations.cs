using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignTest.Migrations
{
    public partial class DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "route",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from_city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    to_city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    km = table.Column<int>(type: "int", nullable: false),
                    when = table.Column<DateTime>(type: "datetime", nullable: false),
                    seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_route", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "useer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    route_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.id);
                    table.ForeignKey(
                        name: "FK__booking__route_i__4E88ABD4",
                        column: x => x.route_id,
                        principalTable: "route",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__booking__user_id__4F7CD00D",
                        column: x => x.user_id,
                        principalTable: "useer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_route_id",
                table: "booking",
                column: "route_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_user_id",
                table: "booking",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__useer__F3DBC572E39A754A",
                table: "useer",
                column: "username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "route");

            migrationBuilder.DropTable(
                name: "useer");
        }
    }
}
