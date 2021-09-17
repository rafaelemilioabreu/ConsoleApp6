using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            List<Categoria> categorias = new List<Categoria>();

            Producto producto1 = new Producto(1,"Desodorante",1,"Volksvagen","13-14", 15);
            Producto producto2 = new Producto(2,"pasata dental",1,"colgate","13-14", 3000);
            Producto producto3 = new Producto(3,"cepillo de deintes",1,"adobe","13-14", 17);
            Producto producto4 = new Producto(4,"taxi",2,"tesla","13-14", 4000);
            Producto producto5 = new Producto(5,"autobus",2,"didi","13-14", 16);
            Producto producto6 = new Producto(6,"moster truck",2,"amazon","13-14", 5000);
            Producto producto7 = new Producto(7,"laptop",3,"steam","13-14", 15);
            Producto producto8 = new Producto(8,"tarjeta grafica",3,"Nvidia","13-14", 5001);
            Producto producto9 = new Producto(9,"Wii u",4,"Nintendo","13-14", 17);
            Producto producto10 = new Producto(10,"Dark Souls",5,"Microsoft","13-14", 18);

            Categoria categoria1 = new Categoria(1,"Higiene");
            Categoria categoria2 = new Categoria(2,"Autos");
            Categoria categoria3 = new Categoria(3,"Computadoras");
            Categoria categoria4 = new Categoria(4,"Consolas de videojuegos");
            Categoria categoria5 = new Categoria(5,"Videojuegos");

            productos.Add(producto1);
            productos.Add(producto2);
            productos.Add(producto3);
            productos.Add(producto4);
            productos.Add(producto5);
            productos.Add(producto6);
            productos.Add(producto7);
            productos.Add(producto8);
            productos.Add(producto9);
            productos.Add(producto10);

            categorias.Add(categoria1);
            categorias.Add(categoria2);
            categorias.Add(categoria3);
            categorias.Add(categoria4);
            categorias.Add(categoria5);

            List<Producto> CategoriaEspecifico(List<Producto> lista,int categoria)
            {

                var listaFiltrada = from x in lista where x.CategoriaId == categoria  select x;



                return listaFiltrada.ToList();
            }

            List<Producto> PorPrecios(List<Producto> lista)
            {

                var listaFiltrada = from x in lista where x.Precio >= 3000 && x.Precio <=5000 orderby x.Precio  select x;



                return listaFiltrada.ToList();
            }
            
            List<string> NombresCategorias(List<Producto> listaproductos, List<Categoria>listacategorias)
            {

                var listaFiltrada = from x in listaproductos group x by x.CategoriaId into xg join y in listacategorias on xg.Key equals y.Id select y.Nombre.ToString();

                return listaFiltrada.ToList();
            }

            Console.WriteLine("Por categoria:");
            foreach(Producto x in CategoriaEspecifico(productos,3))
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Nombre);
                Console.WriteLine(x.CategoriaId);
                Console.WriteLine(x.Marca);
                Console.WriteLine(x.Modelo);
                Console.WriteLine(x.Precio);
                Console.WriteLine();


            }

            Console.WriteLine("Por precios entre 3000 y 5000:");
            foreach (Producto x in PorPrecios(productos))
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Nombre);
                Console.WriteLine(x.CategoriaId);
                Console.WriteLine(x.Marca);
                Console.WriteLine(x.Modelo);
                Console.WriteLine(x.Precio);
                Console.WriteLine();


            }


            Console.WriteLine("Nombres de categorias");
            foreach (string x in NombresCategorias(productos,categorias))
            {
                
                Console.WriteLine(x);
                Console.WriteLine();


            }








        }
    }
}
