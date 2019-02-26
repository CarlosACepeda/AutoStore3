using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Models;
using System.Data.Entity;

namespace Proyecto1.Logica.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void MostrarInformacionTest(Guid idUser)
        {
            Guid numero = new Guid("c64e12cf-3aef-4b94-8020-e2e2c36d846e");
            try
            {
                AutoStoreContext context = new AutoStoreContext();
                var mostrarInfo = from usr in context.Usuario
                                  where usr.IdUsuario == numero
                                  select usr;
                Assert.AreEqual("c64e12cf-3aef-4b94-8020-e2e2c36d846e", mostrarInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}