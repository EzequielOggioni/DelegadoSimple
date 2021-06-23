using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoSimpleConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto miProducto = new Producto( 5, " la zapatilla de Agustin ");

            miProducto.FuncionParaMostarDelegada += mostrar;
            miProducto.MostrarProducto();

            Console.ReadLine();

        }

        static string mostrar(Producto producto)
        {
            Console.WriteLine( $" cantidad {producto.Cantidad}, nombre: {producto.Descripcion}  "  );
            return "mostrar";
        }

        static string mostrar2(Producto producto)
        {
            //Console.WriteLine($" cantidad {producto.Cantidad}, nombre: {producto.Descripcion}  ");
            return "mostrar2";
        }

    }
}
