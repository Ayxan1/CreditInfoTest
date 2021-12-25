﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.ApplicationDataContext;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211225133459_AddHelperTablesAndJoinsAmongTables")]
    partial class AddHelperTablesAndJoinsAmongTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebApplication1.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ContractCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("WebApplication1.Models.ContractData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<decimal>("CurrentBalanceId")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("DateAccountOpened")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfLastPayment")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InstallmentAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("NextPaymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("OriginalAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("OverdueBalance")
                        .HasColumnType("numeric");

                    b.Property<int>("PhaseOfContractId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RealEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ContractId")
                        .IsUnique();

                    b.HasIndex("CurrencyId");

                    b.HasIndex("PhaseOfContractId");

                    b.ToTable("ContractDatas");
                });

            modelBuilder.Entity("WebApplication1.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("WebApplication1.Models.Individual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("NationalID")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("WebApplication1.Models.PhaseOfContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PhaseOfContracts");
                });

            modelBuilder.Entity("WebApplication1.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication1.Models.SubjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("GuaranteeAmount")
                        .HasColumnType("numeric");

                    b.Property<int>("IndividualId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("IndividualId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("SubjectRoles");
                });

            modelBuilder.Entity("WebApplication1.Models.ContractData", b =>
                {
                    b.HasOne("WebApplication1.Models.Contract", "Contract")
                        .WithOne("ContractData")
                        .HasForeignKey("WebApplication1.Models.ContractData", "ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Currency", "Currency")
                        .WithMany("ContractDatas")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.PhaseOfContract", "PhaseOfContract")
                        .WithMany("ContractDatas")
                        .HasForeignKey("PhaseOfContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Currency");

                    b.Navigation("PhaseOfContract");
                });

            modelBuilder.Entity("WebApplication1.Models.Individual", b =>
                {
                    b.HasOne("WebApplication1.Models.Contract", "Contract")
                        .WithMany("Individuals")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("WebApplication1.Models.SubjectRole", b =>
                {
                    b.HasOne("WebApplication1.Models.Currency", "Currency")
                        .WithMany("SubjectRoles")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Individual", "Individual")
                        .WithOne("SubjectRole")
                        .HasForeignKey("WebApplication1.Models.SubjectRole", "IndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Role", "Role")
                        .WithMany("SubjectRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Individual");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebApplication1.Models.Contract", b =>
                {
                    b.Navigation("ContractData");

                    b.Navigation("Individuals");
                });

            modelBuilder.Entity("WebApplication1.Models.Currency", b =>
                {
                    b.Navigation("ContractDatas");

                    b.Navigation("SubjectRoles");
                });

            modelBuilder.Entity("WebApplication1.Models.Individual", b =>
                {
                    b.Navigation("SubjectRole");
                });

            modelBuilder.Entity("WebApplication1.Models.PhaseOfContract", b =>
                {
                    b.Navigation("ContractDatas");
                });

            modelBuilder.Entity("WebApplication1.Models.Role", b =>
                {
                    b.Navigation("SubjectRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
