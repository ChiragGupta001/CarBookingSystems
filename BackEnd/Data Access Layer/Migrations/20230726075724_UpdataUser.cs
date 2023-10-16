using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class UpdataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "29bb307a-fbb2-43e0-8451-dbe3d3d2a8fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "e2042cff-de20-44c5-9f71-ada5a5675609");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efc5435-8889-4963-934f-4e565b95a4ae", "Admin", "AQAAAAEAACcQAAAAEKBvaQlTTC4B3kNM2l2R9zk2a5MfY9rGMYUmfMAGaWgDPWL/JZ4fAi5eI7q3i8QXJw==", "168d8d61-a7b2-428f-bc65-ac6a645a9ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "625d7f0d-cf74-4ed5-9bec-68d2b742de8b", "User", "AQAAAAEAACcQAAAAELQVL4CrUsLNTEM6sKmrQBCpCSwQzZ8zLzYDLN3vcusCBOmTwZ4v/aUdSTG9pdflSA==", "67261718-2709-411c-b148-2a170d0fc299" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "9f45a717-c26a-4f6c-afac-43cb63ed9692");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "581e0369-b5a1-4323-a3ff-56b3acf22e9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa08b170-7f61-49a0-a097-38d5a04d4bd4", "AQAAAAEAACcQAAAAEJhOo2xyLjf+SlaxA6zzvd6ypoDmgC0/REOwGYFZTx3fmIaf+cVXxL2b7V5GI+X99A==", "f7af6a8f-4064-4d64-bdb5-9cfe9285e0a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75e1f4f0-8f65-412e-ab7c-1c7eac0d0c08", "AQAAAAEAACcQAAAAEJhqrI0lGiT9vNDSXm/WDoBM6pGfxwO5/MwVX2uWDi3f9Hfp8P6iiANj9zd8IGtryw==", "51ffc052-ad8f-42b8-955f-d8b2fd902cfe" });
        }
    }
}
