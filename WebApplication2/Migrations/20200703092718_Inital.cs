using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Inital : Migration
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
                    price = table.Column<int>(nullable: false),
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

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "id", "content", "created", "format", "whose" },
                values: new object[,]
                {
                    { 1, "https://dynamic.zacdn.com/zvk_pURuBf0qebzA1ki7tOeAFQ0=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/forcast-3385-1064121-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1001 },
                    { 2, "https://dynamic.zacdn.com/kPyjMLscmoN9zhFOFlNZmKzhEqE=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-basics-7289-908288-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1002 },
                    { 3, "https://dynamic.zacdn.com/PXAZe_2vxNQm5-Gwklv1XXB1BZA=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-5887-342268-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1003 },
                    { 4, "https://dynamic.zacdn.com/fVn7okqR8Fv_aPBqGArtyykeP1g=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/r-a-f-by-plains-prints-0623-4461951-2.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1004 },
                    { 5, "https://dynamic.zacdn.com/svO5p4CWSaTfAvwr7_8RJUdpBp4=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/dorothy-perkins-3322-636078-2.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1005 },
                    { 6, "https://dynamic.zacdn.com/Gn_53BkdgO_0agFVlmTo_wFrQiQ=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-9164-5696121-2.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1006 },
                    { 7, "https://dynamic.zacdn.com/GE730BaW3zNJRovgiUEpUyyGGGo=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/zalora-0075-138559-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1007 },
                    { 8, "https://dynamic.zacdn.com/GSDNBe3hVxb-pygRjSFnKS2qa7Y=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/cole-vintage-4379-5930361-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1008 },
                    { 9, "https://dynamic.zacdn.com/O0Dk13WyWc8YVbOAzrq9wFxJf54=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/wallis-8725-031539-1.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1009 },
                    { 10, "https://dynamic.zacdn.com/iVq4A_CjMo3tbUTJPyvTHTv7QFg=/fit-in/762x1100/filters:quality(95):fill(ffffff)/http://static.ph.zalora.net/p/bardot-9307-5647951-2.jpg", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jpg", 1010 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "category", "description", "name", "price", "summary", "supplier" },
                values: new object[,]
                {
                    { 10, "dress_maxi", "Sheeny open back drape dress, Cowl neckline, Regular fit, Invisible back zipper fastening, Back self tie fastening, Polyester blend", "Estelle Drape Dress", 3249, "SOLD BY ZALORA", "Bardot" },
                    { 9, "dress_wrap", "Printed mini dress with flute sleeves, V neckline, Unlined, Regular fit, Waist tie fastening,  Polyblend", "Petite Monochrome Geometric Print Wrap Dress", 3089, "SOLD BY ZALORA", "Wallis" },
                    { 8, "dress_maxi", "Frilled hem high necklined shift midi dress, High neckline, Unlined, Back button keyhole fastening, Sleeveless, Evening", "Zia Midi Dress", 1899, "SOLD BY ZALORA", "Cole Vintag" },
                    { 6, "dress_a lined", "Sleeveless plain mini dress, Unlined, V neckline,  Regular fit, Zip fastening, Polyblend", "Notches Detailed A-Line Dress", 479, "SOLD BY ZALORA", "ZALORA" },
                    { 7, "dress_wrap", "Floral printed shirt dress, Collared neckline, Lined, Regular fit, Waist tie fastening, Polyblend", "Studio Short Sleeve Wrap Dress", 1439, "SOLD BY ZALORA", "ZALORA" },
                    { 4, "dress_maxi", "Floral print tie strap midi dress,  Sweetheart neckline, Self-tie straps,  Shirred back panel, Square back, Casual", "RAF Vinea Sleeveless Dress", 3298, "SOLD BY ZALORA", "R.A.F. by Plains & Prints" },
                    { 3, "dress_wrap", "Monochrome textured mini wrap dress, Lined, V neckline, Relaxed fit, Concealed back zip fastening, Front pleat detail", "Wrap Front Dress", 489, "SOLD BY ZALORA", "ZALORA" },
                    { 2, "dress_shift", "Raglan sleeve shift dress, Round neckline, Unlined, Relaxed fit, Polyblend", "Essential Raglan Sleeve Shift Dress", 749, "SOLD BY ZALORA", "ZALORA BASICS" },
                    { 1, "dress_a lined", "Lined, Round neckline, Regular fit, Front button and back zip fastening", "Karsyn A-Line Dress", 5049, "SOLD BY ZALORA", "FORCAST" },
                    { 5, "dress_shift", "Lace shift dress with bell sleeves, Lined, Fits true to size, take your usual size, Bateau neckline, Short sleeves, Back zipper fastening", "Shimmer Lace Shift Dress", 2795, "SOLD BY ZALORA", "Dorothy Perkins" }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "id", "product", "quantity", "size" },
                values: new object[,]
                {
                    { 17, 6, "150", "2XL" },
                    { 18, 6, "50", "S" },
                    { 19, 6, "50", "M" },
                    { 20, 7, "150", "2XL" },
                    { 21, 7, "200", "XL" },
                    { 22, 7, "1000", "One Size" },
                    { 24, 8, "400", "XL" },
                    { 25, 8, "50", "2XL" },
                    { 26, 9, "300", "M" },
                    { 27, 9, "500", "S" },
                    { 28, 10, "400", "S" },
                    { 16, 5, "900", "XL" },
                    { 23, 8, "80", "L" },
                    { 15, 5, "400", "L" },
                    { 5, 2, "2000", "M" },
                    { 13, 4, "150", "2XL" },
                    { 12, 4, "800", "2XL" },
                    { 11, 4, "50", "XL" },
                    { 10, 3, "100", "S" },
                    { 9, 3, "600", "XL" },
                    { 8, 3, "800", "2XL" },
                    { 7, 2, "500", "L" },
                    { 6, 2, "1000", "2XL" },
                    { 29, 10, "400", "M" },
                    { 4, 10, "50", "S" },
                    { 3, 1, "1000", "One Size" },
                    { 2, 1, "100", "L" },
                    { 1, 1, "900", "S" },
                    { 14, 5, "60", "S" },
                    { 30, 10, "50", "L" }
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
