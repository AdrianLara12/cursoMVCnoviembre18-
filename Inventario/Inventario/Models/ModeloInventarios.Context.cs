﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbInventarioEntities : DbContext
    {
        public dbInventarioEntities()
            : base("name=dbInventarioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
    
        public virtual ObjectResult<ObtenerCategorias_Result> ObtenerCategorias(Nullable<bool> soloActivo)
        {
            var soloActivoParameter = soloActivo.HasValue ?
                new ObjectParameter("SoloActivo", soloActivo) :
                new ObjectParameter("SoloActivo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCategorias_Result>("ObtenerCategorias", soloActivoParameter);
        }
    }
}
