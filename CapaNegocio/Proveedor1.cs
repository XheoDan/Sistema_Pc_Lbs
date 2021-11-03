using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor1
    {
        //declaracion de atributos 
        public string nombres;
        public string telefono;
        public string correo;
        public string horarioAtencion;
        public string direccion;
        //propiedades  para los atributos
        // propiedades de lectura  get- getter
        // propiedades de escritura set - setter
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
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string HorarioAtencion
        {
            get { return horarioAtencion; }
            set { horarioAtencion = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        // declaracion de metodos y operaciones
        public string Vender()
        {
            return "Este metodo  recien sera implementado n_n";
        }
        public string Proveer()
        {
            return "Este nmetodo recien sera implementado n_n";
        }
        public string Archivar()
        {
            return " Este metodo recien sera implemtado n_n";
        }
        public string Cobrar()
        {
            return "Este metodo recien sera implemtado n_n";
        }
        public string Enviar()
        {
            return "Este metodo recien sera implemtado n_n";
        }

    }
}