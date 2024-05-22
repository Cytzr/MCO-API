using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCO_API.Migrations
{
    /// <inheritdoc />
    public partial class Fifth_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "userRating",
                table: "Users",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "orderRating",
                table: "UserOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "orderRating",
                table: "CoachOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "coachRating",
                table: "Coaches",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CoachOrders",
                keyColumn: "orderID",
                keyValue: new Guid("6f83ff91-383e-4c7b-b2a3-8dfb5b47dd6d"),
                columns: new[] { "orderRating", "orderStatus" },
                values: new object[] { 5, "Finished" });

            migrationBuilder.UpdateData(
                table: "CoachOrders",
                keyColumn: "orderID",
                keyValue: new Guid("7a0c9db8-b228-4db5-9dd1-1bf0f25c4995"),
                column: "orderRating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"),
                column: "coachRating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"),
                column: "coachRating",
                value: 4.5999999999999996);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"),
                column: "coachRating",
                value: 4.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                column: "coachRating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"),
                column: "coachRating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                column: "coachRating",
                value: 4.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"),
                column: "coachRating",
                value: 4.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"),
                column: "coachRating",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"),
                column: "coachRating",
                value: 4.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "coachID",
                keyValue: new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"),
                column: "coachRating",
                value: 4.9000000000000004);

            migrationBuilder.UpdateData(
                table: "UserOrders",
                keyColumn: "orderID",
                keyValue: new Guid("8cf4bbfe-ec32-496d-bac9-16ab8450d4d9"),
                columns: new[] { "orderRating", "orderStatus" },
                values: new object[] { 5, "Finished" });

            migrationBuilder.UpdateData(
                table: "UserOrders",
                keyColumn: "orderID",
                keyValue: new Guid("9d83e380-084d-4d3a-a56e-d23cbf6b45e8"),
                column: "orderRating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("1a0d6253-b9fd-463e-b9f1-c79c442dbd94"),
                column: "userRating",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7"),
                column: "userRating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                column: "userRating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("4b0e25cf-d151-49d1-b4ff-520e417ea0e2"),
                column: "userRating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                column: "userRating",
                value: 4.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                column: "userRating",
                value: 4.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("99a5c6fd-b832-4375-b5ac-5f78c3c895d2"),
                column: "userRating",
                value: 4.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f"),
                column: "userRating",
                value: 4.7000000000000002);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db"),
                column: "userRating",
                value: 4.4000000000000004);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "userID",
                keyValue: new Guid("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6"),
                column: "userRating",
                value: 4.7000000000000002);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userRating",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "orderRating",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "orderRating",
                table: "CoachOrders");

            migrationBuilder.DropColumn(
                name: "coachRating",
                table: "Coaches");

            migrationBuilder.UpdateData(
                table: "CoachOrders",
                keyColumn: "orderID",
                keyValue: new Guid("6f83ff91-383e-4c7b-b2a3-8dfb5b47dd6d"),
                column: "orderStatus",
                value: "In Progress");

            migrationBuilder.UpdateData(
                table: "UserOrders",
                keyColumn: "orderID",
                keyValue: new Guid("8cf4bbfe-ec32-496d-bac9-16ab8450d4d9"),
                column: "orderStatus",
                value: "In Progress");
        }
    }
}
