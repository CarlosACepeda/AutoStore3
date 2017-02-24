using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Linq;
using Proyecto1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (AutoStoreContext contexto = new AutoStoreContext())
            {
                var fabricanteCarro = contexto.FabricanteCarro.ToList();
                Assert.AreEqual(fabricanteCarro.Count, 10);
            }
        }
        
       
    }
}
