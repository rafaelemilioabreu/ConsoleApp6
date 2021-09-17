using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int CategoriaId { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public double Precio { get; set; }

        public Producto(int id, string nombre, int categoria, string marca, string modelo, double precio)
        {
            Id = id;
            Nombre = nombre;
            CategoriaId = categoria;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;

        }


        
       


    }
}
