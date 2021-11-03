using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Componente componente = new Componente();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //leer datos
            string codigo = txtCodigo.Text.Trim();
            string tipo = txtTipo.Text.Trim();
            string precio = txtPrecio.Text.Trim();
            string tamanio = txtTamanio.Text.Trim();
            string fabricante = txtFabricante.Text.Trim();
            // Esccribir los datos del docente en el objeto

            componente.Codigo = codigo;
            componente.Tipo = tipo;
            componente.Precio = precio;
            componente.Tamanio = tamanio;
            componente.Fabricante = fabricante;

            // confirmar que se a escrito en el objeto 
            MessageBox.Show("Se a escrito correctamente el objeto");
            // limpiarlas cajas de texto 
            txtCodigo.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtTamanio.Clear();
            txtFabricante.Clear();

            // el cursor de texto aparecera en un cuadrito
            txtCodigo.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // leer las propiedades del objeto
            string codigo = componente.Codigo;
            string tipo = componente.Tipo;
            string precio = componente.Precio;
            string tamanio = componente.Tamanio;
            string fabricante  = componente.Fabricante;
            // te respondera con el siguiente mensaje
            MessageBox.Show("Datos del Proveedor:  " + "\n" + "\n" + "Codigo:  " + codigo + "\n" +
                "Tipo:  " + tipo + "\n" + "Precio:  " + precio + "\n" + "Tamanio:  " +
                tamanio + "\n" + "Fabricante:  " + fabricante);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(componente.Funcionar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.Encender());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.Apagar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.Ordenar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(componente.Procesar());
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
