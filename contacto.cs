using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_en_clase
{
    internal class contacto : persona
    {
        private string telefono;       

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }

        public contacto() : base()
        {
            telefono = string.Empty;
        }


        public contacto(string nombre, DateTime? fechaNacimiento, string telefono) : base(nombre, fechaNacimiento) => this.telefono = telefono;

        public override string ToString()
        {
            return base.ToString() + " " + telefono;
        }    
    }
}
