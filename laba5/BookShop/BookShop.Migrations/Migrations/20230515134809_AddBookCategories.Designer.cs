﻿// <auto-generated />
using System;
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Migrations.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20230515134809_AddBookCategories")]
    partial class AddBookCategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShop.DAL.Entities.Author", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            ID = new Guid("b125bb8a-9ae3-44ff-80fc-8c288267243b"),
                            FirstName = "Maryann",
                            LastName = "Heaney"
                        },
                        new
                        {
                            ID = new Guid("ded6da13-017b-44e7-88c8-2378b7bd070e"),
                            FirstName = "Randal",
                            LastName = "Kihn"
                        },
                        new
                        {
                            ID = new Guid("af7031d3-bdea-4c7f-9fa2-8c2bd6df8242"),
                            FirstName = "Jonathan",
                            LastName = "Heidenreich"
                        },
                        new
                        {
                            ID = new Guid("3a2d791e-583a-4662-ab51-9d8b1cbfdbcd"),
                            FirstName = "Loretta",
                            LastName = "Bartoletti"
                        },
                        new
                        {
                            ID = new Guid("f4b3a56c-26bd-46f7-9a52-f56debb06b72"),
                            FirstName = "Rufus",
                            LastName = "Reilly"
                        },
                        new
                        {
                            ID = new Guid("7fd3fd55-7dc8-4b43-9bb4-f4b2c7a6774f"),
                            FirstName = "Martha",
                            LastName = "Gibson"
                        },
                        new
                        {
                            ID = new Guid("72e7d6be-375c-4e61-8748-ad48e9e3fa0a"),
                            FirstName = "Stephanie",
                            LastName = "Volkman"
                        },
                        new
                        {
                            ID = new Guid("425cc76a-51e2-4936-9e2d-45adb6eaeab7"),
                            FirstName = "Aaron",
                            LastName = "Reynolds"
                        },
                        new
                        {
                            ID = new Guid("8ce39313-8048-461b-a24a-4407d7ffa279"),
                            FirstName = "Gayle",
                            LastName = "Abshire"
                        },
                        new
                        {
                            ID = new Guid("b987dbac-c5f1-47f1-a779-6ae36a67ce9f"),
                            FirstName = "Sheryl",
                            LastName = "Johnson"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AgeRestriction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Copies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("EditionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = new Guid("8a0e1647-4184-4b69-909b-21a5c59c70fe"),
                            AgeRestriction = "Adult",
                            AuthorId = new Guid("b125bb8a-9ae3-44ff-80fc-8c288267243b"),
                            Copies = 1973523133,
                            Description = "repudiandae",
                            EditionType = "Normal",
                            Price = 0.712783271989850m,
                            ReleaseDate = new DateTime(2023, 4, 23, 12, 8, 56, 777, DateTimeKind.Local).AddTicks(1043),
                            Title = "illo"
                        },
                        new
                        {
                            ID = new Guid("208728cf-e2a2-41aa-9368-c3d512b33fc3"),
                            AgeRestriction = "Teen",
                            AuthorId = new Guid("ded6da13-017b-44e7-88c8-2378b7bd070e"),
                            Copies = 1255373519,
                            Description = "sequi",
                            EditionType = "Normal",
                            Price = 0.5101704643303390m,
                            ReleaseDate = new DateTime(2023, 5, 7, 3, 18, 17, 503, DateTimeKind.Local).AddTicks(8254),
                            Title = "ut"
                        },
                        new
                        {
                            ID = new Guid("51c8501b-74ea-4265-ba03-d9be0ac36146"),
                            AgeRestriction = "Minor",
                            AuthorId = new Guid("af7031d3-bdea-4c7f-9fa2-8c2bd6df8242"),
                            Copies = 875023876,
                            Description = "Est doloribus animi aspernatur ut.\nSunt doloremque quam aspernatur.\nPerferendis fuga aliquam quae error quod repudiandae dolore tenetur.\nMolestiae incidunt sed dolor vitae tempora earum.\nAlias dolor a iure est voluptatem fugit.",
                            EditionType = "Gold",
                            Price = 0.01116485524477010m,
                            ReleaseDate = new DateTime(2022, 11, 18, 14, 44, 13, 266, DateTimeKind.Local).AddTicks(3351),
                            Title = "ipsam"
                        },
                        new
                        {
                            ID = new Guid("94728229-d603-4e2a-8f19-8cae9ea59f20"),
                            AgeRestriction = "Minor",
                            AuthorId = new Guid("3a2d791e-583a-4662-ab51-9d8b1cbfdbcd"),
                            Copies = -2111999642,
                            Description = "repudiandae",
                            EditionType = "Normal",
                            Price = 0.114046987701470m,
                            ReleaseDate = new DateTime(2022, 10, 1, 14, 26, 9, 535, DateTimeKind.Local).AddTicks(9310),
                            Title = "aut"
                        },
                        new
                        {
                            ID = new Guid("c926d52d-62ef-4d81-8385-338b8956c5f7"),
                            AgeRestriction = "Adult",
                            AuthorId = new Guid("f4b3a56c-26bd-46f7-9a52-f56debb06b72"),
                            Copies = -1176790940,
                            Description = "Facilis maxime non non incidunt eius cumque inventore.\nEst sit autem minus sint rerum illo.",
                            EditionType = "Normal",
                            Price = 0.9700161129182830m,
                            ReleaseDate = new DateTime(2022, 10, 15, 20, 12, 59, 894, DateTimeKind.Local).AddTicks(2501),
                            Title = "explicabo"
                        },
                        new
                        {
                            ID = new Guid("d0f1cd48-2741-4d3d-9395-6cbc683f5d2c"),
                            AgeRestriction = "Minor",
                            AuthorId = new Guid("7fd3fd55-7dc8-4b43-9bb4-f4b2c7a6774f"),
                            Copies = -1192479933,
                            Description = "Dolorem provident soluta doloremque labore minus eos consequuntur explicabo. Atque eum eius atque consectetur optio fuga magni. Totam nulla possimus. Earum rerum autem ex neque quos beatae.",
                            EditionType = "Promo",
                            Price = 0.9654429640078880m,
                            ReleaseDate = new DateTime(2022, 11, 20, 1, 40, 32, 571, DateTimeKind.Local).AddTicks(4235),
                            Title = "impedit"
                        },
                        new
                        {
                            ID = new Guid("9ee007a6-e224-4dfa-b364-61401523a21a"),
                            AgeRestriction = "Teen",
                            AuthorId = new Guid("72e7d6be-375c-4e61-8748-ad48e9e3fa0a"),
                            Copies = 17579283,
                            Description = "Ex delectus quia eum repellat ab aliquam dolor.\nAdipisci velit et.\nCorporis dolorem voluptatem id.\nPerferendis suscipit ut sunt qui.\nDolorem sit voluptatem error error occaecati consequatur.\nOmnis recusandae quia nulla quia id ut culpa.",
                            EditionType = "Gold",
                            Price = 0.3255572582775080m,
                            ReleaseDate = new DateTime(2022, 11, 7, 10, 41, 52, 547, DateTimeKind.Local).AddTicks(9441),
                            Title = "corrupti"
                        },
                        new
                        {
                            ID = new Guid("c3e44c54-5b6d-4d02-86d5-542deda63925"),
                            AgeRestriction = "Minor",
                            AuthorId = new Guid("425cc76a-51e2-4936-9e2d-45adb6eaeab7"),
                            Copies = -1832437662,
                            Description = "Laboriosam alias excepturi sequi accusantium id at tempora ut non. Ut deserunt cupiditate cum vero quaerat alias assumenda optio. Natus ut distinctio consequatur asperiores officiis et odio.",
                            EditionType = "Gold",
                            Price = 0.14232120811360m,
                            ReleaseDate = new DateTime(2022, 7, 28, 0, 11, 36, 575, DateTimeKind.Local).AddTicks(5944),
                            Title = "explicabo"
                        },
                        new
                        {
                            ID = new Guid("47f48838-4e31-43ba-ba2d-4438ce88bc03"),
                            AgeRestriction = "Minor",
                            AuthorId = new Guid("8ce39313-8048-461b-a24a-4407d7ffa279"),
                            Copies = -1020617682,
                            Description = "Accusamus aut enim.",
                            EditionType = "Promo",
                            Price = 0.1055123422380130m,
                            ReleaseDate = new DateTime(2023, 4, 8, 4, 54, 49, 144, DateTimeKind.Local).AddTicks(1668),
                            Title = "ut"
                        },
                        new
                        {
                            ID = new Guid("6c6cfe2d-5422-453c-9a33-bbf196c5b1f5"),
                            AgeRestriction = "Teen",
                            AuthorId = new Guid("b987dbac-c5f1-47f1-a779-6ae36a67ce9f"),
                            Copies = -802658577,
                            Description = "Tenetur et possimus perspiciatis reiciendis rem id. Neque eum aut maiores veniam quasi blanditiis et. Asperiores magni eum tempora laudantium soluta. Iure dolorum quia voluptatem voluptates et labore iste qui impedit. Explicabo consequatur dolor.",
                            EditionType = "Promo",
                            Price = 0.8105701997163920m,
                            ReleaseDate = new DateTime(2022, 9, 2, 17, 31, 38, 518, DateTimeKind.Local).AddTicks(5565),
                            Title = "aut"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.BookCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            ID = new Guid("e81633e0-c88c-44f4-85d4-26f15812f5c7"),
                            BookId = new Guid("8a0e1647-4184-4b69-909b-21a5c59c70fe"),
                            CategoryId = new Guid("44e5bbe1-5de0-4727-b710-4d4821086525")
                        },
                        new
                        {
                            ID = new Guid("dc567919-3a5b-48eb-8051-d424da937be5"),
                            BookId = new Guid("208728cf-e2a2-41aa-9368-c3d512b33fc3"),
                            CategoryId = new Guid("66fed8ea-7ed1-497b-899a-33952dccf4f7")
                        },
                        new
                        {
                            ID = new Guid("1eac508e-cd86-4b7e-b233-f8749cc21a4b"),
                            BookId = new Guid("51c8501b-74ea-4265-ba03-d9be0ac36146"),
                            CategoryId = new Guid("e2d30c4f-16a6-49b1-a7d6-d456dae4214b")
                        },
                        new
                        {
                            ID = new Guid("37cfd3f9-3ce2-4fca-8afe-bb805f03b3c6"),
                            BookId = new Guid("94728229-d603-4e2a-8f19-8cae9ea59f20"),
                            CategoryId = new Guid("87d2092b-25a4-488c-8aa3-009f1af2f1fb")
                        },
                        new
                        {
                            ID = new Guid("110c06bc-f316-4c9c-a857-5e6679067707"),
                            BookId = new Guid("c926d52d-62ef-4d81-8385-338b8956c5f7"),
                            CategoryId = new Guid("50fb19c9-622d-486f-acb0-b6ca4afc3ccf")
                        },
                        new
                        {
                            ID = new Guid("afd17a8a-4cf4-487a-b9bf-8bae57e1a83c"),
                            BookId = new Guid("d0f1cd48-2741-4d3d-9395-6cbc683f5d2c"),
                            CategoryId = new Guid("bc255372-a1b2-4178-b4a8-17181c1d54ae")
                        },
                        new
                        {
                            ID = new Guid("cfb401de-a377-47f9-a7d2-ab8e8f71a62a"),
                            BookId = new Guid("9ee007a6-e224-4dfa-b364-61401523a21a"),
                            CategoryId = new Guid("11335047-fec0-46d0-9146-a89d6eb493e6")
                        },
                        new
                        {
                            ID = new Guid("590f8ddf-12a4-47cf-8e83-285ed04cfd24"),
                            BookId = new Guid("c3e44c54-5b6d-4d02-86d5-542deda63925"),
                            CategoryId = new Guid("b5e2ef01-4dc2-4e4d-abde-23b7090ccf05")
                        },
                        new
                        {
                            ID = new Guid("8fab705d-17e4-4105-9e70-d98488541705"),
                            BookId = new Guid("47f48838-4e31-43ba-ba2d-4438ce88bc03"),
                            CategoryId = new Guid("4fde3afd-d835-4183-9eea-bf164763bb42")
                        },
                        new
                        {
                            ID = new Guid("72996fcb-ee0a-4b0e-86ed-690e12530b74"),
                            BookId = new Guid("6c6cfe2d-5422-453c-9a33-bbf196c5b1f5"),
                            CategoryId = new Guid("5a6b551f-a144-4a66-9257-dc579aa5ba8b")
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = new Guid("44e5bbe1-5de0-4727-b710-4d4821086525"),
                            Name = "Ergonomic Soft Table"
                        },
                        new
                        {
                            ID = new Guid("66fed8ea-7ed1-497b-899a-33952dccf4f7"),
                            Name = "Handmade Cotton Fish"
                        },
                        new
                        {
                            ID = new Guid("e2d30c4f-16a6-49b1-a7d6-d456dae4214b"),
                            Name = "Handmade Fresh Mouse"
                        },
                        new
                        {
                            ID = new Guid("87d2092b-25a4-488c-8aa3-009f1af2f1fb"),
                            Name = "Licensed Soft Hat"
                        },
                        new
                        {
                            ID = new Guid("50fb19c9-622d-486f-acb0-b6ca4afc3ccf"),
                            Name = "Refined Frozen Chips"
                        },
                        new
                        {
                            ID = new Guid("bc255372-a1b2-4178-b4a8-17181c1d54ae"),
                            Name = "Handmade Granite Mouse"
                        },
                        new
                        {
                            ID = new Guid("11335047-fec0-46d0-9146-a89d6eb493e6"),
                            Name = "Sleek Rubber Towels"
                        },
                        new
                        {
                            ID = new Guid("b5e2ef01-4dc2-4e4d-abde-23b7090ccf05"),
                            Name = "Sleek Concrete Ball"
                        },
                        new
                        {
                            ID = new Guid("4fde3afd-d835-4183-9eea-bf164763bb42"),
                            Name = "Fantastic Soft Car"
                        },
                        new
                        {
                            ID = new Guid("5a6b551f-a144-4a66-9257-dc579aa5ba8b"),
                            Name = "Sleek Plastic Sausages"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.HasOne("BookShop.DAL.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.BookCategory", b =>
                {
                    b.HasOne("BookShop.DAL.Entities.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.DAL.Entities.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Category", b =>
                {
                    b.Navigation("BookCategories");
                });
#pragma warning restore 612, 618
        }
    }
}