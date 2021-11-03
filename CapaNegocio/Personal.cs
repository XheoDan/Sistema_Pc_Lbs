using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Personal
    {
        // declaracion de atributos 
        private string apellidos;
        private string nombres;
        private string telefono;


        //propiedades para los atributos 
        //propiedades de lectura GET - GETTER
        //propiedades de escritura SET - SETTER 
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }



        //declaracion de metedodos u operaciones
        public string Trabajar()
        {
            return "Este metodo recien sera implementado ";
        }
        public string Colaborar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Gestionar()
        {
            return "Este metodo recien sera implementado";
        }
    }
}
