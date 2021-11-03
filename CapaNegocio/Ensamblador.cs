using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ensamblador : Personal
    {
        //declaracion de atributos
        public string sOInstalar;
        public string versionSO;

        // propiedades para los atributos
        // propiedades de lectura get - getter
        // propiedades de escritura set - setter 
        public string SOInstalar
        {
            get { return sOInstalar; }
            set { sOInstalar = value; }
        }
        public string VersionSO
        {
            get { return versionSO; }
            set { versionSO = value; }
        }
        // declaracion de metodos u operaciones 
        public string Ensamblar()
        {
            return "Este metodo recien sera definido :c ";
        }
        public string Verificar()
        {
            return "Este metodo recien sera implementado  :c ";
        }
    }
}