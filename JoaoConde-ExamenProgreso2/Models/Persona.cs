using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoaoConde_ExamenProgreso2.Models
{
    public class Persona
    {
        public Persona() {
            ID = 0;
            Nombre = "";
            Telefono = "";
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
