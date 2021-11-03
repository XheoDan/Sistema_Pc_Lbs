using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Almacen
    {
        // delcaracion de atributos 
        private string nombres;
        private string ubicacion;
        private string tamanio;
        private string personalEncargado;
        private string horarioAtencion;

        // propiedades para los atributos 
        // propiedades de lectura  GET - GETTER
        // porpiedades de escritura SET - SETTER 
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }
        public string PersonalEncargado
        {
            get { return personalEncargado; }
            set { personalEncargado = value; }
        }
        public string HorarioAtencion
        {
            get { return horarioAtencion; }
            set { horarioAtencion = value; }
        }
        //declaracion de metodos u operaciones 
        public string Almacenar()
        {
            return "Este metodo recien sera implementado :)";
        }
        public string ResgistrarProducto()
        {
            return " Este metodo  recien sera implementado :)";
        }
        public string ManternerProducto()
        {
            return "Este metodo recien sera implementado :)";
        }
        public string Gestionar()
        {
            return " Este metodo recien sera implementado :)";
        }
        public string Custodir()
        {
            return "Este metodo recien sera implentado :)";
        }
    }
}
