using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Enitdades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Alumno()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}
