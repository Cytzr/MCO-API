using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCO_API.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "walletCoachID",
                table: "Wallets");

            migrationBuilder.RenameColumn(
                name: "walletUserID",
                table: "Wallets",
                newName: "walletOwnerID");

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("1bca0053-4d8c-4b68-9e17-f4ee7a6dd06f"),
                column: "walletOwnerID",
                value: new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("27b065a4-317e-47c8-97d4-c4c0d94921a4"),
                column: "walletOwnerID",
                value: new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("2d0c5297-6f7d-4492-8ac7-d0b35f982160"),
                column: "walletOwnerID",
                value: new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("3122b812-b934-4e02-8827-cd8cf41e905f"),
                column: "walletOwnerID",
                value: new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("84c484bf-cf95-4b20-b6ff-1c7b776bba09"),
                column: "walletOwnerID",
                value: new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("8e0a3bb7-ae7a-4624-91b7-ee83ab9e5ee8"),
                column: "walletOwnerID",
                value: new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("ccf33a5b-44a6-484b-97d1-7e7b7dd230f6"),
                column: "walletOwnerID",
                value: new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("d2d81b3d-5154-4394-ba45-2c0407f39e67"),
                column: "walletOwnerID",
                value: new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("d33db8f4-0c0d-4aa3-88e6-7f07d318c3eb"),
                column: "walletOwnerID",
                value: new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("ef16936f-7467-49fd-9269-0e4d775d2b07"),
                column: "walletOwnerID",
                value: new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "walletOwnerID",
                table: "Wallets",
                newName: "walletUserID");

            migrationBuilder.AddColumn<Guid>(
                name: "walletCoachID",
                table: "Wallets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("13f9f80b-5e2d-4b11-b1d3-364b5f674e9d"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("1bca0053-4d8c-4b68-9e17-f4ee7a6dd06f"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("27b065a4-317e-47c8-97d4-c4c0d94921a4"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("2d0c5297-6f7d-4492-8ac7-d0b35f982160"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("3122b812-b934-4e02-8827-cd8cf41e905f"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("5645459f-6673-4bb5-93f3-cde981dd91e1"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("6b024b88-ff19-4f84-9dd5-4b773a671e05"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("6ff8c3a7-d7f4-4ba3-bd99-13b13b3a8e7d"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("7cf950a7-3b7c-4e6e-8c97-ee6b5fc1532d"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("84c484bf-cf95-4b20-b6ff-1c7b776bba09"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("8b24e288-d5df-4d6c-ba34-68dfebb8f3d8"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("8e0a3bb7-ae7a-4624-91b7-ee83ab9e5ee8"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("9298b63e-c117-480b-8d9e-5af67b91cf0b"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("a1ae09e9-cc0e-4f38-9a24-95e3f9d6c71d"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("bfb75d15-0fb8-40cc-8407-47dc8a20d55b"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("ccf33a5b-44a6-484b-97d1-7e7b7dd230f6"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("cfab0e4e-cff6-4c5f-bc91-d7ab5a29b800"),
                column: "walletCoachID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("d2d81b3d-5154-4394-ba45-2c0407f39e67"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("d33db8f4-0c0d-4aa3-88e6-7f07d318c3eb"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"), null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "walletID",
                keyValue: new Guid("ef16936f-7467-49fd-9269-0e4d775d2b07"),
                columns: new[] { "walletCoachID", "walletUserID" },
                values: new object[] { new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), null });
        }
    }
}
