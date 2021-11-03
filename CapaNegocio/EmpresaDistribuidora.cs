using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EmpresaDistribuidora
    {
        // declaracion de atributos
        private string nombres;
        private string ubicacion;
        private string mediosDistribucion;
        private string telefono;
        private string horarioAtencion;

        //propiedades para los atributos
        //propiedades de lectura GET - GETTER
        //propiedades de escritura SET - SETTER 

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
        public string MediosDistribucion
        {
            get { return mediosDistribucion; }
            set { mediosDistribucion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string HorarioAtencion
        {
            get { return horarioAtencion; }
            set { horarioAtencion = value; }
        }
        //declaracion de metodos y operaciones 
        public string Entregar()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string Almacenar()
        {
            return "Este metodo recien sera  definido =_=";
        }
        public string Transportar()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string ResgistrarEnvio()
        {
            return "Este metodo recien sera definido =_=";
        }
        public string RegistrarEntrega()
        {
            return "Este metodo recien sera definido =_=";
        }
    }
}