﻿using GraniteWarehouse.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraniteWarehouse.Data.Migrations
{
    public partial class AddedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                 name: "Products",
                 columns: table => new
                 {
                     Id = table.Column<int>(nullable: false)
                         .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                     Name = table.Column<string>(nullable: false),
                     Price = table.Column<double>(nullable: false), 
                     Available = table.Column<bool>(nullable: false),
                     Image = table.Column<string>(nullable: true),
                     ShadeColor = table.Column<string>(nullable: false),
                     ProductTypeId = table.Column<int>(nullable: false),
                     SpecialTagsId = table.Column<int>(nullable: false)

                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Products", x => x.Id);
                 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
                    migrationBuilder.DropTable(
             name: "Products");
        }
    }
}
