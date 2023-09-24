using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GeneroMusical
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var query = context.GeneroMusicalGetAll();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var registro in query)
                        {
                            ML.GeneroMusical generoMusical = new ML.GeneroMusical();
                            generoMusical.IdGeneroMusical = registro.IdGeneroMusical;
                            generoMusical.Nombre = registro.Nombre;
                            result.Objects.Add(generoMusical);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al consultar los generos musicales.";
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
