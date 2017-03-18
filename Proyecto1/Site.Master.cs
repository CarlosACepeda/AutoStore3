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

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioBLL Login = new UsuarioBLL();
            if (Login.Autenticar(TxtNombre.Text, TxtContraseña.Text) == 1)//Si es 1 es Admin
            {
                Session["UserLogin"] = TxtNombre.Text;
                usuarioEstaLogueado = 1;
                RevisarLoginUser();
                
             }
            else if(Login.Autenticar(TxtNombre.Text, TxtContraseña.Text) == 2)//Si es 2 es User.
            {
                Session["UserLogin"] = TxtNombre.Text;
                usuarioEstaLogueado = 2;
                RevisarLoginUser();
            }
            else //Si no, fue que hubo un error al login
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

        public void RevisarLoginUser()
        {
            if (usuarioEstaLogueado==1)
            {
                BtnRegistrarse.Visible = false;
                BtnRegistrarse.Enabled = false;
                BtnGestionar.Enabled = true;
                BtnGestionar.Visible = true;
                btnShow.Visible = false;
                btnShow.Enabled = false;
                BtnConfigurarPerfil.Visible = false;
                BtnConfigurarPerfil.Enabled = false;
                BtnSubirProducto.Enabled = false;
                BtnSubirProducto.Visible=false;
                
            }
            else if(usuarioEstaLogueado==2)
            {
                BtnRegistrarse.Visible = false;
                BtnRegistrarse.Enabled = false;
                btnShow.Visible = false;
                btnShow.Enabled = false;
                BtnGestionar.Enabled = false;
                BtnGestionar.Visible = false;
                BtnConfigurarPerfil.Visible = true;
                BtnConfigurarPerfil.Enabled = true;
                BtnSubirProducto.Visible = true;
                BtnSubirProducto.Enabled = true;

            }
            else
            {
                btnShow.Visible = true;
                BtnRegistrarse.Visible = true;
                BtnGestionar.Enabled = false;
                BtnGestionar.Visible = false;
                BtnConfigurarPerfil.Enabled = false;
                BtnConfigurarPerfil.Visible = false;
                BtnSubirProducto.Enabled = false;
                BtnSubirProducto.Visible = false;


            }
        }

        //Click de los botones

        protected void cerrarLogin_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarRegistro_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarConfigurar_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }
        protected void cerrarGestionar_Click(object sender, EventArgs e)
        {
            RevisarLoginUser();
        }

        protected void BtnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionarUsuarios.aspx");
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
            Response.Redirect("EliminarProducto.aspx");
        }

        protected void BtnSubirProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("PublicarProducto.aspx");
        }


    }
}

