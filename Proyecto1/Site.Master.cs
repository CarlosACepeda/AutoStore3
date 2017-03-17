using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class SiteMaster : MasterPage
    {
        public static int? usuarioEstaLogueado;
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // El código siguiente ayuda a proteger frente a ataques XSRF
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Utilizar el token Anti-XSRF de la cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generar un nuevo token Anti-XSRF y guardarlo en la cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Establecer token Anti-XSRF
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validar el token Anti-XSRF
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Error de validación del token Anti-XSRF.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            RevisarLoginUser();
            if (usuarioEstaLogueado == null)
            {
                //Estos botones no estarán disponibles hasta que el usuario Inicie Sesión.
                //Configuración Perfil.
                BtnConfigurarPerfil.Visible = false;
                BtnConfigurarPerfil.Enabled = false;
                //Subir Producto.
                BtnPublicarProducto.Visible = false;
                BtnPublicarProducto.Enabled = false;
                //Gestionar...
                BtnGestionar.Enabled = false;
                BtnGestionar.Visible = false;

                //Gestinar Marcas
                btnGestionarMarcas.Enabled = false;
                btnGestionarMarcas.Visible = false;
                //GestionarModelos
                BtnGestionarModelos.Enabled = false;
                BtnGestionarModelos.Visible = false;
                //Gestionar Fabricantes
                BtnGestionarFabricantes.Enabled = false;
                BtnGestionarFabricantes.Visible = false;
                //Gestionar Usuarios
                BtnGestionarUsuarios.Enabled = false;
                BtnGestionarUsuarios.Visible = false;
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        {

            UsuarioBLL Login = new UsuarioBLL();
            if (Login.Autenticar(TxtNombre.Text, TxtContraseña.Text) != 0)
            {
                if (Login.Autenticar(TxtNombre.Text, TxtContraseña.Text) == 1)//Si es administrador
                {
                    Session["UserLogin"] = TxtNombre.Text;
                    MostrarBotonesParaAdministrador();
                    usuarioEstaLogueado = 1;
                }

                else if (Login.Autenticar(TxtNombre.Text, TxtContraseña.Text) == 2)//Si es usuario
                {
                    Session["UserLogin"] = TxtNombre.Text;
                    MostrarBotonesParaUser();
                    usuarioEstaLogueado = 2;
                }
            }
            else
            {
                LblIncorrecto.Visible = true;
            }
        }
        public void botonRegistrarse_Click(object sender, EventArgs e)
        {
            Guid nuevo_id = Guid.NewGuid();
            UsuarioBLL registrarUsr = new UsuarioBLL();
            PersonaBLL registrarPer = new PersonaBLL();

            registrarUsr.CrearUsuario(
                nuevo_id,
                InputUsuario.Text,
                InputContraseña.Text,
               "No hay foto disponible",
                2
                );
            registrarPer.CrearPersona(
                nuevo_id,
                InputNombre.Text,
                InputApellido.Text,
                InputDireccion.Text,
            Int64.Parse(InputTelefono.Text),
                InputCorreoE.Text
                );

        }
        public void MostrarBotonesParaAdministrador()
        {
            BtnGestionar.Enabled = true;
            BtnGestionar.Visible = true;

            //Gestinar Marcas
            btnGestionarMarcas.Enabled = true;
            btnGestionarMarcas.Visible = true;
            //GestionarModelos
            BtnGestionarModelos.Enabled = true;
            BtnGestionarModelos.Visible = true;
            //Gestionar Fabricantes
            BtnGestionarFabricantes.Enabled = true;
            BtnGestionarFabricantes.Visible = true;
            //Gestionar Usuarios
            BtnGestionarUsuarios.Enabled = true;
            BtnGestionarUsuarios.Visible = true;
            BtnIniciarSesion.Enabled = false;
            BtnRegistrarse.Enabled = false;
            btnShow.Enabled = false;
            btnShow.Visible = false;
            BtnIniciarSesion.Visible = true;
            BtnRegistrarse.Visible = false;

        }
        public void MostrarBotonesParaUser()
        {

            BtnConfigurarPerfil.Visible = true;
            BtnConfigurarPerfil.Enabled = true;
            //Subir Producto.
            BtnPublicarProducto.Visible = true;
            BtnPublicarProducto.Enabled = true;
            //Quitar botones de Login y Registro y Gestionar
            BtnIniciarSesion.Enabled = false;
            BtnRegistrarse.Enabled = false;
            BtnIniciarSesion.Visible = true;
            BtnRegistrarse.Visible = false;
            btnShow.Enabled = false;
            btnShow.Visible = false;
            BtnGestionar.Enabled = false;
            BtnGestionar.Visible = false;
        }
        public void RevisarLoginUser()
        {
            if (usuarioEstaLogueado == 1)
            {
                MostrarBotonesParaAdministrador();
            }
            else if (usuarioEstaLogueado == 2)
            {
                MostrarBotonesParaUser();
            }
        }
        protected void cerrarLogin_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();   
        }
        protected void cerrarRegistro_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarGestionar_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarConfiguracionPerfil_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarPublicarProd_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void BtnGestionarUsuarios_Click(object sender, EventArgs e)
        {

        }
        protected void BtnGestionarProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarProductos.aspx");
        }
        protected void BtnGestionarProductos_Click1(object sender, EventArgs e)
        {
            Response.Redirect("GestionarProductos.aspx");

        }
        protected void BtnGestionarFabricantes_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarFabricantes.aspx");

        }
        protected void BtnGestionarCategorias_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarCategorias.aspx");

        }
        protected void BtnGestionarModelos_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarModelos.aspx");

        }
        protected void btnGestionarMarcas_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarMarcas.aspx");

        }
        protected void BtnEditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarPerfil.aspx");

        }
        protected void BtnVerOrden_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerOrden.aspx");

        }
        protected void BtnEliminarProducto_Click(object sender, EventArgs e)
        {

        }
        protected void BtnPublicarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}

