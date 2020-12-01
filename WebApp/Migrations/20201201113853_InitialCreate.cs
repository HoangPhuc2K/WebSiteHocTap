﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(maxLength: 200, nullable: false),
                    AccountPassword = table.Column<string>(maxLength: 200, nullable: true),
                    IdRoles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Roles_IdRoles",
                        column: x => x.IdRoles,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: true),
                    Address = table.Column<string>(maxLength: 300, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminForum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: true),
                    Address = table.Column<string>(maxLength: 300, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminForum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminForum_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(maxLength: 200, nullable: false),
                    AccountPassword = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 1000, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coach_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: true),
                    Address = table.Column<string>(maxLength: 300, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(maxLength: 300, nullable: false),
                    IdCourse = table.Column<int>(nullable: false),
                    IdCoach = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    Video = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Coach_IdCoach",
                        column: x => x.IdCoach,
                        principalTable: "Coach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lesson_Course_IdCourse",
                        column: x => x.IdCourse,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Descripsion = table.Column<string>(maxLength: 300, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    IdStudent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Student_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommemtLesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    IdLesson = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommemtLesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommemtLesson_Lesson_IdLesson",
                        column: x => x.IdLesson,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommemtPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    IdPost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommemtPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommemtPost_Post_IdPost",
                        column: x => x.IdPost,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_IdUser",
                table: "Admin",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_AdminForum_IdUser",
                table: "AdminForum",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Coach_IdUser",
                table: "Coach",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_CommemtLesson_IdLesson",
                table: "CommemtLesson",
                column: "IdLesson");

            migrationBuilder.CreateIndex(
                name: "IX_CommemtPost_IdPost",
                table: "CommemtPost",
                column: "IdPost");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_IdCoach",
                table: "Lesson",
                column: "IdCoach");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_IdCourse",
                table: "Lesson",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Post_IdStudent",
                table: "Post",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Student_IdUser",
                table: "Student",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdRoles",
                table: "User",
                column: "IdRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AdminForum");

            migrationBuilder.DropTable(
                name: "CommemtLesson");

            migrationBuilder.DropTable(
                name: "CommemtPost");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
