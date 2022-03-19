using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BanTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 1, "Mumbai", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "AG6GlC0cD5bT0BE0KYjZvpmarfHTubGd+1GlXV9wvTApA/HzYc+DFDRU29I/BmSGUw==", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 2, "Delhi", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ACdwpjp1sUSsftJjrYS0S3rG77cC7Ko27sM9jaY2iKETeaC3MVeP75DqePWx0v3ukw==", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
