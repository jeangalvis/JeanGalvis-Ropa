﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(TiendaRopaContext))]
    [Migration("20231020223429_FirstMig")]
    partial class FirstMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<decimal>("SueldoBase")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("cargo", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipiofk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonafk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipiofk");

                    b.HasIndex("IdTipoPersonafk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisfk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisfk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetalleOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducida")
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducir")
                        .HasColumnType("int");

                    b.Property<int>("IdColorfk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadofk")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenfk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendafk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdColorfk");

                    b.HasIndex("IdEstadofk");

                    b.HasIndex("IdOrdenfk");

                    b.HasIndex("IdPrendafk");

                    b.ToTable("detalleOrden", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventariofk")
                        .HasColumnType("int");

                    b.Property<int>("IdTallafk")
                        .HasColumnType("int");

                    b.Property<int>("IdVentafk")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnit")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdInventariofk");

                    b.HasIndex("IdTallafk");

                    b.HasIndex("IdVentafk");

                    b.ToTable("detalleVenta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCargofk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipiofk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCargofk");

                    b.HasIndex("IdMunicipiofk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdMunicipiofk")
                        .HasColumnType("int");

                    b.Property<string>("NIT")
                        .HasColumnType("longtext");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("longtext");

                    b.Property<string>("RepresentanteLegal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipiofk");

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("IdTipoEstadofk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoEstadofk");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("formaPago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnit")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("insumo", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.InsumoPrenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumofk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendafk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInsumofk");

                    b.HasIndex("IdPrendafk");

                    b.ToTable("insumoPrenda", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.InsumoProveedor", b =>
                {
                    b.Property<int>("IdProveedorfk")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumofk")
                        .HasColumnType("int");

                    b.HasKey("IdProveedorfk", "IdInsumofk");

                    b.HasIndex("IdInsumofk");

                    b.ToTable("userRol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodInv")
                        .HasColumnType("longtext");

                    b.Property<int>("IdPrendafk")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorVtaCop")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorVtaUsd")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdPrendafk");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.InventarioTalla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventariofk")
                        .HasColumnType("int");

                    b.Property<int>("IdTallafk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdInventariofk");

                    b.HasIndex("IdTallafk");

                    b.ToTable("inventarioTalla", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentofk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentofk");

                    b.ToTable("municipio", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdClientefk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadofk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadofk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClientefk");

                    b.HasIndex("IdEmpleadofk");

                    b.HasIndex("IdEstadofk");

                    b.ToTable("orden", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Prenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEstadofk")
                        .HasColumnType("int");

                    b.Property<int>("IdGenerofk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoProteccionfk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<decimal>("ValorUnitCop")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorUnitUsd")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadofk");

                    b.HasIndex("IdGenerofk");

                    b.HasIndex("IdTipoProteccionfk");

                    b.ToTable("prenda", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMunicipiofk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonafk")
                        .HasColumnType("int");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdMunicipiofk");

                    b.HasIndex("IdTipoPersonafk");

                    b.ToTable("proveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUserfk")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdUserfk");

                    b.ToTable("refreshToken", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Talla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("talla", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoEstado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoPersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoProteccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tipoProteccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserfk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolfk")
                        .HasColumnType("int");

                    b.HasKey("IdUserfk", "IdRolfk");

                    b.HasIndex("IdRolfk");

                    b.ToTable("userRols", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdClientefk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadofk")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagofk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClientefk");

                    b.HasIndex("IdEmpleadofk");

                    b.HasIndex("IdFormaPagofk");

                    b.ToTable("venta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Municipio", "Municipio")
                        .WithMany("Clientes")
                        .HasForeignKey("IdMunicipiofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Clientes")
                        .HasForeignKey("IdTipoPersonafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Domain.Entities.DetalleOrden", b =>
                {
                    b.HasOne("Domain.Entities.Color", "Color")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdColorfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Estado", "Estado")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdEstadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Orden", "Orden")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdOrdenfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Prenda", "Prenda")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdPrendafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Estado");

                    b.Navigation("Orden");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Entities.DetalleVenta", b =>
                {
                    b.HasOne("Domain.Entities.Inventario", "Inventario")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdInventariofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Talla", "Talla")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdTallafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Venta", "Venta")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdVentafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("IdCargofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Municipio", "Municipio")
                        .WithMany("Empleados")
                        .HasForeignKey("IdMunicipiofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Domain.Entities.Empresa", b =>
                {
                    b.HasOne("Domain.Entities.Municipio", "Municipio")
                        .WithMany("Empresas")
                        .HasForeignKey("IdMunicipiofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.HasOne("Domain.Entities.TipoEstado", "TipoEstado")
                        .WithMany("Estados")
                        .HasForeignKey("IdTipoEstadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("Domain.Entities.InsumoPrenda", b =>
                {
                    b.HasOne("Domain.Entities.Insumo", "Insumo")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdInsumofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Prenda", "Prenda")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdPrendafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Entities.InsumoProveedor", b =>
                {
                    b.HasOne("Domain.Entities.Insumo", "Insumo")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("IdInsumofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("IdProveedorfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.HasOne("Domain.Entities.Prenda", "Prenda")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPrendafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Domain.Entities.InventarioTalla", b =>
                {
                    b.HasOne("Domain.Entities.Inventario", "Inventario")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdInventariofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Talla", "Talla")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdTallafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamento")
                        .WithMany("Municipios")
                        .HasForeignKey("IdDepartamentofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdClientefk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Empleado", "Empleado")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdEmpleadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Estado", "Estado")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdEstadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Domain.Entities.Prenda", b =>
                {
                    b.HasOne("Domain.Entities.Estado", "Estado")
                        .WithMany("Prendas")
                        .HasForeignKey("IdEstadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Genero", "Genero")
                        .WithMany("Prendas")
                        .HasForeignKey("IdGenerofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoProteccion", "TipoProteccion")
                        .WithMany("Prendas")
                        .HasForeignKey("IdTipoProteccionfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Genero");

                    b.Navigation("TipoProteccion");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.HasOne("Domain.Entities.Municipio", "Municipio")
                        .WithMany("Proveedores")
                        .HasForeignKey("IdMunicipiofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Proveedores")
                        .HasForeignKey("IdTipoPersonafk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("IdUserfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdRolfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Usuario")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdUserfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Venta", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("IdClientefk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Empleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("IdEmpleadofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.FormaPago", "FormaPago")
                        .WithMany("Ventas")
                        .HasForeignKey("IdFormaPagofk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("FormaPago");
                });

            modelBuilder.Entity("Domain.Entities.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Navigation("DetalleOrdenes");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("DetalleOrdenes");

                    b.Navigation("Ordenes");

                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Domain.Entities.Insumo", b =>
                {
                    b.Navigation("InsumoPrendas");

                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Domain.Entities.Municipio", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("Empresas");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.Navigation("DetalleOrdenes");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Prenda", b =>
                {
                    b.Navigation("DetalleOrdenes");

                    b.Navigation("InsumoPrendas");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Domain.Entities.Talla", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Domain.Entities.TipoEstado", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Domain.Entities.TipoProteccion", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Domain.Entities.Venta", b =>
                {
                    b.Navigation("DetalleVentas");
                });
#pragma warning restore 612, 618
        }
    }
}
