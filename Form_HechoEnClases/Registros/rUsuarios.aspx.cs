using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Form_HechoEnClases.Registros
{
    public partial class rUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxID.Text = String.Empty;
            TextBoxUsername.Text = String.Empty;
            TextBoxPassword.Text = String.Empty;
            TextBoxConfirmacion.Text = String.Empty;
            TextBoxFecha.Text = String.Empty;
            TextBoxNombre.Text = String.Empty;
            TextBoxComentario.Text = String.Empty;
        }

        protected void ButtonBuscar_Click1(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> u = new RepositorioBase<Usuarios>();
            int ID = int.Parse(TextBoxID.Text);
            Usuarios usuario = new Usuarios();

            usuario = u.Buscar(ID);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Encontrado");
                search(usuario);
            }
            else
            {
                MessageBox.Show("Usuario No encontado");
            }
        }

        private void search(Usuarios usuario)
        {
            TextBoxNombre.Text = usuario.Nombre;
            TextBoxUsername.Text = usuario.Username;
            TextBoxPassword.Text = usuario.Password;
            TextBoxFecha.Text = usuario.Fecha.ToString();
            TextBoxComentario.Text = usuario.Comentario;
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> u = new RepositorioBase<Usuarios>();
            int ID;
            int.TryParse(TextBoxID.Text, out ID);
            Usuarios usuario = u.Buscar(ID);

            if (TextBoxNombre.Text == String.Empty || TextBoxUsername.Text == String.Empty
                   || TextBoxPassword.Text == String.Empty || TextBoxConfirmacion.Text == String.Empty
                   || TextBoxFecha.Text == String.Empty || TextBoxNombre.Text == String.Empty
                   || TextBoxComentario.Text == String.Empty)
                MessageBox.Show("Solo el ID se puede dejar vacio");
            else if (usuario == null)
            {
                Usuarios us = LlenarClase();
                if (TextBoxPassword.Text == TextBoxConfirmacion.Text)
                {
                    if (u.Guardar(us))
                        MessageBox.Show("Usuario Guardado");
                    else if (!u.Guardar(us))
                        MessageBox.Show("Este Usuario No Pudo Ser Guardado");
                    ClearAll();
                }
                else if (TextBoxPassword.Text != TextBoxConfirmacion.Text)
                {
                    MessageBox.Show("La contraseña y la confirmacion no son iguales");
                }
            }
            else
            {
                edit(usuario);
                if (u.Modificar(usuario))
                    MessageBox.Show("Acaba de Modificar Este Usuario");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Usuario");
                ClearAll();
            }
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = TextBoxNombre.Text;
            usuario.Username = TextBoxUsername.Text;
            usuario.Password = TextBoxPassword.Text;
            usuario.Fecha = Convert.ToDateTime(TextBoxFecha.Text);
            usuario.Comentario = TextBoxComentario.Text;

            return usuario;
        }

        private void edit(Usuarios usuario)
        {
            usuario.Nombre = TextBoxNombre.Text;
            usuario.Username = TextBoxUsername.Text;
            usuario.Password = TextBoxPassword.Text;
            usuario.Fecha = Convert.ToDateTime(TextBoxFecha.Text);
            usuario.Comentario = TextBoxComentario.Text;
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> u = new RepositorioBase<Usuarios>();
            int ID = int.Parse(TextBoxID.Text);

            if (u.Eliminar(ID))
            {
                MessageBox.Show("Usuario Eliminado");
            }
            else
            {
                MessageBox.Show("No se puede eliminar un Usuario que no existe");
            }
            ClearAll();
        }
    }
}