﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MannLabels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JDE_PRODUCTIONEntities : DbContext
    {
        public JDE_PRODUCTIONEntities()
            : base("name=JDE_PRODUCTIONEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<F0005> F0005 { get; set; }
        public virtual DbSet<F4101> F4101 { get; set; }
        public virtual DbSet<F4104> F4104 { get; set; }
    }
}
