using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoderSquare.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class firstChangedPropertyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_Problems_ProblemId1",
                table: "ProblemTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_Types_TypeId1",
                table: "ProblemTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProblemTypes_ProblemId1",
                table: "ProblemTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProblemTypes_TypeId1",
                table: "ProblemTypes");

            migrationBuilder.DropColumn(
                name: "ProblemId1",
                table: "ProblemTypes");

            migrationBuilder.DropColumn(
                name: "TypeId1",
                table: "ProblemTypes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Types",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProblemTypes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Problems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTypes_ProblemId",
                table: "ProblemTypes",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTypes_TypeId",
                table: "ProblemTypes",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_Problems_ProblemId",
                table: "ProblemTypes",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_Types_TypeId",
                table: "ProblemTypes",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_Problems_ProblemId",
                table: "ProblemTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_Types_TypeId",
                table: "ProblemTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProblemTypes_ProblemId",
                table: "ProblemTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProblemTypes_TypeId",
                table: "ProblemTypes");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Types",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "ProblemTypes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "ProblemId1",
                table: "ProblemTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TypeId1",
                table: "ProblemTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Problems",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTypes_ProblemId1",
                table: "ProblemTypes",
                column: "ProblemId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTypes_TypeId1",
                table: "ProblemTypes",
                column: "TypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_Problems_ProblemId1",
                table: "ProblemTypes",
                column: "ProblemId1",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_Types_TypeId1",
                table: "ProblemTypes",
                column: "TypeId1",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
