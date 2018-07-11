﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedditPage.Models;

namespace RedditPage.Migrations
{
    [DbContext(typeof(PostDbContext))]
    [Migration("20180711090041_EmailUser")]
    partial class EmailUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedditPage.Models.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("PostUrl");

                    b.Property<string>("Title");

                    b.Property<int?>("UserOfPostId");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.HasIndex("UserOfPostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RedditPage.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RedditPage.Models.Post", b =>
                {
                    b.HasOne("RedditPage.Models.User", "UserOfPost")
                        .WithMany("UserPosts")
                        .HasForeignKey("UserOfPostId");
                });
#pragma warning restore 612, 618
        }
    }
}