using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas_de_clases
{
    public abstract class Mascota
    {
        string nombre;
        string raza;

        protected Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }


        public string Nombre
        {
            get{return nombre;}
        }

        public string Raza
        {
            get { return raza;}
        }
        //Ultimos cambios la codigo dasdas dasdasdasd ad asasd as
    }


}
