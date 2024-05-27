using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Practica
{
    public partial class CargaJugador : System.Web.UI.Page
    {
        public string H2 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            H2 = "Formulario de alta de jugador";
            if (!IsPostBack)
            {
                ddlEquipo.Items.Add("Olimpico (La Banda)");
                ddlEquipo.Items.Add("San Lorenzo (CABA)");
                ddlEquipo.Items.Add("Quimsa (Sgo del Estero)");
                ddlEquipo.Items.Add("Regatas (Corrientes)");
                ddlEquipo.Items.Add("Boca jrs (Bs As)");
                ddlEquipo.Items.Add("Obras (CABA)");
                ddlEquipo.Items.Add("San Martin (Corrientes)");
            }

            if (Request.QueryString["id"] != null)
            {
                H2 = "Destalles del jugador";
                if (!IsPostBack)
                {
                    //Quiere decir que viene para editar
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    //creo mi lista temporal
                    List<Jugador> temporal = (List<Jugador>)Session["listaJugadores"];
                    //esto devuelve el jugador con ese id
                    Jugador jugadorSeleccionado = temporal.Find(x => x.Id == id);

                    mostrarDatos(jugadorSeleccionado);

                    setearControles();
                }
                //viene para editar pero apreto el boton modificar por ende procedo
                // directamente a la modificacion (antes ya paso por ahi)
                    
            }
            else
            {
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
            }
            
        }

        private void mostrarDatos(Jugador j)
        {
            txtId.Text = j.Id.ToString();
            txtNombre.Text = j.Nombre;
            txtDescripcion.Text = j.Descripcion;
            ddlEquipo.SelectedValue= j.Equipo;
            txtFecha.Text = j.Fecha.ToString("yyyy-MM-dd");

            //setear el check de lesionado o no lesionado
            if (j.Lesionado){
                rdbEnCondicion.Checked = false;
                rdbLesionado.Checked = true;
            }else{
                rdbEnCondicion.Checked = true;
                rdbLesionado.Checked = false;
            }


            //setear el check de si es nacional o extranjero
            if (j.Nacional)
            {
                rdbNacional.Checked = true;
                rdbExtrangero.Checked = false;
            }
            else
            {
                rdbExtrangero.Checked = true;
                rdbNacional.Checked = false;
            }
        }

        private void setearControles()
        {
            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            btnModificar.Visible = true;
            //btnCargar.Text = "Modificar";
            btnCargar.Visible = false;


        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                //Realizar una modificacion con el mismo boton que carga

                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Jugador> temporal = (List<Jugador>)Session["listaJugadores"];
                int p = buscarJugador(id, temporal);

                temporal[p].Descripcion = txtDescripcion.Text;
                temporal[p].Equipo = ddlEquipo.SelectedValue;
                temporal[p].Fecha = DateTime.Parse(txtFecha.Text);
                temporal[p].Lesionado = rdbLesionado.Checked;
                temporal[p].Nacional = rdbNacional.Checked;
                temporal[p].Imagen = txtImagen.Text;

                Session["listaJugadores"] = temporal;

                Response.Redirect("Default.aspx", false);
            }
            else
            {
                Jugador j = new Jugador();
                j.Id = int.Parse(txtId.Text);
                j.Nombre = txtNombre.Text;
                j.Descripcion = txtDescripcion.Text;
                j.Equipo = ddlEquipo.SelectedValue;
                j.Fecha = DateTime.Parse(txtFecha.Text);
                j.Lesionado = rdbLesionado.Checked;
                j.Nacional = rdbNacional.Checked;
                j.Imagen = txtImagen.Text;

                List<Jugador> temporal = (List<Jugador>)Session["listaJugadores"];
                temporal.Add(j);

                Response.Redirect("Default.aspx", false);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            //modificar utilizando un boton aparte (este estoy usando)

            int id = int.Parse(Request.QueryString["id"].ToString());
            List<Jugador> temporal = (List<Jugador>)Session["listaJugadores"];
            int p = buscarJugador(id, temporal);

            temporal[p].Descripcion = txtDescripcion.Text;
            temporal[p].Equipo = ddlEquipo.SelectedValue;
            temporal[p].Fecha = DateTime.Parse(txtFecha.Text);
            temporal[p].Lesionado = rdbLesionado.Checked;
            temporal[p].Nacional = rdbNacional.Checked;
            temporal[p].Imagen = txtImagen.Text;

            Session["listaJugadores"]=temporal;

            Response.Redirect("Default.aspx", false);

        }

        private int buscarJugador(int id, List<Jugador> lista)
        {
            int i = 0;
            int posicion = -1;
            foreach(Jugador j in lista)
            {
                if (j.Id == id)
                    posicion = i;
                i++;

            }
            return posicion;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            List<Jugador> listaJugadores = (List<Jugador>)Session["listaJugadores"];

            // Eliminar el jugador con el ID dado
            listaJugadores.RemoveAll(jugador => jugador.Id == id);
            Response.Redirect("Default.aspx", false);
        }
    }
}