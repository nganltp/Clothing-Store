using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Inial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer = table.Column<int>(nullable: false),
                    detail = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    isDefaultAddress = table.Column<bool>(nullable: false),
                    isHomeAddress = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    birth = table.Column<DateTime>(nullable: false),
                    gender = table.Column<bool>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    closed = table.Column<DateTime>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    account = table.Column<int>(nullable: false),
                    product = table.Column<int>(nullable: false),
                    stars = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    birth = table.Column<DateTime>(nullable: false),
                    gender = table.Column<bool>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    closed = table.Column<DateTime>(nullable: false),
                    created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    whose = table.Column<int>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    format = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product = table.Column<int>(nullable: false),
                    cart = table.Column<int>(nullable: false),
                    order = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin = table.Column<int>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer = table.Column<int>(nullable: false),
                    promotion = table.Column<int>(nullable: false),
                    ordered = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order = table.Column<int>(nullable: false),
                    paid = table.Column<DateTime>(nullable: false),
                    payer = table.Column<int>(nullable: false),
                    method = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    supplier = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product = table.Column<int>(nullable: false),
                    size = table.Column<string>(nullable: true),
                    quantity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin = table.Column<int>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    due = table.Column<DateTime>(nullable: false),
                    by = table.Column<string>(nullable: true),
                    discount = table.Column<float>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer = table.Column<int>(nullable: false),
                    created = table.Column<DateTime>(nullable: false),
                    discard = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "ShoppingCart");
        }
    }
}
