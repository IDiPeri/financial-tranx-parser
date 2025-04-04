﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickHomeExpenseSummarizer.Entity;

#nullable disable

namespace QuickHomeExpenseSummarizer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250318143944_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("QuickHomeExpenseSummarizer.Entity.SourceFolder", b =>
                {
                    b.Property<int>("SourceFolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SourceFolderId");

                    b.ToTable("SourceFolders");
                });
#pragma warning restore 612, 618
        }
    }
}
