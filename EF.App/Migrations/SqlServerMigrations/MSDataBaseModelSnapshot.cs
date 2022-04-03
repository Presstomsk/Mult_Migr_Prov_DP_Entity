﻿// <auto-generated />
using EF.App;
using EF.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.App.Migrations.SqlServerMigrations
{
    [DbContext(typeof(MSDataBase))]
    partial class MSDataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("creator");

                    b.Property<string>("DateOfRelease")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("date_of_release");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("style");

                    b.HasKey("Id");

                    b.ToTable("TabGames");
                });
#pragma warning restore 612, 618
        }
    }
}
