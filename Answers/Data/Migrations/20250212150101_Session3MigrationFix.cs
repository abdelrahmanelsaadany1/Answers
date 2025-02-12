using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Answers.Data.Migrations
{
    /// <inheritdoc />
    public partial class Session3MigrationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Dept_ID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "HourRateBonus",
                table: "Instructors",
                newName: "HourRate");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "StudCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Stud_ID",
                table: "StudCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<decimal>(
                name: "Bouns",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "Inst_ID",
                table: "CourseInstructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses",
                columns: new[] { "Stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors",
                columns: new[] { "Inst_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Dep_Id = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors",
                column: "Inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Courses_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Courses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Bouns",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "HourRate",
                table: "Instructors",
                newName: "HourRateBonus");

            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "StudCourses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Stud_ID",
                table: "StudCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Dept_ID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Inst_ID",
                table: "CourseInstructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudCourses",
                table: "StudCourses",
                column: "Stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInstructors",
                table: "CourseInstructors",
                column: "Inst_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "ID");
        }
    }
}
