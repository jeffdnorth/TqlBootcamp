﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TqlBootcamp.Models;

namespace TqlBootcamp.Migrations
{
    [DbContext(typeof(BootcampContext))]
    [Migration("20210601194426_fixed assessment scores")]
    partial class fixedassessmentscores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TqlBootcamp.Models.Assessment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxPoints")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfQuestions")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("TqlBootcamp.Models.AssessmentScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActualScore")
                        .HasColumnType("int");

                    b.Property<int>("AssessmentID")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentID");

                    b.HasIndex("StudentId");

                    b.ToTable("AssessmentScores");
                });

            modelBuilder.Entity("TqlBootcamp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("InBootcamp")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(11,2)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TqlBootcamp.Models.AssessmentScore", b =>
                {
                    b.HasOne("TqlBootcamp.Models.Assessment", "Assessment")
                        .WithMany("AssessmentScores")
                        .HasForeignKey("AssessmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TqlBootcamp.Models.Student", "Student")
                        .WithMany("AssessmentScores")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TqlBootcamp.Models.Assessment", b =>
                {
                    b.Navigation("AssessmentScores");
                });

            modelBuilder.Entity("TqlBootcamp.Models.Student", b =>
                {
                    b.Navigation("AssessmentScores");
                });
#pragma warning restore 612, 618
        }
    }
}
