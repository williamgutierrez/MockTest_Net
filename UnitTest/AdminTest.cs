using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Moq;
using System.Collections.Generic;


namespace UnitTest
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void ValidarToken_test()
        {
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(x => x.Validar(It.IsAny<string>()));

            Admin admin = new Admin("aa","11",mockServicio.Object);
            Assert.IsNotNull(admin);


        }
        [TestMethod]
        public void GetAlumnoCount() {
            List<Alumno> ListaAlumno = new List<Alumno>();
            ListaAlumno.Add(new Alumno() { Ci=123, Nombre="juan"});
            ListaAlumno.Add(new Alumno() { Ci=159, Nombre="Pedro"});
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g => g.GetAlumno()).Returns(ListaAlumno);
            Console.WriteLine("hols fomo esas");
            
            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Assert.AreEqual(2, admin.GetNotas().Count);

        }

        [TestMethod]
        public void GetNotas_test()
        {
            List<Alumno> ListaAlumno = new List<Alumno>();
            ListaAlumno.Add(new Alumno() { Ci =123, Nombre="juan" });
            ListaAlumno.Add(new Alumno() { Ci=159, Nombre="Pedro" });
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g => g.GetAlumno()).Returns(ListaAlumno);
            mockServicio.Setup(n => n.GetNota(It.IsAny<int>())).Returns(50);

            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Assert.AreEqual(2, admin.GetNotas().Count);

        }   
        [TestMethod]
        public void AlumnoNotaCero_Test()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno.Add(new Alumno(){ Ci = 500, Nombre = "Richard", Nota =25});
            Console.WriteLine(listaAlumno);
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g=> g.GetAlumno()).Returns(listaAlumno);
            mockServicio.Setup(n=> n.GetNota(It.IsAny<int>())).Returns(0);

            Admin admin = new Admin("claudio", "123", mockServicio.Object);
            Console.WriteLine(admin.GetNotas()[0].Nota);
           
            Assert.AreEqual(0, admin.GetNotas()[0].Nota);

            
        }
       [TestMethod]
        public void GetEstado_Test() {
            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno.Add(new Alumno() { Ci = 500, Nombre = "Richard" });
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g => g.GetAlumno()).Returns(listaAlumno);
            mockServicio.Setup(n => n.getEstadoAlumno(It.IsAny<int>())).Returns("Aprobado");
           
            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Console.WriteLine(admin.GetEstadoAlumno()[0].estado);
            Assert.AreEqual("Aprobado", admin.GetEstadoAlumno()[0].estado);
        }
     
    }
}
