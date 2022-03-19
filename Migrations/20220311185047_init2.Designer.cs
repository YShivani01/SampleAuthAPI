﻿// <auto-generated />
using System;
using AuthorizationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthAPI.Migrations
{
    [DbContext(typeof(UserCredentialContext))]
    [Migration("20220311185047_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorizationAPI.Models.UserCredentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BanTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Counter")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Mumbai",
                            BanTime = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Counter = 0,
                            Password = "APxCURCdC/rGOI74SPyCegLfk06JgWHrXeI8HFOAzzNcnf9w46OZf4Iv3kjM3hzpyQ==",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Delhi",
                            BanTime = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Counter = 0,
                            Password = "AKjOnxc8VRG2OKnRE0KwfmJcC6kkllJf7MxNfgadOxGArfPpOBzw6UI6oc0mFTCeHA==",
                            Username = "user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
