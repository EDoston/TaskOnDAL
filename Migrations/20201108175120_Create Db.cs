using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsedData.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskDatas",
                columns: new[] { "Id", "CreateDate", "DataStateId", "Description", "LastUpdate", "Name", "State", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 16GB", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S2", 0, 1 },
                    { 22, new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB Ultra", new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 11", 0, 2 },
                    { 21, new DateTime(2019, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 64GB Red", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 10", 0, 2 },
                    { 20, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 32GB White", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 9", 0, 3 },
                    { 19, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 64GB", new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 8", 0, 3 },
                    { 18, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB", new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 7", 0, 3 },
                    { 17, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB", new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 6", 0, 3 },
                    { 16, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 5", 0, 3 },
                    { 15, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 16GB", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 4", 0, 3 },
                    { 14, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 16GB", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 3", 0, 4 },
                    { 13, new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 16GB", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 2", 0, 4 },
                    { 12, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB light", new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S21", 0, 2 },
                    { 11, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB black", new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S20", 0, 2 },
                    { 10, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB Ultra", new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S11", 0, 2 },
                    { 9, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 64GB Red", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S10", 0, 5 },
                    { 8, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 32GB White", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S9", 0, 5 },
                    { 7, new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 64GB", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S8", 0, 5 },
                    { 6, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB", new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S7", 0, 5 },
                    { 5, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB", new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S6", 0, 1 },
                    { 4, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 128GB", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S5", 0, 1 },
                    { 3, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 64GB", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S4", 0, 1 },
                    { 2, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Smartphone 32GB", new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Galaxy S3", 0, 1 },
                    { 23, new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB black", new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 12", 0, 2 },
                    { 24, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Xiaomi Note plus 128GB light", new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Note plus 13", 0, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TaskDatas",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
