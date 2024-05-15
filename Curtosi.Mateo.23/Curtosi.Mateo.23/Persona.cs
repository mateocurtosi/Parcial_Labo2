using System.Collections.Specialized;
using System.Text;

namespace Curtosi.Mateo._23
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;


        public string NombreCompleto 
        {
            get
            {
                return apellido + nombre ;  
            }
        }
        public int Edad
        {
            get 
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public Persona (string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : this(nombre,apellido,nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }
        public override string ToString()
        {
            return apellido + nombre;
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{apellido} ,  {nombre}");
            sb.AppendLine($"EDAD : {Edad}");
            sb.AppendLine($"{nacimiento}");
            sb.AppendLine($"{barrioRecidencia}");
            return sb.ToString();
        }

        public abstract string FichaExtra();
        
        
    }
}
