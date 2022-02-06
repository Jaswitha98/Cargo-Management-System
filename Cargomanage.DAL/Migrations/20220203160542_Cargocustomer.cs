using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargomanage.DAL.Migrations
{
    public partial class Cargocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Details",
                columns: table => new
                {
                    Sender_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_mobno = table.Column<int>(type: "int", nullable: false),
                    Sender_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_pincode = table.Column<int>(type: "int", nullable: false),
                    Reciever_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reciever_id = table.Column<int>(type: "int", nullable: false),
                    Reciever_mobno = table.Column<int>(type: "int", nullable: false),
                    Reciever_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reciever_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reciever_pincode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Details", x => x.Sender_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Details");
        }
    }
}
