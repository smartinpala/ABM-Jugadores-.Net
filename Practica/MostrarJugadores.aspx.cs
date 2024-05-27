using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica
{
    public partial class MostrarJugadores : System.Web.UI.Page
    {
        public List<Jugador> ListaJugadores { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ListaJugadores = (List<Jugador>)Session["listaJugadores"];
        }
    }
}