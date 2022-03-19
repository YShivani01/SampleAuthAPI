using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAPI.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AG6GlC0cD5bT0BE0KYjZvpmarfHTubGd+1GlXV9wvTApA/HzYc+DFDRU29I/BmSGUw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "ACdwpjp1sUSsftJjrYS0S3rG77cC7Ko27sM9jaY2iKETeaC3MVeP75DqePWx0v3ukw==");
        }
    }
}
