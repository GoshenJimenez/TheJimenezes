﻿// <auto-generated />
using System;
using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoshenJimenez.TheJimenezes.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20210218055308_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Attachment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AttachmentUrl")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Caption")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<bool>("CommentsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ContentType")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<bool>("LikesEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("PostId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<int?>("SortOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Column", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BannerUrl")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<int>("ColumnType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IconUrl")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Layout")
                        .HasColumnType("varchar(75) CHARACTER SET utf8mb4")
                        .HasMaxLength(75);

                    b.Property<string>("SubTitle")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<string>("Title")
                        .HasColumnType("varchar(75) CHARACTER SET utf8mb4")
                        .HasMaxLength(75);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Columns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                            ColumnType = 0,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 462, DateTimeKind.Utc).AddTicks(1263),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Projects",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 462, DateTimeKind.Utc).AddTicks(2412)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be201"),
                            ColumnType = 0,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 462, DateTimeKind.Utc).AddTicks(9993),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Programming",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(21)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be202"),
                            ColumnType = 0,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(176),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Tech Talk",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(178)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be203"),
                            ColumnType = 1,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(188),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Parallax",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(190)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be204"),
                            ColumnType = 1,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(198),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Parallax II",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(199)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be205"),
                            ColumnType = 2,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(213),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Travel Logs",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(215)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be206"),
                            ColumnType = 2,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(222),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Food Reviews",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(223)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be207"),
                            ColumnType = 3,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(230),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Fambam!",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(231)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be208"),
                            ColumnType = 3,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(238),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Xiah's World",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(239)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be209"),
                            ColumnType = 3,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(249),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Ayu's Corner",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(251)
                        },
                        new
                        {
                            Id = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be210"),
                            ColumnType = 3,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(258),
                            IconUrl = "",
                            SubTitle = "",
                            Title = "Sights and Visions",
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 463, DateTimeKind.Utc).AddTicks(259)
                        });
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Comment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<bool>("LikesEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MaskUser")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("PostId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Like", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("PostId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Author")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("BannerUrl")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<Guid?>("ColumnId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<int>("Comments")
                        .HasColumnType("int");

                    b.Property<bool>("CommentsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(5000);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsStarred")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Layout")
                        .HasColumnType("varchar(75) CHARACTER SET utf8mb4")
                        .HasMaxLength(75);

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<bool>("LikesEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MembersOnly")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("RatingsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<string>("Title")
                        .HasColumnType("varchar(75) CHARACTER SET utf8mb4")
                        .HasMaxLength(75);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13febb22-f596-4b1e-b0a8-b11ad54be200"),
                            Author = "Goshen",
                            ColumnId = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                            Comments = 0,
                            CommentsEnabled = false,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(1888),
                            IsStarred = false,
                            Likes = 0,
                            LikesEnabled = false,
                            MembersOnly = false,
                            Rating = 0m,
                            RatingsEnabled = false,
                            SubTitle = "Project 1",
                            Title = "Project 1",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(1909),
                            Views = 0
                        },
                        new
                        {
                            Id = new Guid("13febb22-f596-4b1e-b0a8-b11ad54be201"),
                            Author = "Tere",
                            ColumnId = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                            Comments = 0,
                            CommentsEnabled = false,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(7190),
                            IsStarred = false,
                            Likes = 0,
                            LikesEnabled = false,
                            MembersOnly = false,
                            Rating = 0m,
                            RatingsEnabled = false,
                            SubTitle = "Project 2",
                            Title = "Project 2",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(7207),
                            Views = 0
                        },
                        new
                        {
                            Id = new Guid("13febb22-f596-4b1e-b0a8-b11ad54be202"),
                            Author = "Aya",
                            ColumnId = new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                            Comments = 0,
                            CommentsEnabled = false,
                            CreatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(7324),
                            IsStarred = false,
                            Likes = 0,
                            LikesEnabled = false,
                            MembersOnly = false,
                            Rating = 0m,
                            RatingsEnabled = false,
                            SubTitle = "Project 3",
                            Title = "Project 3",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 2, 18, 5, 53, 7, 467, DateTimeKind.Utc).AddTicks(7325),
                            Views = 0
                        });
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Rating", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsCounted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MaskUser")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("PostId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.UserLogin", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<int>("LoginType")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Attachment", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Comment", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Like", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Column", "Column")
                        .WithMany()
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Rating", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.UserLogin", b =>
                {
                    b.HasOne("GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}