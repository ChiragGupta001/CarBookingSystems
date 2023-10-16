using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class UpdateBookCarUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "3371bc9f-1c2c-444b-8c44-cb56a6ce41fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "4905f9b1-f3df-42c3-8cd7-4b40bfe2847d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9f43c06-9a14-4e46-b81f-3e65250e6e60", "AQAAAAEAACcQAAAAEHgsKs+mjUeYeKFNL/XQMYtvXHbVUSKGNQ6DeHgvIZoadwNo1NCZgqEXUhet4s82LQ==", "af23176a-f470-4f76-b545-1d27e752d183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f027ea3-e241-4797-a2a6-fec39feee5d6", "AQAAAAEAACcQAAAAEEmfGGdzXclBNRy5ZdjDtK9FiAVhH2wMfiEvfuWPslKjfbPzUtDp1K2KirnEG3xlNw==", "3cd34563-da1b-4380-981c-e3dc2d5903de" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "e33f01b7-71f1-48f8-add6-780c1350e7e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "97fcb68f-d36d-436e-8b1d-95c8a1ac5559");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d450d7fe-c9f9-407a-ac93-225388e0b55c", "AQAAAAEAACcQAAAAENUjoy99HeWVANLzh14NvjczAKTvFviaGgm9hBNMfnxH4HxvkrmYV/eUupVGrzuI/g==", "c5867953-5898-469e-b529-52f3c76a157a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "364235e7-06b0-4e11-a739-57d3ad87aba5", "AQAAAAEAACcQAAAAEGfN/p19QDns2cwq2n5cOZ5y26ubhAaZb8nPWB3D69RNhXrXXjRdNrLJ43J6PW1mZQ==", "c56657f3-5aba-4321-89d1-18e2bc2acfa6" });
        }
    }
}
