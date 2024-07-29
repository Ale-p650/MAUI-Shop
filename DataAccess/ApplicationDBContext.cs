using Microsoft.EntityFrameworkCore;

namespace MAUI_Shop.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<Entidades.Categoria> Categorias { get; set; }
        public DbSet<Entidades.Producto> Productos { get; set; }
        public DbSet<Entidades.Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ShopBBDD");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Entidades.Categoria[] arrDatosCategorias = {
                new Entidades.Categoria(1,"Ropa"),
                new Entidades.Categoria(2,"Perfumeria"),
                new Entidades.Categoria(3,"Marroquineria"),
            };

            Entidades.Producto[] arrDatosProductos = {
                new Entidades.Producto(1,1,"Remera Thrasher","Remera Thrasher Blanca M",17000),
                new Entidades.Producto(2,1,"Remera Lacoste","Remera Lacoste Azul L",24750),
                new Entidades.Producto(3,2,"Paco Rabanne Phantom","",120000),
                new Entidades.Producto(4,2,"Dior Sauvage","",140000),
                new Entidades.Producto(5,2,"Dior Homme","",17000),
                new Entidades.Producto(6,2,"Antonio Banderas Blue Seduction","",45000),
                new Entidades.Producto(7,3,"Cinturon Hombre","Cinturon Cuero Vacuno Hombre",32000),
                new Entidades.Producto(8,3,"Cinturon Mujer","Cinturon Cuero Sintetico Mujer",18000)
            };

            Entidades.Cliente[] arrDatosClientes =
            {
                new Entidades.Cliente(1,"Ale","Vivaldi 1875"),
                new Entidades.Cliente(2,"Pepe","Lamadrid 657"),
                new Entidades.Cliente(3,"Susana","Av. De La Plata 2431"),
                new Entidades.Cliente(4,"Cacho","Ayolas 422"),
                new Entidades.Cliente(5,"Quique","Bombero Sanchez 1010"),
                new Entidades.Cliente(6,"Marta","Corrientes 4530"),
            }


            modelBuilder.Entity<Entidades.Categoria>().HasData(arrDatosCategorias);
            modelBuilder.Entity<Entidades.Producto>().HasData(arrDatosProductos);
            modelBuilder.Entity<Entidades.Cliente>().HasData(arrDatosClientes);

        }


    }
}
