﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.Storage.MS_SQL.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldCodeTableCenter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Centers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Centers");
        }
    }
}
