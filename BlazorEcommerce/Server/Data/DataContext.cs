namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       Title = "Lo que el viento se llevó",
                       Description = "Lo que el viento se llevó es un drama romántico o, según algunos críticos, un melodrama. La novela gira en torno a la historia de la joven Scarlett O'Hara, integrante de una familia aristócrata sureña, en tiempos de la Guerra de Secesión.",
                       ImagenUrl = "https://www.hislibris.com/wp-content/uploads/2007/06/Sense-t%C3%ADtol.jpg",
                       Price = 9.99m,
                       CategoryId = 1
                   },
                   new Product
                   {
                       Id = 2,
                       Title = "¿Quién se ha llevado mi queso?",
                       Description = "La historia narra el día a día de dos ratones, Fisgón y Escurridizo, y dos liliputienses, Kif y Kof. Los cuatro protagonistas pasan sus días corriendo por los pasillos de un laberinto en busca de queso, alimento del que dependen para nutrirse y ser felices.",
                       ImagenUrl = "https://www.resumenlibro.com/img/libros/quien-se-ha-llevado-mi-queso.jpg",
                       Price = 7.99m,
                       CategoryId = 1

                   },
                   new Product
                   {
                       Id = 3,
                       Title = "Don Quijote de la Mancha",
                       Description = "De aspecto pálido, alto, delgado, nariz puntiaguda, tiene Barba y bigote. Es el protagonista de la novela y constituye un consagrado mito de la literatura universal, y el más universal y profundo de la literatura española.",
                       ImagenUrl = "https://lalibretadenani.files.wordpress.com/2020/07/don-quijote.jpg",
                       Price = 6.99m,
                       CategoryId = 1
                   }
                   );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
