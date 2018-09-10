using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Form_HechoEnClases.Consultas
{
    public partial class cUsuarios : System.Web.UI.Page
    {
        Expression<Func<Usuarios, bool>> filtrar = x => true;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataRow dr = null;

            dt.Columns.Add(new DataColumn("IdUsuario", typeof(string)));
            dt.Columns.Add(new DataColumn("Username", typeof(string)));
            dt.Columns.Add(new DataColumn("Password", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Comentario", typeof(string)));

            dr = dt.NewRow();
            dt.Rows.Add(dr);

            GridView.DataSource = dt;
            GridView.DataBind();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> u = new RepositorioBase<Usuarios>();
            int id;
            if (FiltroTextBox.Text.Equals("ID"))
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdUsuario == id;
            }
            else if (FiltroTextBox.Text.Equals("Username"))
                filtrar = t => t.Username.Contains(CriterioTextBox.Text);

            GridView.DataSource = u.GetList(filtrar);
            GridView.DataBind();
        }
    }
}