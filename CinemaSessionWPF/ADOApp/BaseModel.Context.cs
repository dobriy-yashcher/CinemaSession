﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaSessionWPF.ADOApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class CinemaSessionEntities : DbContext
    {
        private static CinemaSessionEntities _context;

        public CinemaSessionEntities()
            : base("name=CinemaSessionEntities")
        {
        }

        public static CinemaSessionEntities GetContext()
        {
            if (_context == null)
                _context = new CinemaSessionEntities();

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientTag> ClientTag { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
    }
}
