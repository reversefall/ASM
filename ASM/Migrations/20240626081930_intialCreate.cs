using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASM.Migrations
{
    /// <inheritdoc />
    public partial class intialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "641e26f1-36b6-409c-aa69-db52932b01ab");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64d9321a-1a60-4b4d-8a9a-46c926d55a35");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "adef8831-8b58-4097-acf6-b4d606674670");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27f0e149-58b9-4c69-a4c8-c56c9441ce9f", null, "JobSeeker", "JobSeeker" },
                    { "31d1acec-cffd-49ed-9091-3dfaa3e99dda", null, "admin", "admin" },
                    { "dd77cb30-4fa3-496f-872c-0d092e880e63", null, "Employer", "Employer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "27f0e149-58b9-4c69-a4c8-c56c9441ce9f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31d1acec-cffd-49ed-9091-3dfaa3e99dda");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "dd77cb30-4fa3-496f-872c-0d092e880e63");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "641e26f1-36b6-409c-aa69-db52932b01ab", null, "JobSeeker", "JobSeeker" },
                    { "64d9321a-1a60-4b4d-8a9a-46c926d55a35", null, "Employer", "Employer" },
                    { "adef8831-8b58-4097-acf6-b4d606674670", null, "admin", "admin" }
                });
        }
    }
}
