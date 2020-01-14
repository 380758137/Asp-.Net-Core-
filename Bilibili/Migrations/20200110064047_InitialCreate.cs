using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilibili.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Introduction = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    EmployeeNo = table.Column<string>(maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("f3055f0a-2df1-4f39-8033-c3bd133a15eb"), "Great Company", "Mirstorft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"), "Bad Company", "google" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("bb2bde7c-83f4-4cc9-aca0-c260348230cf"), "FuBao Company", "Alibaba" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("bd345541-4271-47ab-95f4-0e78468de258"), new Guid("f3055f0a-2df1-4f39-8033-c3bd133a15eb"), new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "M001", "Mary", 2, "king" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("8b00569e-2263-4cf2-aa5f-b14f5de7d90d"), new Guid("f3055f0a-2df1-4f39-8033-c3bd133a15eb"), new DateTime(1989, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "M002", "Dave", 1, "Bob" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7bb9215b-83b5-444a-b96c-13e4a47c8a45"), new Guid("f3055f0a-2df1-4f39-8033-c3bd133a15eb"), new DateTime(1960, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "M003", "Keya", 1, "Noer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7363e32b-5ff5-4ae0-8c66-66f94ffdfba5"), new Guid("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"), new DateTime(1988, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "G001", "Mars", 2, "Lodfa" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("e4d51c62-2f63-4fe1-9570-1ac6cd9e1c5c"), new Guid("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"), new DateTime(1990, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "G002", "Nasew", 1, "Pax" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("6aac2b6c-ed10-417e-82af-9b54589e1d28"), new Guid("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"), new DateTime(2000, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "G003", "Perter", 1, "Bumars" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("3076aed0-2d87-48b8-9ff1-bd18e9e2d298"), new Guid("bb2bde7c-83f4-4cc9-aca0-c260348230cf"), new DateTime(1992, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A001", "张", 2, "三" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("f718283a-0243-478d-9f26-4a3c0a268eaf"), new Guid("bb2bde7c-83f4-4cc9-aca0-c260348230cf"), new DateTime(1990, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A002", "李", 1, "四" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("86e1a7eb-ec30-482e-bb87-891c7355c8a7"), new Guid("bb2bde7c-83f4-4cc9-aca0-c260348230cf"), new DateTime(1999, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A003", "王", 1, "五" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
