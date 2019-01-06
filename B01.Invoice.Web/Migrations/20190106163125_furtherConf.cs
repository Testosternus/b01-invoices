using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace B01.Invoice.Web.Migrations
{
    public partial class furtherConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemVAT",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ItemFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVAT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVAT_Items_ItemFK",
                        column: x => x.ItemFK,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVAT_ItemFK",
                table: "ItemVAT",
                column: "ItemFK",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVAT");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Name");
        }
    }
}
