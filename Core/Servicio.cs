using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Servicio : IServicio
    {
        Random rnd = new Random();
        public List<Alumno> GetAlumno()
        {
           
            List<Alumno> result = new List<Alumno>();
            result.Add(new Alumno() { Ci = 642, Nombre = "Andres calamaro" ,Nota =30});
            result.Add(new Alumno() { Ci = 123, Nombre = "william peres",Nota =50 });
            result.Add(new Alumno() { Ci = 456, Nombre = "francisco calvo",Nota=35 });
            result.Add(new Alumno() { Ci = 789, Nombre = "Carmen rosa",Nota =45 });
            result.Add(new Alumno() { Ci = 159, Nombre = "Alberto gomex",Nota = 39 });
            result.Add(new Alumno() { Ci = 500, Nombre = "Rodrigo rojas",Nota = 69 });
            return result;
            //throw new NotImplementedException();
        }

        public int GetNota(int CI)
        {
            int nota = rnd.Next(1, 100);
            if (CI == 500)
            {
                Console.WriteLine("CI get nota=> "+CI);
                nota = 0;
            }

            return nota;

          //  throw new NotImplementedException();
        }
        public string getEstadoAlumno(int nota)
        {
          string estado = "Reprobado";
            if (nota >= 50)
            {
                estado = "Aprobado";
            }

            return estado;
        }



        public void Validar(string token)
        {
            if (string.IsNullOrEmpty(token)) {
                throw new Exception("token invalido");
            }
            //throw new NotImplementedException();
        }
       

    }
}
