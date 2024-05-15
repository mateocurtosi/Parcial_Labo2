using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtosi.Mateo._23
{
    public class PersonalMedico : Persona
    {
        List<Consulta> consultas;
        bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.consultas = consultas;
            this.esResidente = esResidente;
        }


         public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizo residencia?{esResidente}");
            sb.AppendLine("ATENCIONES : ");
            foreach (var consulta in consultas)
            {        
                    sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
           
        }

        public static implicit operator string(PersonalMedico v)
        {
            throw new NotImplementedException();
        }
        //public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        //{
        //    consultas.Add(Consulta);
        //    return Consulta
        //}

    }
}
