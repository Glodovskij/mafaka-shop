using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mafaka.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Game", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.", "https://mafakastorage.blob.core.windows.net/mafakablob/img/57e9d5434c54af14f1dc8460962e33791c3ad6e04e507440752f78d79e45c5_640.jpg", "Dota 2", 1488.0 },
                    { 2, "Game", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.", "https://mafakastorage.blob.core.windows.net/mafakablob/img/55e6d04a4f56a414f1dc8460962e33791c3ad6e04e507440722d72d19548c1_640.jpg", "LoL", 8.0 },
                    { 3, "Game", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.", "https://mafakastorage.blob.core.windows.net/mafakablob/img/54e0d6404850ab14f1dc8460962e33791c3ad6e04e5074417c2d78d39644c5_640.jpg", "Sea of Thieves", 999.0 },
                    { 4, "Game", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.", "https://mafakastorage.blob.core.windows.net/mafakablob/img/54e0d14a4e57b10ff3d8992cc12c30771037dbf85254784e77267ed69249_640.jpg", "Rust", 1.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
