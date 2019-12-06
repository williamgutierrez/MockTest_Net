using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Admin
    {
        List<Alumno> ListaAlumno;
        List<Alumno> listAlumnosNotasCero;
        string token;
        IServicio serv;

        public Admin(string user, string password, IServicio serv)
        {
            if (user == "claudio" && password == "123") {
                token = "Token _valid";

            }
            serv.Validar(token);
            this.serv = serv;

        }

        public List<Alumno> GetNotas() {
            //serv.Validar(token);
            ListaAlumno = serv.GetAlumno();
            
            foreach (var alumno in ListaAlumno) {
              
                alumno.Nota = serv.GetNota(alumno.Ci);  
            }
            return ListaAlumno;

        }
        public List<Alumno> GetEstadoAlumno() {

             listAlumnosNotasCero = serv.GetAlumno();
            
            foreach (var alumno in listAlumnosNotasCero) {
                alumno.Nota = serv.GetNota(alumno.Ci);
                alumno.estado = serv.getEstadoAlumno(alumno.Nota);
                //Console.WriteLine("=> "+alumno.Ci +"nota "+alumno.Nota +"estado=>"+alumno.estado);
            }

            return listAlumnosNotasCero;
        }

    }
}
