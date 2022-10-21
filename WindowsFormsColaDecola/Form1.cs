using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsColaDecola
{
    public partial class Form1 : Form
    {
        Cola cola;
        public Form1()
        {
            cola = new Cola(4);
            InitializeComponent();
        }

        private void btninsertardetras_Click(object sender, EventArgs e)
        {
            int dato=int.Parse(txtdato.Text);
            cola.InsertarItemsDetras(dato);
            cola.ListarItems(colalista);
        }

        private void eliminardetras_Click(object sender, EventArgs e)
        {
            cola.EliminarItemsDetras();
            cola.ListarItems(colalista);
        }

        private void btninsertardelante_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtdato.Text);
            cola.InsertarItemsDelate(dato);
            cola.ListarItems(colalista);
        }

        private void btneliminardelante_Click(object sender, EventArgs e)
        {
            cola.EliminarItemsDelante();
            cola.ListarItems(colalista);
        }
    }
}
