﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moryx.Resources.Model;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Moryx.Resources.Management.Model.Migrations
{
    [DbContext(typeof(ResourcesContext))]
    partial class ResourcesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Moryx.Resources.Model.ResourceEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ExtensionData")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Moryx.Resources.Model.ResourceRelationEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("RelationType")
                        .HasColumnType("integer");

                    b.Property<long>("SourceId")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceName")
                        .HasColumnType("text");

                    b.Property<long>("TargetId")
                        .HasColumnType("bigint");

                    b.Property<string>("TargetName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.HasIndex("TargetId");

                    b.ToTable("ResourceRelations");
                });

            modelBuilder.Entity("Moryx.Resources.Model.ResourceRelationEntity", b =>
                {
                    b.HasOne("Moryx.Resources.Model.ResourceEntity", "Source")
                        .WithMany("Targets")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moryx.Resources.Model.ResourceEntity", "Target")
                        .WithMany("Sources")
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
