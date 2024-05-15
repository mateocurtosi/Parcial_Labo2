using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtosi.Mateo._23
{
    public class Consulta
    {
        DateTime fecha;
        Paciente paciente;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }    
        }

        public Paciente Paciente
        {
            get
            {
                return paciente;
            }
        }

        Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{fecha} se ha atendido a {paciente.FichaExtra}");
            return sb.ToString() ;
        }
    }
}
