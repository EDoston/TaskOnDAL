using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsedData.Migrations
{
    public partial class CreateDbinitialTaskData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDatas_Users_ExecutorId",
                table: "TaskDatas");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "TaskDatas");

            migrationBuilder.RenameColumn(
                name: "ExecutorId",
                table: "TaskDatas",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDatas_ExecutorId",
                table: "TaskDatas",
                newName: "IX_TaskDatas_UserId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Нагиев");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDatas_Users_UserId",
                table: "TaskDatas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDatas_Users_UserId",
                table: "TaskDatas");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TaskDatas",
                newName: "ExecutorId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDatas_UserId",
                table: "TaskDatas",
                newName: "IX_TaskDatas_ExecutorId");

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "TaskDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Дудь");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDatas_Users_ExecutorId",
                table: "TaskDatas",
                column: "ExecutorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
