using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class UpdateBookCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId",
                table: "BookCars");

            migrationBuilder.DropIndex(
                name: "IX_BookCars_UserId",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookCars");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "BookCars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "BookCars",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "d8138dad-280e-4f0e-be7e-aa11159d9642");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "2f0670bb-3e7e-431f-8655-535ac333349f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d462017-5c89-4424-935a-23468d2b0cc2", "AQAAAAEAACcQAAAAECopRKi4nYh3B+YssSMdEuy6iiv2F/97OKo3ZR4RN0F6ohrv41dKjzK6P3+2KspuoQ==", "d27191da-6498-4b4e-b5da-c83ed8d30c51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b54d82-6696-4f46-93f8-30e40136314e", "AQAAAAEAACcQAAAAECHWgdjZe+f1q6VzvaL2zz3/08Wr8WFIryA6XjrCTxzSXgvC4HrELRYrrAtSUUDgaA==", "9cc93abd-425f-4ff8-b37f-790da184cf1c" });

            migrationBuilder.CreateIndex(
                name: "IX_BookCars_UserId1",
                table: "BookCars",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId1",
                table: "BookCars",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId1",
                table: "BookCars");

            migrationBuilder.DropIndex(
                name: "IX_BookCars_UserId1",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BookCars");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BookCars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "BookCars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "252c85f6-5e23-4b0d-af17-99971c36c43b",
                column: "ConcurrencyStamp",
                value: "79c69b71-f1f8-4bd5-922c-c7becdeb46b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "381ddd37-7ec9-46e6-ad76-3ba06106f305",
                column: "ConcurrencyStamp",
                value: "6d7ae49d-dcb9-4235-b509-4f55d8694ccb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11055be5-ff3b-4c19-8716-6cf364c91528",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c213e924-f57e-4b10-94ad-c0247fce60ea", "AQAAAAEAACcQAAAAEHKU051yKtV2Iu7ZEZ3GbBwEFqar2NscxGcR9CPmDacgZaIAEzVpKBrqejZgVG9jFw==", "95c826ba-e1ba-47cf-8da0-244da051ce68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aee5bb60-0f95-4414-b5ee-55dcf2a1f58d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b2508f2-67a4-43a1-aa32-c0e1138a9597", "AQAAAAEAACcQAAAAEK4NqSNYzvkY0mFm7JrwWKt8lPsz3hoyiNY0H0pEfJOdZCVKJks0wwbwb1nyAMQbBg==", "80f1ee08-104f-4d27-b0f4-9741ea206412" });

            migrationBuilder.CreateIndex(
                name: "IX_BookCars_UserId",
                table: "BookCars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId",
                table: "BookCars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
