﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ESantiagoPruebaTecnicaSeptiembreEntities : DbContext
    {
        public ESantiagoPruebaTecnicaSeptiembreEntities()
            : base("name=ESantiagoPruebaTecnicaSeptiembreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artista> Artistas { get; set; }
        public virtual DbSet<Disco> Discoes { get; set; }
        public virtual DbSet<Distribuidora> Distribuidoras { get; set; }
        public virtual DbSet<GeneroMusical> GeneroMusicals { get; set; }
    
        public virtual ObjectResult<ArtistaGetAll_Result> ArtistaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ArtistaGetAll_Result>("ArtistaGetAll");
        }
    
        public virtual int DiscoAdd(string titulo, Nullable<int> idArtista, Nullable<int> idGeneroMusical, string duracion, Nullable<System.DateTime> anio, Nullable<int> idDistribuidora)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroMusicalParameter = idGeneroMusical.HasValue ?
                new ObjectParameter("IdGeneroMusical", idGeneroMusical) :
                new ObjectParameter("IdGeneroMusical", typeof(int));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoAdd", tituloParameter, idArtistaParameter, idGeneroMusicalParameter, duracionParameter, anioParameter, idDistribuidoraParameter);
        }
    
        public virtual int DiscoDelete(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoDelete", idDiscoParameter);
        }
    
        public virtual ObjectResult<DiscoGetAll_Result> DiscoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetAll_Result>("DiscoGetAll");
        }
    
        public virtual ObjectResult<DiscoGetById_Result> DiscoGetById(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetById_Result>("DiscoGetById", idDiscoParameter);
        }
    
        public virtual ObjectResult<DistribuidoraGetAll_Result> DistribuidoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DistribuidoraGetAll_Result>("DistribuidoraGetAll");
        }
    
        public virtual ObjectResult<GeneroMusicalGetAll_Result> GeneroMusicalGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GeneroMusicalGetAll_Result>("GeneroMusicalGetAll");
        }
    
        public virtual int DiscoUpdate(Nullable<int> idDisco, string titulo, Nullable<int> idArtista, Nullable<int> idGeneroMusical, string duracion, Nullable<System.DateTime> anio, Nullable<int> idDistribuidora, Nullable<int> ventas, Nullable<bool> disponibilidad)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroMusicalParameter = idGeneroMusical.HasValue ?
                new ObjectParameter("IdGeneroMusical", idGeneroMusical) :
                new ObjectParameter("IdGeneroMusical", typeof(int));
    
            var duracionParameter = duracion != null ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad.HasValue ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoUpdate", idDiscoParameter, tituloParameter, idArtistaParameter, idGeneroMusicalParameter, duracionParameter, anioParameter, idDistribuidoraParameter, ventasParameter, disponibilidadParameter);
        }
    }
}
