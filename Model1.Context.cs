﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class VentaOnlineEntities : DbContext
    {
        public VentaOnlineEntities()
            : base("name=VentaOnlineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CURSO> CURSO { get; set; }
        public DbSet<DETALLECOMPRA> DETALLECOMPRA { get; set; }
        public DbSet<DOCENTE> DOCENTE { get; set; }
        public DbSet<INSCRITO> INSCRITO { get; set; }
    
        public virtual ObjectResult<PA1_Result> PA1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA1_Result>("PA1");
        }
    
        public virtual ObjectResult<string> PA2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA2");
        }
    }
}
