using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiftTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingDayOfWeek = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeekTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeekTemplates_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sets_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlannedSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekTemplateId = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId1 = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId2 = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId3 = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId4 = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId5 = table.Column<int>(type: "int", nullable: true),
                    WeekTemplateId6 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId",
                        column: x => x.WeekTemplateId,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId1",
                        column: x => x.WeekTemplateId1,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId2",
                        column: x => x.WeekTemplateId2,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId3",
                        column: x => x.WeekTemplateId3,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId4",
                        column: x => x.WeekTemplateId4,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId5",
                        column: x => x.WeekTemplateId5,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSessions_WeekTemplates_WeekTemplateId6",
                        column: x => x.WeekTemplateId6,
                        principalTable: "WeekTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlannedSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    TargetMinRep = table.Column<int>(type: "int", nullable: false),
                    TargetMaxRep = table.Column<int>(type: "int", nullable: false),
                    PlannedSessionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedSets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannedSets_PlannedSessions_PlannedSessionId",
                        column: x => x.PlannedSessionId,
                        principalTable: "PlannedSessions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId",
                table: "PlannedSessions",
                column: "WeekTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId1",
                table: "PlannedSessions",
                column: "WeekTemplateId1");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId2",
                table: "PlannedSessions",
                column: "WeekTemplateId2");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId3",
                table: "PlannedSessions",
                column: "WeekTemplateId3");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId4",
                table: "PlannedSessions",
                column: "WeekTemplateId4");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId5",
                table: "PlannedSessions",
                column: "WeekTemplateId5");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSessions_WeekTemplateId6",
                table: "PlannedSessions",
                column: "WeekTemplateId6");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSets_ExerciseId",
                table: "PlannedSets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSets_PlannedSessionId",
                table: "PlannedSets",
                column: "PlannedSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_UserId",
                table: "Plans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_ExerciseId",
                table: "Sets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_SessionId",
                table: "Sets",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekTemplates_PlanId",
                table: "WeekTemplates",
                column: "PlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannedSets");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "PlannedSessions");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "WeekTemplates");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
