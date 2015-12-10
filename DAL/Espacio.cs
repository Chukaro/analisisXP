using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Espacio
    {
        private int idEspacio;
        private int estado;

        public int IdEspacio
        {
            get { return idEspacio; }
            set { idEspacio = value; }
        }
        

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
