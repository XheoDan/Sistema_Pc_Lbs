using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefeAlmacen : Personal
    {
        //declaracion de atributos
        public string almacenesCargo;
        public string ubicacionAlmacen;

        // propiedades para los atributos
        // propiedades de lectura get - getter
        // propiedades de escritura set - setter 
        public string AlmacenesCargo
        {
            get { return almacenesCargo; }
            set { almacenesCargo = value; }
        }
        public string UbicacionAlmacen
        {
            get { return ubicacionAlmacen; }
            set { ubicacionAlmacen = value; }
        }
        // declaracion de metodos u operaciones 
        public string Administrar()
        {
            return "Este metodo recien sera definido :c ";
        }
        public string Registrar()
        {
            return "Este metodo recien sera implementado  :c ";
        }
    }
}