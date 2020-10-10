using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        DArticulo art = new DArticulo();

        [TestMethod]
        public void Test_IdArticulo()
        {
            bool restriccion;
            string expresion=@"[A-Za-z0-9]";
            int valor;
            valor = art.IdArticulo;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_Nombre()
        {
            bool restriccion;
            string expresion = @"[a-zA-Z]";
            string valor;
            valor = art.Nombre;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_Codigo()
        {
            bool restriccion;
            string expresion = @"[a-zA-Z]";
            string valor;
            valor = art.Codigo;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_Descripcion()
        {
            bool restriccion;
            string expresion = @"[a-z]";
            string valor;
            valor = art.Descripcion;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor);
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_IdCategoria()
        {
            bool restriccion;
            string expresion = @"[0-9]";
            int valor;
            valor = art.IdCategoria;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_IdPresentacion()
        {
            bool restriccion;
            string expresion = @"[0-9]";
            int valor;
            valor = art.IdPresentacion;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }

        [TestMethod]
        public void Test_TextBuscar()
        {
            bool restriccion;
            string expresion = @"[a-z]";
            string valor;
            valor = art.TextoBuscar;
            System.Text.RegularExpressions.Regex re = new Regex(expresion);
            restriccion = re.IsMatch(valor.ToString());
            Assert.AreEqual(restriccion, true);
        }







    }
}
