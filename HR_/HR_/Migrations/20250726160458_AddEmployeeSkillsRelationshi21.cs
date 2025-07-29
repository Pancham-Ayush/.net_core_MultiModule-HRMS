using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSkillsRelationshi21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_SeniorId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkills_Employees_EmployeesId",
                table: "EmployeeSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkills_Skills_SkillsId",
                table: "EmployeeSkills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SeniorId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSkills",
                table: "EmployeeSkills");

            migrationBuilder.DropColumn(
                name: "SeniorId",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "EmployeeSkills",
                newName: "EmployeeSkill");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkills_SkillsId",
                table: "EmployeeSkill",
                newName: "IX_EmployeeSkill_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill",
                columns: new[] { "EmployeesId", "SkillsId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Senior_id",
                table: "Employees",
                column: "Senior_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_Senior_id",
                table: "Employees",
                column: "Senior_id",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeesId",
                table: "EmployeeSkill",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillsId",
                table: "EmployeeSkill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_Senior_id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeesId",
                table: "EmployeeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillsId",
                table: "EmployeeSkill");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Senior_id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSkill",
                table: "EmployeeSkill");

            migrationBuilder.RenameTable(
                name: "EmployeeSkill",
                newName: "EmployeeSkills");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkill_SkillsId",
                table: "EmployeeSkills",
                newName: "IX_EmployeeSkills_SkillsId");

            migrationBuilder.AddColumn<int>(
                name: "SeniorId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSkills",
                table: "EmployeeSkills",
                columns: new[] { "EmployeesId", "SkillsId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SeniorId",
                table: "Employees",
                column: "SeniorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_SeniorId",
                table: "Employees",
                column: "SeniorId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkills_Employees_EmployeesId",
                table: "EmployeeSkills",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkills_Skills_SkillsId",
                table: "EmployeeSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
