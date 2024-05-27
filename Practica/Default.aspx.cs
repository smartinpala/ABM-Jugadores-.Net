using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Practica
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaJugadores"] == null)
            {
                JugadorNegocio jg = new JugadorNegocio();
                Session.Add("listaJugadores", jg.listar());
            }

            dgvJugadores.DataSource = Session["listaJugadores"];
            dgvJugadores.DataBind();

        }

        protected void dgvJudaores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var x = dgvJugadores.SelectedRow.Cells[0].Text;
            var id = dgvJugadores.SelectedDataKey.Value.ToString();
            Response.Redirect("CargaJugador.aspx?id=" + id);
        }
    }
}