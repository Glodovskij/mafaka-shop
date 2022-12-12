using Mafaka.Services.ProductAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace Mafaka.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
             
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                CategoryName = "Game",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.",
                ImageUrl = "https://mafakastorage.blob.core.windows.net/mafakablob/img/57e9d5434c54af14f1dc8460962e33791c3ad6e04e507440752f78d79e45c5_640.jpg",
                Name = "Dota 2",
                Price = 1488,
                ProductId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                CategoryName = "Game",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.",
                ImageUrl = "https://mafakastorage.blob.core.windows.net/mafakablob/img/55e6d04a4f56a414f1dc8460962e33791c3ad6e04e507440722d72d19548c1_640.jpg",
                Name = "LoL",
                Price = 8,
                ProductId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                CategoryName = "Game",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.",
                ImageUrl = "https://mafakastorage.blob.core.windows.net/mafakablob/img/54e0d6404850ab14f1dc8460962e33791c3ad6e04e5074417c2d78d39644c5_640.jpg",
                Name = "Sea of Thieves",
                Price = 999,
                ProductId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                CategoryName = "Game",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan sem in lorem convallis ultricies. Curabitur vulputate accumsan lectus condimentum elementum. Phasellus tincidunt, velit in maximus consequat, sem enim ullamcorper velit, in sollicitudin dui nisl non ex. Maecenas sed libero porta erat accumsan tempor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus quis tellus odio. Fusce pharetra ipsum vitae diam tempus posuere. In gravida tincidunt velit, eu porttitor risus commodo a. Suspendisse potenti. Etiam ac euismod eros. Nam aliquet augue a velit luctus, a euismod arcu mollis. Proin quis nisl tincidunt, vehicula dui in, ultrices velit.",
                ImageUrl = "https://mafakastorage.blob.core.windows.net/mafakablob/img/54e0d14a4e57b10ff3d8992cc12c30771037dbf85254784e77267ed69249_640.jpg",
                Name = "Rust",
                Price = 1,
                ProductId = 4
            });
        }
    }
}
