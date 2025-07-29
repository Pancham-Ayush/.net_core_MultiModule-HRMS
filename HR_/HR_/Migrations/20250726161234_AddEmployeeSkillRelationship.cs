using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSkillRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Employees_EmployeesId",
                table: "EmployeeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillsId",
                table: "EmployeeSkill");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSkills",
                table: "EmployeeSkills",
                columns: new[] { "EmployeesId", "SkillsId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkills_Employees_EmployeesId",
                table: "EmployeeSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkills_Skills_SkillsId",
                table: "EmployeeSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSkills",
                table: "EmployeeSkills");

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
    }
}
