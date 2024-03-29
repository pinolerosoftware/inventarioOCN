﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext.ConfiguracionDB;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataBaseContext
{
    public class InvContext : DbContext
    {
        public InvContext() : base(Static.ConfiguracionDB.CadenaConexion)
        {

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<EntradaLinea> EntradaLineas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<SalidaLinea> SalidasLineas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<RolAcceso> RolesAcceso { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Moneda> Monedas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Configurations.Add(new AreaConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ProductoConfig());
            modelBuilder.Configurations.Add(new UbicacionConfig());
            modelBuilder.Configurations.Add(new EntradaConfig());
            modelBuilder.Configurations.Add(new EntradaLineaConfig());
            modelBuilder.Configurations.Add(new InventarioConfig());
            modelBuilder.Configurations.Add(new SalidaConfig());
            modelBuilder.Configurations.Add(new SalidaLineaConfig());
            modelBuilder.Configurations.Add(new RolConfig());
            modelBuilder.Configurations.Add(new RolAccesoConfig());
            modelBuilder.Configurations.Add(new PermisoConfig());
            modelBuilder.Configurations.Add(new MarcaConfig());
            modelBuilder.Configurations.Add(new MonedaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
