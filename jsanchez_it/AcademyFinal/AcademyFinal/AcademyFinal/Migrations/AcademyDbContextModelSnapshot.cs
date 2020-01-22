﻿// <auto-generated />
using System;
using Academy.Lib.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcademyFinal.App.WPF.Migrations
{
    [DbContext(typeof(AcademyDbContext))]
    partial class AcademyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Common.Lib.Core.Entity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Entity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Entity");
                });

            modelBuilder.Entity("Academy.Lib.Models.Exam", b =>
                {
                    b.HasBaseType("Common.Lib.Core.Entity");

                    b.Property<DateTime>("DateStamp")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("TEXT");

                    b.HasIndex("SubjectId");

                    b.HasDiscriminator().HasValue("Exam");
                });

            modelBuilder.Entity("Academy.Lib.Models.Student", b =>
                {
                    b.HasBaseType("Common.Lib.Core.Entity");

                    b.Property<int>("ChairNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dni")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Guid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Academy.Lib.Models.Subject", b =>
                {
                    b.HasBaseType("Common.Lib.Core.Entity");

                    b.Property<Guid>("Guid")
                        .HasColumnName("Subject_Guid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnName("Subject_Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Teacher")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Subject");
                });

            modelBuilder.Entity("Academy.Lib.Models.Exam", b =>
                {
                    b.HasOne("Academy.Lib.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
