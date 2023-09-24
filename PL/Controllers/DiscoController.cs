using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class DiscoController : Controller
    {
        // GET: Disco
        public ActionResult GetAll()
        {
            ML.Result resultDiscos = BL.Disco.GetAll();
            ML.Disco disco = new ML.Disco();
            disco.Discos = resultDiscos.Objects;
            return View(disco);
        }
        public ActionResult Form(int? idDisco)
        {
            ML.Disco disco = new ML.Disco();
            disco.Artista = new ML.Artista();
            disco.GeneroMusical = new ML.GeneroMusical();
            disco.Distribuidora = new ML.Distribuidora();
            ML.Result resultArtistas = BL.Artista.GetAll();
            ML.Result resultGeneros = BL.GeneroMusical.GetAll();
            ML.Result resultDistribuidoras = BL.Distribuidora.GetAll();

            if (idDisco == null) //Agrega
            {
                disco.Artista.Artistas = resultArtistas.Objects.ToList();
                disco.GeneroMusical.GenerosMusicales = resultGeneros.Objects.ToList();
                disco.Distribuidora.Distribuidoras = resultDistribuidoras.Objects.ToList();
                return View(disco);
            }
            else //Actualiza
            {
                ML.Result result = BL.Disco.GetById(idDisco.Value);
                disco = (ML.Disco)result.Object;
                disco.Artista.Artistas = resultArtistas.Objects.ToList();
                disco.GeneroMusical.GenerosMusicales = resultGeneros.Objects.ToList();
                disco.Distribuidora.Distribuidoras = resultDistribuidoras.Objects.ToList();
                return View(disco);
            }
        }
        public ActionResult Delete(int idDisco)
        {
            ML.Result result = BL.Disco.Delete(idDisco);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Eliminado correctamente.";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Mensaje = "Error al eliminar.";
                return PartialView("Modal");
            }
        }
        [HttpPost]
        public ActionResult Form(ML.Disco disco)
        {
            if(ModelState.IsValid)
            {
                if (disco.IdDisco == 0) //Agrega
                {
                    ML.Result result = BL.Disco.Add(disco);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Agregado correctamente.";
                        return PartialView("Modal");
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error al agregar.";
                        return PartialView("Modal");
                    }
                }
                else
                {
                    ML.Result result = BL.Disco.Update(disco);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Actualizado correctamente.";
                        return PartialView("Modal");
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error al actualizar.";
                        return PartialView("Modal");
                    }
                }
            }
            else
            {
                ML.Result resultArtistas = BL.Artista.GetAll();
                ML.Result resultGeneros = BL.GeneroMusical.GetAll();
                ML.Result resultDistribuidoras = BL.Distribuidora.GetAll();
                disco.Artista.Artistas = resultArtistas.Objects.ToList();
                disco.GeneroMusical.GenerosMusicales = resultGeneros.Objects.ToList();
                disco.Distribuidora.Distribuidoras = resultDistribuidoras.Objects.ToList();
                return View(disco);
            }
            
        }
    }
}