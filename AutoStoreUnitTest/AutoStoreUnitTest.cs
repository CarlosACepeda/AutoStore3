using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoStoreUnitTest
{
    [TestClass]
    public class AutoStoreUnitTest
    {
        public TestContext testContext { get; set; }

        [TestInitialize]
        public void Init()
        {
            var appDataDir = this.testContext.DeploymentDirectory;
            AppDomain.CurrentDomain.SetData("Data Directory", appDataDir);
        }

        [TestMethod]
        public string ObtenerRol(Guid idUsuario)
        {
            return "";
        }
    }
}
