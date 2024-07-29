using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Shop.DataAccess
{
    public class Entidades
    {
        public record Categoria(int ID,string Nombre);
        public record Producto(int ID, int CategoriaID, string Nombre, string Descripcion, double Precio)
        {
            public Categoria Categoria { get; set; }
        }
        public record Cliente(int ID, string Nombre,string Direccion);
    }
}
