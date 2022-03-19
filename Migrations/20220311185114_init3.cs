using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AHN9zoPaCwkr6PmqwanvwuHWmkYwlugtuVFjegKUXPhhyg8Wii9GvrKwLzozfAzfuw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "APBI5z1g337CMW7cpigj7fLMV3G8TEj9z/oNnvHqwIH0WgmMzzoP7g5rlxSyvgZiRw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "APxCURCdC/rGOI74SPyCegLfk06JgWHrXeI8HFOAzzNcnf9w46OZf4Iv3kjM3hzpyQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AKjOnxc8VRG2OKnRE0KwfmJcC6kkllJf7MxNfgadOxGArfPpOBzw6UI6oc0mFTCeHA==");
        }
    }
}
