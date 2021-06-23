using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadoSimpleUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto(5, " la zapatilla de Agustin ");
            miProducto.FuncionParaMostarDelegada += mostrarShowDialog;
            miProducto.MostrarProducto();
            miProducto.Descripcion = "nad";
        }

        private string mostrarShowDialog(Producto producto)
        {
            MessageBox.Show(producto.Cantidad.ToString() + producto.Descripcion);
            return "mostrar";
        }
    }
}
