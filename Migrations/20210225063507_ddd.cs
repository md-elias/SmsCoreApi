using Microsoft.EntityFrameworkCore.Migrations;

namespace SmsCoreApi.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_SClass_SClassID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Teacher_TeacherID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Section_SectionID",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameIndex(
                name: "IX_Section_TeacherID",
                table: "Sections",
                newName: "IX_Sections_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Section_SClassID",
                table: "Sections",
                newName: "IX_Sections_SClassID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_SClass_SClassID",
                table: "Sections",
                column: "SClassID",
                principalTable: "SClass",
                principalColumn: "SClassID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Teacher_TeacherID",
                table: "Sections",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Sections_SectionID",
                table: "Student",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_SClass_SClassID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Teacher_TeacherID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Sections_SectionID",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_TeacherID",
                table: "Section",
                newName: "IX_Section_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_SClassID",
                table: "Section",
                newName: "IX_Section_SClassID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_SClass_SClassID",
                table: "Section",
                column: "SClassID",
                principalTable: "SClass",
                principalColumn: "SClassID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Teacher_TeacherID",
                table: "Section",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Section_SectionID",
                table: "Student",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
