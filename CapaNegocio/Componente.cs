using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Componente
    {
        // declaracion de atributos 
        private string codigo;
        private string tipo;
        private string precio;
        private string tamanio;
        private string fabricante;
        // propiedades para los atributos
        //propiedades de lectura GET - GETTER
        // propiedades de escritura SET-SETTER

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        // declaracion de metodos u operaciones
        public string Funcionar()
        {
            return "Este metodo recien sera implementado w_w";
        }
        public string Encender()
        {
            return "Este metodo recien sera implementado w_w";
        }
        public string Apagar()
        {
            return "Este metodo recien sera implemtado W_W";
        }
        public string Ordenar()
        {
            return "Este metodo recien sera implementado W_W";
        }
        public string Procesar()
        {
            return "Este metodo recien sera implementado W_W";
        }
    }
}
