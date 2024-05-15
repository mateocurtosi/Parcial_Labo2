using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtosi.Mateo._23
{
    public class Paciente : Persona
    {
        string diagnostico;
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
      
        }

        public string Diagostico
        {
            get
            {
                return diagnostico;
            }
            set 
            {
                diagnostico = value;
            }
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en :{barrioRecidencia}");
            sb.AppendLine($"{diagnostico}");
            sb.AppendLine($"Nombre : {nombre} Apellido : {apellido}");
            sb.AppendLine($"Nacimiento : {nacimiento}");
            return sb.ToString();
        }
    }
}
