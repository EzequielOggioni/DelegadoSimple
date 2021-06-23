using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate string MostrarProductoDelegate(Producto p);
    public class Producto
    {
        public MostrarProductoDelegate FuncionParaMostarDelegada;
        private int cantidad;
        private string descripcion;

        public Producto(int cantidad, string descripcion)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }
        string valor;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;
                if(value != "")
                    valor=   FuncionParaMostarDelegada(this);
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public void MostrarProducto()
        {
          if(FuncionParaMostarDelegada != null)
                valor = FuncionParaMostarDelegada(this);

        }

    }
}
