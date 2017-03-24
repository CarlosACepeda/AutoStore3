using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class RecuperarPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void btnEnviarC_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL pass = new UsuarioBLL();
                string elMensaje =
                    "Hola, tu password es " + pass.TraerPassword(txtCorreo.Text) + " vuelve a iniciar sesión.";
                //La cadena "servidor" es el servidor de correo que enviará tu mensaje
                string servidor = "smtp.gmail.com";
                // Crea el mensaje estableciendo quién lo manda y quién lo recibe
                MailMessage mensaje = new MailMessage(
                    "carlosalt5125@gmail.com",
                    txtCorreo.Text,
                    "Recupera tu password",
                    elMensaje
                    );


                //Envía el mensaje.
                SmtpClient cliente = new SmtpClient(servidor);
                //Añade credenciales si el servidor lo requiere.
                cliente.Credentials = new System.Net.NetworkCredential("carlosalt5125@gmail.com", "56114281");
                cliente.Port = 587;
                cliente.Host = "smtp.gmail.com";
                cliente.EnableSsl = true;
                cliente.Send(mensaje);
                lblMensaje.Text = "Listo, mira tu correo para tu contraseña";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Visible = true;
            }
            
            catch
            {
                lblMensaje.Text = "El correo ingresado no coincide con nuestros registros.";
                lblMensaje.Visible = true;
            }
        }
    }
}