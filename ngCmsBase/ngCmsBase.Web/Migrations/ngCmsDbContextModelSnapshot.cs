﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ngCmsBase.Data;

namespace ngCmsBase.Web.Migrations
{
    [DbContext(typeof(ngCmsDbContext))]
    partial class ngCmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ngCmsBase.Core.Domain.Authorization.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long>("DeletedBy");

                    b.Property<DateTime>("DeletionTime");

                    b.Property<string>("Email")
                        .HasMaxLength(128);

                    b.Property<long>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedTime");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<string>("Password");

                    b.Property<string>("Surname")
                        .HasMaxLength(64);

                    b.Property<string>("UrlSlug");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ngCmsBase.Core.Domain.Blogs.Blog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<long>("CreatedBy");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long>("DeletedBy");

                    b.Property<DateTime>("DeletionTime");

                    b.Property<long>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedTime");

                    b.Property<string>("Title");

                    b.Property<string>("UrlSlug");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
