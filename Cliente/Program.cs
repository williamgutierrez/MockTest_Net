using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            IServicio servi = new Servicio();
            Admin admin;
            try
            {
                admin = new Admin("claudio", "123", servi);
                List<Alumno> ListaNotas = admin.GetEstadoAlumno();

                foreach (var item in ListaNotas) {
                    
                   Console.WriteLine("CI:{0} - Nombre:{1} - Nota:{2} - Estado:{3}", item.Ci, item.Nombre, item.Nota, item.estado);

                }

           /*    ListaNotas = admin.GetNotas();

                foreach (var item in ListaNotas)
                {
                    Console.WriteLine("11CI:{0} - Nombre:{1} - Nota:{2} - Estado:{3}", item.Ci, item.Nombre, item.Nota, item.estado);

                }

    */

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
           

            Console.WriteLine("=====================================");
            Console.ReadKey();

        }
    }
}
