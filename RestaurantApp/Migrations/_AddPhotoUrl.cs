using Microsoft.EntityFrameworkCore.Migrations;



namespace RestaurantApp.Migrations
{
    
    public partial class AddPhotoUrl : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                schema: "RestaurantAppSchema",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                schema: "RestaurantAppSchema",
                table: "Items");
        }
    }
}