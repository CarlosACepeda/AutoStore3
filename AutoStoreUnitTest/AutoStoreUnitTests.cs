using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using Proyecto1.Models;

namespace AutoStoreUnitTest
{
    [TestClass]
    public class AutoStoreUnitTests
    {
        [TestMethod]
        public void AutoStoreUnitTest()
        {
            using (AutoStoreContext contexto = new AutoStoreContext())
            {
                var persona = contexto.Rol.ToList();
                Assert.AreEqual(persona.Count, 0);

            }
        }
    }
}
