﻿using System;
using System.Data.Entity;
using Proyecto1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AutoStoreUnitTest1
{
    [TestClass]
    public class AutoStoreUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (AutoStoreContext contexto = new AutoStoreContext())
            {
                var persona = contexto.Persona.ToList();
                Assert.AreEqual(persona.Count, 0);
            }
        }
    }
}
