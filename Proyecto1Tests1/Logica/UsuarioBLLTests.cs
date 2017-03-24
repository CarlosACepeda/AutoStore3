using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Models;
using System.Data.Entity;
using System.Web;

namespace Proyecto1.Logica.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void AutenticarTest()
        {
                string nombre = "Carlos";
                string clave = "Loca";
                int expected=0;
                int actual;
                
                AutoStoreContext context = new AutoStoreContext();
                {
                    var mostrarInfo = from usr in context.Usuario
                                      where usr.NombreUsuario == nombre && usr.Contrasena == clave
                                      select usr;
                    //Buscar el Rol del Usuario que se loguea.
                    var rolId = from usr in context.Usuario
                                where usr.NombreUsuario == nombre
                                select usr.RolID;


                    //Este if confirma si hay un usuario en la Base de Datos.
                    if (mostrarInfo.Count() == 0)
                    {
                        actual= 0; //0 vale a 'No hay usuarios'
                    }

                    //Si se encuentra un usuario, compara el id de ese usuario.
                    else if (rolId.FirstOrDefault().Equals(1))
                    {
                        //Y se activa un estado de sesión para Administrador.
                        HttpContext.Current.Session["AdminLogin"] = 1;
                        ///Si el Rol es 1 entonces es Administrador.
                        actual= 1;

                    }
                    else
                    {
                        //Si el rol es 2 entonces es Usuario
                        actual= 2;
                    }
                Assert.AreEqual(expected == 1 || expected == 2, actual);
            }
            
        }
    }
}