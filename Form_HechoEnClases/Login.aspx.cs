using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Form_HechoEnClases
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonEntrar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();

            filtrar = t => t.Username.Contains(userTextbox.Text);
            RepositorioBase<Usuarios> u = new RepositorioBase<Usuarios>();
            user = u.GetList(filtrar);

            if (user.Exists(x => x.Username == userTextbox.Text) && user.Exists(x => x.Password == passwordTextbox.Text))
            {
                Response.Redirect("menu.aspx");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
            }
        }
    }
}