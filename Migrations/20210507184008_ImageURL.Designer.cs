﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SindOnibus.Data;

namespace SindOnibus.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210507184008_ImageURL")]
    partial class ImageURL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("SindOnibus.model.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNasci");

                    b.Property<string>("Email");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}