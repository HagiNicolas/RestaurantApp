﻿using Microsoft.EntityFrameworkCore.Migrations;



namespace RestaurantApp.Migrations
{
    
    public partial class Undo_Keyless_Auth : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "RestaurantAppSchema",
                table: "Auth",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auth",
                schema: "RestaurantAppSchema",
                table: "Auth",
                column: "Email");
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Auth",
                schema: "RestaurantAppSchema",
                table: "Auth");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "RestaurantAppSchema",
                table: "Auth",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}