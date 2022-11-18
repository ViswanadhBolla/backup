﻿// <auto-generated />
using ClassFirstEg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassFirstEg.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20220830102401_migr1")]
    partial class migr1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassFirstEg.Doctor", b =>
                {
                    b.Property<int>("DocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocId"), 1L, 1);

                    b.Property<string>("DocName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spcialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ClassFirstEg.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doctorDocId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("doctorDocId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ClassFirstEg.Patient", b =>
                {
                    b.HasOne("ClassFirstEg.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
