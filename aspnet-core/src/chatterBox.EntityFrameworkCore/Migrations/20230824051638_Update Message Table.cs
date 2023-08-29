using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chatterBox.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMessageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "messageInfo");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "messageInfo");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "messageInfo");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "messageInfo");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "messageInfo");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "messageInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "messageInfo",
                type: "varchar(40)",
                maxLength: 40,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "messageInfo",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "messageInfo",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "messageInfo",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "messageInfo",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "messageInfo",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");
        }
    }
}
