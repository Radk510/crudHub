using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudHub.WebApi.Migrations
{
    public partial class InsertDataToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, 55, "Semen Semyonovich", "Tokar", 333m },
                    { 2, 45, "Aleksandr Prilykin", "Stolar", 432m },
                    { 3, 28, "Evgen BadComediant", "Bloger", 129202m },
                    { 4, 23, "Petro Vogyr", "Programmer", 33231m },
                    { 5, 34, "Karzen Viktorov", "Office manager", 32421m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);
        }
    }
}
