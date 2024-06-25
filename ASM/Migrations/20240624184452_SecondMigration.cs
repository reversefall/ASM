using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASM.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "724ff435-4202-4bac-b383-ca93c84e4678", null, "JobSeeker", "JobSeeker" },
                    { "e3aee21f-bc0f-4421-a496-85f59d1bdbf3", null, "Employer", "Employer" },
                    { "ebdfa80b-7558-427c-a29f-216ba632da2b", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "724ff435-4202-4bac-b383-ca93c84e4678");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3aee21f-bc0f-4421-a496-85f59d1bdbf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebdfa80b-7558-427c-a29f-216ba632da2b");
        }
    }
}
