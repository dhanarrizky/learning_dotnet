﻿// <auto-generated />
using System;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(GoBlogContext))]
    [Migration("20231116162808_goBlogMigrations")]
    partial class goBlogMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "DeletedAt" }, "idx_categories_deleted_at");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Post", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<ulong>("CategoryId")
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("category_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Img")
                        .HasColumnType("longtext")
                        .HasColumnName("img");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("updated_at");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CategoryId" }, "fk_posts_category");

                    b.HasIndex(new[] { "UserId" }, "fk_users_posts");

                    b.HasIndex(new[] { "DeletedAt" }, "idx_posts_deleted_at");

                    b.ToTable("posts", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20) unsigned")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("Birth")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("birth");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("birth_date");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("birth_place");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("first_name");

                    b.Property<bool?>("Gender")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint(20)")
                        .HasColumnName("phone");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("refresh_token");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("role");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("token");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(3)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "DeletedAt" }, "idx_users_deleted_at");

                    b.HasIndex(new[] { "Phone" }, "phone")
                        .IsUnique();

                    b.HasIndex(new[] { "UserName" }, "user_name")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Post", b =>
                {
                    b.HasOne("DataAccess.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("fk_posts_category");

                    b.HasOne("DataAccess.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("fk_users_posts");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
