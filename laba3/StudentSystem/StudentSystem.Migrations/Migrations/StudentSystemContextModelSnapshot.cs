﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    partial class StudentSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSystem.DAL.Entities.Course", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"),
                            Description = "magni",
                            EndDate = new DateTime(2023, 5, 15, 11, 14, 17, 919, DateTimeKind.Local).AddTicks(7787),
                            Name = "sed",
                            Price = 0.970806794884840m,
                            StartDate = new DateTime(2023, 12, 28, 7, 49, 34, 539, DateTimeKind.Local).AddTicks(1609)
                        },
                        new
                        {
                            ID = new Guid("ece3f119-48d2-4377-b665-c10790a4f497"),
                            Description = "Et sed officia eos accusamus atque voluptatibus. Aut veritatis cum dolores quo. Atque dolores enim eum et numquam aut amet non sit.",
                            EndDate = new DateTime(2023, 6, 16, 13, 27, 21, 557, DateTimeKind.Local).AddTicks(7783),
                            Name = "eligendi",
                            Price = 0.8275002601482640m,
                            StartDate = new DateTime(2023, 6, 28, 21, 16, 49, 420, DateTimeKind.Local).AddTicks(7327)
                        },
                        new
                        {
                            ID = new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"),
                            Description = "Odio ut ab recusandae.",
                            EndDate = new DateTime(2024, 5, 9, 18, 10, 21, 866, DateTimeKind.Local).AddTicks(5458),
                            Name = "atque",
                            Price = 0.6555891310643010m,
                            StartDate = new DateTime(2023, 5, 31, 14, 7, 7, 938, DateTimeKind.Local).AddTicks(6846)
                        },
                        new
                        {
                            ID = new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"),
                            Description = "est",
                            EndDate = new DateTime(2023, 6, 27, 12, 8, 15, 28, DateTimeKind.Local).AddTicks(2218),
                            Name = "a",
                            Price = 0.4151486365307090m,
                            StartDate = new DateTime(2024, 2, 19, 16, 34, 20, 931, DateTimeKind.Local).AddTicks(4193)
                        },
                        new
                        {
                            ID = new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"),
                            Description = "Commodi sint nam voluptas.",
                            EndDate = new DateTime(2023, 9, 23, 7, 32, 54, 518, DateTimeKind.Local).AddTicks(5505),
                            Name = "enim",
                            Price = 0.3222355035509850m,
                            StartDate = new DateTime(2023, 5, 29, 13, 19, 1, 434, DateTimeKind.Local).AddTicks(4377)
                        },
                        new
                        {
                            ID = new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"),
                            Description = "maxime",
                            EndDate = new DateTime(2023, 8, 29, 8, 9, 31, 324, DateTimeKind.Local).AddTicks(1236),
                            Name = "eos",
                            Price = 0.9855314801850370m,
                            StartDate = new DateTime(2023, 11, 12, 23, 6, 59, 311, DateTimeKind.Local).AddTicks(128)
                        },
                        new
                        {
                            ID = new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"),
                            Description = "Deserunt ea tenetur nostrum voluptas quidem ab maiores cupiditate eum.\nRepellat accusamus molestiae cupiditate eius molestias deserunt.\nAnimi ex error neque.\nAccusantium voluptatem repellendus impedit omnis vitae quia fugit at omnis.\nBeatae dolorem aut perferendis.\nTempora iure in quis voluptas impedit adipisci.",
                            EndDate = new DateTime(2023, 5, 28, 14, 38, 35, 656, DateTimeKind.Local).AddTicks(1883),
                            Name = "minima",
                            Price = 0.0696733317853070m,
                            StartDate = new DateTime(2024, 4, 29, 22, 16, 33, 435, DateTimeKind.Local).AddTicks(8755)
                        },
                        new
                        {
                            ID = new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"),
                            Description = "Quibusdam sed eaque nobis ad nam eligendi repudiandae. Aperiam dolorem voluptatum ut ut vitae delectus quibusdam. Enim laboriosam occaecati aperiam sed.",
                            EndDate = new DateTime(2024, 2, 2, 10, 45, 49, 57, DateTimeKind.Local).AddTicks(1154),
                            Name = "minus",
                            Price = 0.8409123330450940m,
                            StartDate = new DateTime(2024, 2, 18, 17, 37, 55, 618, DateTimeKind.Local).AddTicks(8322)
                        },
                        new
                        {
                            ID = new Guid("8559bd31-6af8-4350-9925-bb37336007c3"),
                            Description = "Quia debitis aspernatur accusamus rerum aut quae nihil ea.",
                            EndDate = new DateTime(2023, 11, 24, 3, 44, 59, 862, DateTimeKind.Local).AddTicks(1727),
                            Name = "eaque",
                            Price = 0.3100244091938440m,
                            StartDate = new DateTime(2024, 1, 6, 14, 50, 10, 64, DateTimeKind.Local).AddTicks(3635)
                        },
                        new
                        {
                            ID = new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"),
                            Description = "ad",
                            EndDate = new DateTime(2024, 5, 6, 2, 38, 17, 524, DateTimeKind.Local).AddTicks(5280),
                            Name = "odio",
                            Price = 0.1221514291174860m,
                            StartDate = new DateTime(2024, 2, 17, 22, 47, 30, 260, DateTimeKind.Local).AddTicks(2102)
                        });
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Homework", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Homeworks");

                    b.HasData(
                        new
                        {
                            ID = new Guid("eac0cdcd-bcc8-4c6f-9bee-f84a121f68ab"),
                            Content = "reiciendis",
                            ContentType = "Pdf",
                            CourseId = new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"),
                            StudentId = new Guid("424f4c5c-342d-4505-bd50-b796d3948537"),
                            SubmissionTime = new DateTime(2024, 3, 3, 12, 46, 35, 305, DateTimeKind.Local).AddTicks(8910)
                        },
                        new
                        {
                            ID = new Guid("9e014769-87ad-47bd-a704-d80e1a5c6e0d"),
                            Content = "Explicabo omnis sed ut et sed sit corrupti.",
                            ContentType = "Aplication",
                            CourseId = new Guid("ece3f119-48d2-4377-b665-c10790a4f497"),
                            StudentId = new Guid("d4369c9c-1a31-4903-b077-4e6e4f929953"),
                            SubmissionTime = new DateTime(2024, 4, 1, 22, 27, 37, 648, DateTimeKind.Local).AddTicks(2764)
                        },
                        new
                        {
                            ID = new Guid("ea4d8d49-bc9e-44ee-a7e7-1f2d3ff81088"),
                            Content = "Quia possimus recusandae recusandae consequuntur ipsum dicta possimus at et. Impedit asperiores id id aut eos ea debitis vero consequatur. Aut qui ipsam vel. Veniam et nemo autem nostrum rerum voluptatem beatae dolorem.",
                            ContentType = "Zip",
                            CourseId = new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"),
                            StudentId = new Guid("95a90528-198c-410e-9c69-b5ff5bbee33b"),
                            SubmissionTime = new DateTime(2023, 7, 22, 12, 22, 36, 667, DateTimeKind.Local).AddTicks(2307)
                        },
                        new
                        {
                            ID = new Guid("d76038ef-e7bc-4ad8-b0dc-367eeaa0eef8"),
                            Content = "Libero ducimus possimus qui voluptas enim consequatur occaecati libero.\nCumque itaque quos odit.\nAut officia et quis adipisci dolore eligendi.\nConsequatur id eligendi exercitationem iure dignissimos.",
                            ContentType = "Zip",
                            CourseId = new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"),
                            StudentId = new Guid("e9ec51cb-735c-4c9a-a461-64f24f66307c"),
                            SubmissionTime = new DateTime(2024, 3, 13, 11, 50, 7, 805, DateTimeKind.Local).AddTicks(8874)
                        },
                        new
                        {
                            ID = new Guid("be97f850-5e09-4e25-b897-1a8134926d0d"),
                            Content = "cumque",
                            ContentType = "Aplication",
                            CourseId = new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"),
                            StudentId = new Guid("df6533ac-bfcd-4a18-a4d7-4858b70a1ed8"),
                            SubmissionTime = new DateTime(2024, 4, 12, 6, 16, 53, 389, DateTimeKind.Local).AddTicks(1472)
                        },
                        new
                        {
                            ID = new Guid("90a0a3dc-7d6c-4fd7-b7eb-c2ba11b29a11"),
                            Content = "Amet labore autem voluptas voluptatem dignissimos earum non qui. Sunt iusto accusantium aperiam ut eos facere. In facere sint occaecati distinctio minima molestiae. Asperiores minus ut et culpa. Dolore sunt provident.",
                            ContentType = "Zip",
                            CourseId = new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"),
                            StudentId = new Guid("f9bdeab3-dd65-4090-ae38-19455e52626f"),
                            SubmissionTime = new DateTime(2023, 7, 4, 22, 32, 17, 394, DateTimeKind.Local).AddTicks(5609)
                        },
                        new
                        {
                            ID = new Guid("33cf8263-21c6-41d0-ad96-ba6a07843bae"),
                            Content = "Delectus aliquid vel autem sed explicabo tenetur autem culpa.\nDoloremque occaecati consequatur molestiae porro temporibus.\nCorrupti modi est ipsa aut similique aspernatur.\nCorporis dolorum accusantium hic.\nDoloremque tempore est sit nulla molestiae pariatur.",
                            ContentType = "Aplication",
                            CourseId = new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"),
                            StudentId = new Guid("7c1d9057-1d16-4768-be6e-dc86bea68bcc"),
                            SubmissionTime = new DateTime(2023, 11, 23, 0, 43, 23, 595, DateTimeKind.Local).AddTicks(4698)
                        },
                        new
                        {
                            ID = new Guid("d58f5980-662d-4ae0-9320-2ede7524025a"),
                            Content = "consequatur",
                            ContentType = "Pdf",
                            CourseId = new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"),
                            StudentId = new Guid("ceac166c-814c-4e82-9fc8-696f2b1f409d"),
                            SubmissionTime = new DateTime(2023, 12, 23, 22, 5, 56, 433, DateTimeKind.Local).AddTicks(2992)
                        },
                        new
                        {
                            ID = new Guid("0a5f19a0-ef72-4b4f-8d1b-eaefbbb3125c"),
                            Content = "Ad et quidem sit corrupti.",
                            ContentType = "Aplication",
                            CourseId = new Guid("8559bd31-6af8-4350-9925-bb37336007c3"),
                            StudentId = new Guid("91752c83-c6ab-45b9-8fef-ec0513acb86e"),
                            SubmissionTime = new DateTime(2023, 12, 31, 23, 10, 46, 84, DateTimeKind.Local).AddTicks(4427)
                        },
                        new
                        {
                            ID = new Guid("8761b7bd-a488-43d3-aa11-d23b4f43343c"),
                            Content = "saepe",
                            ContentType = "Zip",
                            CourseId = new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"),
                            StudentId = new Guid("aa6b27d0-fd3d-4d47-ba93-a56d4169c0d7"),
                            SubmissionTime = new DateTime(2023, 7, 21, 7, 10, 9, 327, DateTimeKind.Local).AddTicks(6727)
                        });
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Resource", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ID = new Guid("47b758da-b6da-4a42-ba5f-11e6d4f71c03"),
                            CourseId = new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"),
                            Name = "omnis",
                            ResourceType = "Video",
                            Url = "http://kristopher.info"
                        },
                        new
                        {
                            ID = new Guid("6452c447-9151-4e29-a212-301263c09ab2"),
                            CourseId = new Guid("ece3f119-48d2-4377-b665-c10790a4f497"),
                            Name = "expedita",
                            ResourceType = "Video",
                            Url = "http://jordane.name"
                        },
                        new
                        {
                            ID = new Guid("9e6e89a8-cfb5-49dc-99a5-5f4776c0233b"),
                            CourseId = new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"),
                            Name = "minima",
                            ResourceType = "Video",
                            Url = "http://jettie.com"
                        },
                        new
                        {
                            ID = new Guid("44b81464-4c1a-4b93-b0c9-a077e67b6a26"),
                            CourseId = new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"),
                            Name = "nesciunt",
                            ResourceType = "Other",
                            Url = "https://abel.name"
                        },
                        new
                        {
                            ID = new Guid("2a7659b2-2a91-459e-8988-4f1f78c6e44a"),
                            CourseId = new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"),
                            Name = "incidunt",
                            ResourceType = "Other",
                            Url = "https://emilie.net"
                        },
                        new
                        {
                            ID = new Guid("bfcae787-869a-4811-9d86-48b11043775e"),
                            CourseId = new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"),
                            Name = "necessitatibus",
                            ResourceType = "Document",
                            Url = "https://larry.name"
                        },
                        new
                        {
                            ID = new Guid("e38588b6-55e3-4d0e-b097-508d99755beb"),
                            CourseId = new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"),
                            Name = "sapiente",
                            ResourceType = "Video",
                            Url = "https://thomas.name"
                        },
                        new
                        {
                            ID = new Guid("f107d6a4-b0f6-4adf-9639-a6b3aeb26a6f"),
                            CourseId = new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"),
                            Name = "accusamus",
                            ResourceType = "Video",
                            Url = "https://winnifred.net"
                        },
                        new
                        {
                            ID = new Guid("2bc57d4f-3276-428d-9e3f-78eeec433606"),
                            CourseId = new Guid("8559bd31-6af8-4350-9925-bb37336007c3"),
                            Name = "a",
                            ResourceType = "Document",
                            Url = "https://stanley.net"
                        },
                        new
                        {
                            ID = new Guid("25ec3571-fbfe-4ab8-9dcb-23a5e084361b"),
                            CourseId = new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"),
                            Name = "delectus",
                            ResourceType = "Document",
                            Url = "http://mallory.org"
                        });
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = new Guid("424f4c5c-342d-4505-bd50-b796d3948537"),
                            Birthday = new DateTime(2022, 6, 15, 20, 56, 40, 7, DateTimeKind.Local).AddTicks(6781),
                            Name = "Brad",
                            PhoneNumber = "536.785.6308 x36939",
                            RegisteredOn = new DateTime(2023, 4, 3, 12, 7, 59, 842, DateTimeKind.Local).AddTicks(407)
                        },
                        new
                        {
                            ID = new Guid("d4369c9c-1a31-4903-b077-4e6e4f929953"),
                            Birthday = new DateTime(2023, 1, 24, 23, 13, 47, 797, DateTimeKind.Local).AddTicks(2342),
                            Name = "Sophie",
                            PhoneNumber = "1-686-722-7498 x9299",
                            RegisteredOn = new DateTime(2022, 7, 1, 7, 0, 20, 325, DateTimeKind.Local).AddTicks(1597)
                        },
                        new
                        {
                            ID = new Guid("95a90528-198c-410e-9c69-b5ff5bbee33b"),
                            Birthday = new DateTime(2022, 8, 28, 23, 32, 4, 317, DateTimeKind.Local).AddTicks(2347),
                            Name = "Freddie",
                            PhoneNumber = "(675) 410-7624 x638",
                            RegisteredOn = new DateTime(2022, 9, 1, 15, 9, 12, 598, DateTimeKind.Local).AddTicks(3200)
                        },
                        new
                        {
                            ID = new Guid("e9ec51cb-735c-4c9a-a461-64f24f66307c"),
                            Birthday = new DateTime(2023, 1, 21, 20, 38, 20, 729, DateTimeKind.Local).AddTicks(4628),
                            Name = "Colin",
                            PhoneNumber = "1-963-754-1779",
                            RegisteredOn = new DateTime(2023, 1, 18, 17, 50, 8, 230, DateTimeKind.Local).AddTicks(5747)
                        },
                        new
                        {
                            ID = new Guid("df6533ac-bfcd-4a18-a4d7-4858b70a1ed8"),
                            Birthday = new DateTime(2023, 3, 8, 1, 45, 7, 613, DateTimeKind.Local).AddTicks(7694),
                            Name = "Bryan",
                            PhoneNumber = "1-501-368-6175 x4477",
                            RegisteredOn = new DateTime(2022, 8, 13, 12, 14, 42, 811, DateTimeKind.Local).AddTicks(6504)
                        },
                        new
                        {
                            ID = new Guid("f9bdeab3-dd65-4090-ae38-19455e52626f"),
                            Birthday = new DateTime(2023, 4, 21, 7, 42, 10, 652, DateTimeKind.Local).AddTicks(5711),
                            Name = "Natasha",
                            PhoneNumber = "(681) 676-1359 x3036",
                            RegisteredOn = new DateTime(2022, 12, 6, 13, 24, 15, 397, DateTimeKind.Local).AddTicks(4537)
                        },
                        new
                        {
                            ID = new Guid("7c1d9057-1d16-4768-be6e-dc86bea68bcc"),
                            Birthday = new DateTime(2022, 11, 15, 1, 19, 0, 731, DateTimeKind.Local).AddTicks(2383),
                            Name = "Rudy",
                            PhoneNumber = "(213) 889-1976",
                            RegisteredOn = new DateTime(2022, 10, 1, 20, 54, 18, 129, DateTimeKind.Local).AddTicks(9246)
                        },
                        new
                        {
                            ID = new Guid("ceac166c-814c-4e82-9fc8-696f2b1f409d"),
                            Birthday = new DateTime(2022, 5, 24, 12, 3, 29, 11, DateTimeKind.Local).AddTicks(7394),
                            Name = "Eileen",
                            PhoneNumber = "750.776.5510 x4352",
                            RegisteredOn = new DateTime(2022, 7, 4, 5, 33, 29, 475, DateTimeKind.Local).AddTicks(3413)
                        },
                        new
                        {
                            ID = new Guid("91752c83-c6ab-45b9-8fef-ec0513acb86e"),
                            Birthday = new DateTime(2022, 5, 30, 4, 34, 43, 471, DateTimeKind.Local).AddTicks(9694),
                            Name = "Daisy",
                            PhoneNumber = "1-619-312-4033",
                            RegisteredOn = new DateTime(2022, 12, 30, 10, 38, 45, 11, DateTimeKind.Local).AddTicks(1256)
                        },
                        new
                        {
                            ID = new Guid("aa6b27d0-fd3d-4d47-ba93-a56d4169c0d7"),
                            Birthday = new DateTime(2023, 1, 27, 0, 29, 38, 289, DateTimeKind.Local).AddTicks(9592),
                            Name = "Kristopher",
                            PhoneNumber = "259-908-2229 x4167",
                            RegisteredOn = new DateTime(2022, 12, 7, 14, 36, 14, 309, DateTimeKind.Local).AddTicks(5110)
                        });
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.StudentCourse", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Homework", b =>
                {
                    b.HasOne("StudentSystem.DAL.Entities.Course", "Course")
                        .WithMany("Homeworks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.DAL.Entities.Student", "Student")
                        .WithMany("Homeworks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Resource", b =>
                {
                    b.HasOne("StudentSystem.DAL.Entities.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.DAL.Entities.Course", "Course")
                        .WithMany("StudentCources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.DAL.Entities.Student", "Student")
                        .WithMany("StudentCources")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Course", b =>
                {
                    b.Navigation("Homeworks");

                    b.Navigation("Resources");

                    b.Navigation("StudentCources");
                });

            modelBuilder.Entity("StudentSystem.DAL.Entities.Student", b =>
                {
                    b.Navigation("Homeworks");

                    b.Navigation("StudentCources");
                });
#pragma warning restore 612, 618
        }
    }
}
