using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var query = context.DiscoGetAll();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach(var registro in query)
                        {
                            ML.Disco disco = new ML.Disco();
                            disco.IdDisco = registro.IdDisco;
                            disco.Titulo = registro.Titulo;
                            disco.Artista = new ML.Artista();
                            disco.Artista.IdArtista = registro.IdArtista;
                            disco.Artista.NombreArtistico = registro.NombreArtistico;
                            disco.GeneroMusical = new ML.GeneroMusical();
                            disco.GeneroMusical.IdGeneroMusical = registro.IdGeneroMusical;
                            disco.GeneroMusical.Nombre = registro.NombreGenero;
                            disco.Duracion = registro.Duracion;
                            disco.Anio = registro.Anio;
                            disco.Distribuidora = new ML.Distribuidora();
                            disco.Distribuidora.IdDistribuidora = registro.IdDistribuidora;
                            disco.Distribuidora.Nombre = registro.NombreDistribuidora;
                            disco.Ventas = registro.Ventas.Value;
                            disco.Disponibilidad = registro.Disponibilidad.Value;
                            result.Objects.Add(disco);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al consultar los discos.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetById(int idDisco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var query = context.DiscoGetById(idDisco);
                    if (query != null)
                    {
                        foreach(var registro in query)
                        {
                            result.Object = new object();
                            ML.Disco disco = new ML.Disco();
                            disco.IdDisco = registro.IdDisco;
                            disco.Titulo = registro.Titulo;
                            disco.Artista = new ML.Artista();
                            disco.Artista.IdArtista = registro.IdArtista;
                            disco.Artista.NombreArtistico = registro.NombreArtistico;
                            disco.GeneroMusical = new ML.GeneroMusical();
                            disco.GeneroMusical.IdGeneroMusical = registro.IdGeneroMusical;
                            disco.GeneroMusical.Nombre = registro.NombreGenero;
                            disco.Duracion = registro.Duracion;
                            disco.Anio = registro.Anio;
                            disco.Distribuidora = new ML.Distribuidora();
                            disco.Distribuidora.IdDistribuidora = registro.IdDistribuidora;
                            disco.Distribuidora.Nombre = registro.NombreDistribuidora;
                            disco.Ventas = registro.Ventas.Value;
                            disco.Disponibilidad = registro.Disponibilidad.Value;
                            result.Object = disco;
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al consultar el disco.";
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
        public static ML.Result Add(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var rowsAffected = context.DiscoAdd(
                        disco.Titulo,
                        disco.Artista.IdArtista,
                        disco.GeneroMusical.IdGeneroMusical,
                        disco.Duracion,
                        disco.Anio,
                        disco.Distribuidora.IdDistribuidora);
                    if( rowsAffected > 0 )
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al agregar el disco";
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
        public static ML.Result Update(ML.Disco disco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var rowsAffected = context.DiscoUpdate(
                        disco.IdDisco,
                        disco.Titulo,
                        disco.Artista.IdArtista,
                        disco.GeneroMusical.IdGeneroMusical,
                        disco.Duracion,
                        disco.Anio,
                        disco.Distribuidora.IdDistribuidora,
                        disco.Ventas,
                        disco.Disponibilidad);
                    if (rowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar.";
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
        public static ML.Result Delete(int idDisco)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.ESantiagoPruebaTecnicaSeptiembreEntities context = new DL.ESantiagoPruebaTecnicaSeptiembreEntities())
                {
                    var rowsAffected = context.DiscoDelete(idDisco);
                    if(rowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar.";
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
