using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<City> Cities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Post[] postsToSeed = new Post[10];
            Country[] countriesToSeed = new Country[3];
            //City[] citiesToSeed = new City[9];

            for (int i = 1; i < 11; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    Id = i,
                    Title = $"Post {i}",
                    Content = $"This is sample content for Post {i}.",
                };
            }

            countriesToSeed[0] = new Country
            {
                Id = 1,
                CountryName = "USA"
            };
            countriesToSeed[1] = new Country
            {
                Id = 2,
                CountryName = "Pakistan"
            };
            countriesToSeed[2] = new Country
            {
                Id = 3,
                CountryName = "India"
            };

            //for (int i = 0; i < 3; i++)
            //{
            //    citiesToSeed[i] = new City
            //    {
            //        CityName = $"City {i}",
            //        CountryId = 1
            //    };
            //}

            //for (int i = 3; i < 6; i++)
            //{
            //    citiesToSeed[i] = new City
            //    {
            //        CityName = $"City {i}",
            //        CountryId = 2
            //    };
            //}

            //for (int i = 6; i < 9; i++)
            //{
            //    citiesToSeed[i] = new City
            //    {
            //        CityName = $"City {i}",
            //        CountryId = 3
            //    };
            //}

            modelBuilder.Entity<Post>().HasData(postsToSeed);
            modelBuilder.Entity<Country>().HasData(countriesToSeed);
            //modelBuilder.Entity<City>().HasData(citiesToSeed);
        }
    }
}
