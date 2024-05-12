using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCO_API.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commenter",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "commenter",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("1b29c773-2e3c-4e9b-b59f-4888c6b18738"),
                column: "commenter",
                value: "Coach3");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("2f1ab3c7-e0c8-4d5a-b6b2-54b3b87f20d2"),
                column: "commenter",
                value: "Coach1");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("45d29558-8fc1-4628-9d9e-0a05741be9e3"),
                column: "commenter",
                value: "User3");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("72e8a29a-4413-4d4f-98bc-3a70218f6e39"),
                column: "commenter",
                value: "User1");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("a13f6494-7141-4b5b-95af-21b12beafac5"),
                column: "commenter",
                value: "User2");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "commentID",
                keyValue: new Guid("e9182aeb-465d-4d0b-ae76-19ef122d3e1b"),
                column: "commenter",
                value: "Coach2");
        }
    }
}
