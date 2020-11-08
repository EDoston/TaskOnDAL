using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsedData.Migrations
{
    public partial class CreateDbinitialUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "LastUpdate", "Name", "Sername", "State", "StateId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", "Ivanov", 0, 1 },
                    { 2, new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasiliy", "Vasya", 0, 1 },
                    { 3, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nekrasov", "Nikolya", 0, 1 },
                    { 4, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кисилёв", "Дмитрий", 0, 1 },
                    { 5, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Дудь", "Юрий", 0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
