using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Lesionado { get; set; }
        public bool Nacional { get; set; }
        public string Imagen { get; set; }

        public Jugador() { }

        public Jugador(int i, string n, string d, string e, DateTime f, bool l, bool na) { 
            Id = i; 
            Nombre = n; 
            Descripcion = d; 
            Equipo = e;
            Fecha = f;
            Lesionado = l;
            Nacional = na;
        }
    }

    public class JugadorNegocio{

        public List<Jugador> listar()
        {
            List<Jugador> jugadores = new List<Jugador>();

            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());

            jugadores[0].Id = 1;
            jugadores[0].Nombre = "Nicolas Aguirre";
            jugadores[0].Descripcion = "Le dicen el penka aguirre y juega de base";
            jugadores[0].Equipo = "Olimpico (La Banda)";
            jugadores[0].Fecha = DateTime.Now;
            jugadores[0].Lesionado = false;
            jugadores[0].Nacional = true;
            jugadores[0].Imagen = "https://basquetplus.com/sites/default/files/main/articles/PenkaAguirreOlimpico.jpg";

            jugadores[1].Id = 2;
            jugadores[1].Nombre = "Gabriel Deck";
            jugadores[1].Descripcion = "Le dicen la tortuga, y juega de alero/ala pivot";
            jugadores[1].Equipo = "San Lorenzo (CABA)";
            jugadores[1].Fecha = DateTime.Now;
            jugadores[1].Lesionado = true;
            jugadores[1].Nacional = true;
            jugadores[1].Imagen = "https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2018/05/08171820/Gabriel-Deck-1.jpg";

            jugadores[2].Id = 3;
            jugadores[2].Nombre = "Leonardo Mainoldi";
            jugadores[2].Descripcion = "Paso por los equipos quimsa, gimnasia, san martin. Le dicen el coco y juega de ala pivot";
            jugadores[2].Equipo = "Quimsa (Sgo del Estero)";
            jugadores[2].Fecha = DateTime.Now.AddMonths(-1);
            jugadores[2].Lesionado = false;
            jugadores[2].Nacional = false;
            jugadores[2].Imagen = "https://www.ole.com.ar/2023/04/22/4Ct1LclRr_720x0__1.jpg";

            jugadores.Add(new Jugador());

            jugadores[3].Id = 4;
            jugadores[3].Nombre = "Athony Young";
            jugadores[3].Descripcion = "Jugador estranjero de excelente step back";
            jugadores[3].Equipo = "Regatas (Corrientes)";
            jugadores[3].Fecha = DateTime.Now.AddYears(-31);
            jugadores[3].Lesionado = true;
            jugadores[3].Nacional = false;
            jugadores[3].Imagen = "https://i0.wp.com/pbs.twimg.com/media/GFIudYxWUAA3ZNq.jpg?resize=450%2C450&ssl=1&crop=1";

            jugadores.Add(new Jugador());

            jugadores[4].Id = 5;
            jugadores[4].Nombre = "Martin Palavecino";
            jugadores[4].Descripcion = "Es de la banda y agata sabe hacer una bandeja";
            jugadores[4].Equipo = "Olimpico (La Banda)";
            jugadores[4].Fecha = DateTime.Now.AddYears(-25);
            jugadores[4].Lesionado = false;
            jugadores[4].Nacional = true;
            jugadores[4].Imagen = "https://media-eze1-1.cdn.whatsapp.net/v/t61.24694-24/425223242_362458672775350_2977467989855437150_n.jpg?ccb=11-4&oh=01_Q5AaIPIl4YqePEbuFfmShxmCvBq-Ysn_ti19EVR7tSuyzg8D&oe=665BC44C&_nc_sid=e6ed6c&_nc_cat=100";

            jugadores.Add(new Jugador());

            jugadores[5].Id = 6;
            jugadores[5].Nombre = "Rodrigo Nicolas Blanco";
            jugadores[5].Descripcion = "En el polideportivo le pinta la cara a todos, una bestia el hombre";
            jugadores[5].Equipo = "Boca jrs (Bs As)";
            jugadores[5].Fecha = DateTime.Now.AddYears(-20);
            jugadores[5].Lesionado = true;
            jugadores[5].Nacional = true;
            jugadores[5].Imagen = "https://media-eze1-1.cdn.whatsapp.net/v/t61.24694-24/408297402_387603683714505_2390897666631393927_n.jpg?ccb=11-4&oh=01_Q5AaIMf9jIbKgIxGXH67jEnT-etXitP_Dfc8lw4NdOo4HAzO&oe=6658E263&_nc_sid=e6ed6c&_nc_cat=105";

            jugadores.Add(new Jugador(7,"Marcos Mata","Mide 2.02 mts","Boca jrs (Bs As)", DateTime.Now.AddYears(-30),false,true));
            jugadores[6].Imagen = "https://media.elpatagonico.com/p/9e11d38c32b38a584d0fdf513f852bba/adjuntos/193/imagenes/040/703/0040703218/770x0/smart/matajpeg.jpeg";

            jugadores.Add(new Jugador(8, "Pedro Barral", "Juega en la posicion de base", "Obras (CABA)", DateTime.Now.AddYears(-27), false, true));
            jugadores[7].Imagen = "https://www.laliganacional.com.ar/uploadsfotos/mae_6171.jpeg";

            jugadores.Add(new Jugador(9, "Bryan Carabali", "Jugador mas alto de la liga con buen porcentaje de tapas, estuvo en quimsa.", "San Martin (Corrientes)", DateTime.Now.AddYears(-28), false, false));
            jugadores[8].Imagen = "https://www.laliganacional.com.ar/uploadsfotos/56f26792-006c-40a9-8676-0a05293da7d0_2.jpeg";


            return jugadores;
        }

    }
}
