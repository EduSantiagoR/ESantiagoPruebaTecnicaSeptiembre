using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Artista
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var query = context.ArtistaGetAll();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var resgistro in query)
                        {
                            ML.Artista artista = new ML.Artista();
                            artista.IdArtista = resgistro.IdArtista;
                            artista.NombreArtistico = resgistro.NombreArtistico;
                            result.Objects.Add(artista);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error consultar generos musicales.";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
