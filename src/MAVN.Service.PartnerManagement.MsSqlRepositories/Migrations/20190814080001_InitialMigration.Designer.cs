// <auto-generated />
using System;
using MAVN.Service.PartnerManagement.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.PartnerManagement.MsSqlRepositories.Migrations
{
    [DbContext(typeof(PartnerManagementContext))]
    [Migration("20190814080001_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("partner_management")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.ContactPersonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("contact_person");
                });

            modelBuilder.Entity("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.PartnerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("BusinessVerticalId")
                        .HasColumnName("business_vertical_id");

                    b.Property<string>("ClientId")
                        .HasColumnName("client_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<int>("CurrencyRate")
                        .HasColumnName("currency_rate");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("TokensRate")
                        .HasColumnName("tokens_rate");

                    b.HasKey("Id");

                    b.HasIndex("BusinessVerticalId");

                    b.ToTable("partner");
                });

            modelBuilder.Entity("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.VerticalEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("vertical");
                });

            modelBuilder.Entity("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.PartnerEntity", b =>
                {
                    b.HasOne("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.VerticalEntity", "BusinessVertical")
                        .WithMany()
                        .HasForeignKey("BusinessVerticalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsMany("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.LocationEntity", "Locations", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnName("id");

                            b1.Property<string>("Address")
                                .HasColumnName("address");

                            b1.Property<Guid>("ContactPersonId")
                                .HasColumnName("contact_person_id");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnName("created_at");

                            b1.Property<Guid>("CreatedBy")
                                .HasColumnName("created_by");

                            b1.Property<string>("Name")
                                .HasColumnName("name");

                            b1.Property<Guid>("PartnerId")
                                .HasColumnName("partner_id");

                            b1.HasKey("Id");

                            b1.HasIndex("ContactPersonId");

                            b1.HasIndex("PartnerId");

                            b1.ToTable("location");

                            b1.HasOne("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.ContactPersonEntity", "ContactPerson")
                                .WithMany()
                                .HasForeignKey("ContactPersonId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasOne("MAVN.Service.PartnerManagement.MsSqlRepositories.Entities.PartnerEntity", "Partner")
                                .WithMany("Locations")
                                .HasForeignKey("PartnerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
