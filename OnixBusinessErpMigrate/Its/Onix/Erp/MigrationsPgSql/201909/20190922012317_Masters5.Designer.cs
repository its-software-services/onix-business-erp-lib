﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnixBusinessErpApp;

namespace OnixBusinessErpApp.Its.Onix.Erp.Migrations
{
    [DbContext(typeof(OnixErpDbContextPgSql))]
    [Migration("20190922012317_Masters5")]
    partial class Masters5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Its.Onix.Erp.Models.Generals.Master", b =>
                {
                    b.Property<int>("MasterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Key");

                    b.Property<DateTime>("LastMaintDate");

                    b.Property<string>("Name");

                    b.Property<string>("Tag");

                    b.HasKey("MasterId");

                    b.ToTable("MasterExs");
                });
#pragma warning restore 612, 618
        }
    }
}
