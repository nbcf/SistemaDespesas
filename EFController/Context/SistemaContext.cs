﻿using EFController.Map;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFController.Context
{
    public class SistemaContext : DbContext
    {
         public SistemaContext() : base("Server=DESKTOP-NA4I5HN;Database=controleconta;Trusted_Connection=True;MultipleActiveResultSets=true;")
        //Host=my_host;Database=my_db;Username=my_user;Password=my_pw") DataAccessPostgreSqlProvider": "User ID=ids;Password=****;Host=127.0.0.1;Port=5432;Database=IDS;Pooling=true;
      // public SistemaContext() : base("PgConta")
        {

        }

        public DbSet<Conta> Contas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new ContaMap());
            base.OnModelCreating(modelBuilder);
        }


    }
}
