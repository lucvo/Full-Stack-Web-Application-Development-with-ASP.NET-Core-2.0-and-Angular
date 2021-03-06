﻿// <auto-generated />
using System;
using Macaria.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Macaria.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180506133211_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Macaria.Core.Entities.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Macaria.Core.Entities.NoteTag", b =>
                {
                    b.Property<int>("NoteTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<int>("NoteId");

                    b.Property<int>("TagId");

                    b.HasKey("NoteTagId");

                    b.HasIndex("NoteId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTag");
                });

            modelBuilder.Entity("Macaria.Core.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("Slug");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Macaria.Core.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Salt");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Macaria.Core.Entities.NoteTag", b =>
                {
                    b.HasOne("Macaria.Core.Entities.Note", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Macaria.Core.Entities.Tag", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
