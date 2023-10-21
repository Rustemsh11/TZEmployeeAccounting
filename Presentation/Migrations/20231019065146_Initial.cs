using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MainDepartmentid = table.Column<int>(type: "int", nullable: true),
                    BossId = table.Column<int>(type: "int", nullable: true),
                    RecordState = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__B2079BED3EFAA496", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK__Departmen__MainD__25869641",
                        column: x => x.MainDepartmentid,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TabelNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmploymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "date", nullable: true),
                    RecordState = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__7AD04F111E5B441F", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK__Employees__Depar__286302EC",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BossId",
                table: "Departments",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MainDepartmentid",
                table: "Departments",
                column: "MainDepartmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK__Departmen__BossI__276EDEB3",
                table: "Departments",
                column: "BossId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Departmen__BossI__276EDEB3",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
