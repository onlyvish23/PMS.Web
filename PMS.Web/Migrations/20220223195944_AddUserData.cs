using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Web.Migrations
{
    public partial class AddUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "Status", "StatusId", "TwoFactorEnabled", "UserName", "UserTypeId" },
                values: new object[,]
                {
                    { "f424df6a-a43d-4f2d-ad71-0a92854bf8b0", 0, new DateTime(1985, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "b591ef37-44d4-440a-886a-31222c338545", null, false, "David", "Jones", false, null, null, null, null, null, false, null, "2c9cbc21-8921-46c8-9f2f-3c79a21b05d8", 0, 0, false, "User123", 0 },
                    { "485281af-7745-4307-9a05-8aeb0bc760df", 0, new DateTime(1987, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "8ab24ede-8139-4acc-8c2a-a535326b21f6", null, false, "", "Doe", false, null, null, null, null, null, false, new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0ddfe24-0679-40c2-b796-0f88dd75969b", 0, 0, false, "User1234", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "e310a6cb-6677-4aa6-93c7-2763956f7a97",
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(1985, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Jones" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "r310a6cb-6677-4aa6-93c7-2763956f7a97",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "John", "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "485281af-7745-4307-9a05-8aeb0bc760df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f424df6a-a43d-4f2d-ad71-0a92854bf8b0");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "e310a6cb-6677-4aa6-93c7-2763956f7a97",
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { null, "Mark", "Melone" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: "r310a6cb-6677-4aa6-93c7-2763956f7a97",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jerry", "Jones" });
        }
    }
}
