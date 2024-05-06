﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CarWorkShopAboutAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "CarWorkShops",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "CarWorkShops");
        }
    }
}
