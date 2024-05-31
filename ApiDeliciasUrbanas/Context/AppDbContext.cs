﻿using ApiDeliciasUrbanas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDeliciasUrbanas.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)        
        {

        }

        public DbSet<Cliente> Clientes {  get; set; }
        public DbSet<Producto> Productos {  get; set; }
        public DbSet<Local> Locales {  get; set; }
    }
}
