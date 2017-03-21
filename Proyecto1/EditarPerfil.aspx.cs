using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Models;
using Proyecto1.Logica;
using System.IO;

namespace Proyecto1
{
    public partial class EditarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMaster.usuarioEstaLogueado = 2;
            CargarInfoDeUsuario();
        }
        protected void CargarInfoDeUsuario()
        {
            UsuarioBLL persona = new UsuarioBLL();
            persona.MostrarInformacion();

            Persona personita = new Persona();
            Usuario user = new Usuario();


            user = persona.MostrarInformacion();
            personita = persona.TraerPersona();

            txtNombre.Text = personita.Nombre;
            txtApellido.Text = personita.Apellido;
            txtDireccion.Text = personita.Direccion;
            txtTelefono.Text = personita.Telefono.ToString();
            txtCorreo.Text = personita.Email;

            txtUsuario.Text = user.NombreUsuario;
            txtClave.Text = user.Contrasena;

        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            UsuarioBLL usr = new UsuarioBLL();
            PersonaBLL pers = new PersonaBLL();
            Guid idUser = Guid.Parse(usr.TraerIdDeUsuarioLogueado().ToString());
            byte[] imagen = null;
            Guid idProducto = Guid.NewGuid();

            //Si el FileUpload tiene un archivo.
            if (FileUpload1.HasFile)
            {
                using (BinaryReader lector = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    imagen = lector.ReadBytes(FileUpload1.PostedFile.ContentLength);

                }

            }
            //LLenar un objeto usuario con los campos llenos con los textbox.
            Usuario usuario = new Usuario
            {
                IdUsuario = idUser,
                NombreUsuario = txtNombre.Text,
                Contrasena = txtClave.Text,
                Foto = imagen              

            };
            Persona per = new Persona
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = Int64.Parse(txtTelefono.Text),
                Email = txtCorreo.Text
            };
            //Mandar el parámetro 'Usuario' con los campos llenos al método EditarUsuario y ejecutar la funcionalidad.
                usr.EditarUsuario(usuario);
            //Mandar el parámetro 'Persona con los campos llenos al método EditarPerfil
                pers.EditarPerfil(per);

        }
    }
}