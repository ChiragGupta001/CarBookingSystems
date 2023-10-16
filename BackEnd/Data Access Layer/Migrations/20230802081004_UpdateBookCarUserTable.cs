using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    public partial class UpdateBookCarUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_AspNetUsers_UserId1",
                table: "BookCars");

            migrationBuilder.DropIndex(
                name: "IX_BookCars_UserId1",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BookCars");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "BookCars",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_BookCars_Id",
                table: "BookCars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCars_AspNetUsers_Id",
                table: "BookCars",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCars_AspNetUsers_Id",
                table: "BookCars");

            migrationBuilder.DropIndex(
                name: "IX_BookCars_Id",
                table: "BookCars");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookCars");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "BookCars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
