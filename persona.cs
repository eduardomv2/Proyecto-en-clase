using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_en_clase
{
    internal class persona
    {
        
		protected String nombre;
        protected DateTime? fechaNacimiento;


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {              
                int edad = DateTime.Today.Year - fechaNacimiento.Value.Year;
                if (fechaNacimiento > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }          
                int[] arregloEdad = new int[] { edad };                           
                return edad;
            }

        }
        public persona()
        {
            nombre = String.Empty;
            fechaNacimiento = null;//DateTime.MinValue;
        }
        public persona(String nombre, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return nombre.ToUpper() + " " + Edad;
        }
        

    }
}

