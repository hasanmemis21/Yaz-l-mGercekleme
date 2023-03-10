// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YazılımGercekleme.Models;

namespace YazılımGercekleme.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230105171616_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YazılımGercekleme.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Zafer CÖMERT"
                        },
                        new
                        {
                            AuthorId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Ahmet Can"
                        },
                        new
                        {
                            AuthorId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Fatih Mehmet Çelik"
                        });
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("ImageURL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/images/default.jpg");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageURL = "yazilimEvi.png",
                            Price = 0m,
                            Title = "Yazılım Evi"
                        },
                        new
                        {
                            BookId = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageURL = "nesneYonelimliProgramlama.png",
                            Price = 0m,
                            Title = "Nesne Yönelimli Programlama"
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageURL = "myaz201.png",
                            Price = 0m,
                            Title = "Yazılım Gereksinimi ve Modelleme"
                        });
                });

            modelBuilder.Entity("YazılımGercekleme.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            BookAuthorId = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 2,
                            AuthorId = 1,
                            BookId = 2
                        },
                        new
                        {
                            BookAuthorId = 3,
                            AuthorId = 1,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("YazılımGercekleme.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISSN")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0000-0000-0000");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2023);

                    b.HasKey("BookDetailId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BooksDetails");

                    b.HasData(
                        new
                        {
                            BookDetailId = 1,
                            BookId = 1,
                            Country = "Turkey",
                            Description = "Yazılım Evi",
                            Language = "Turkish",
                            Link = "https://www.youtube.com/channel/UCFkGSddGBO-f4gw1otESNqQ",
                            NumberOfPage = 35,
                            Year = 2021
                        },
                        new
                        {
                            BookDetailId = 2,
                            BookId = 2,
                            Country = "Turkey",
                            Description = "Nesne yönelimli programlama",
                            Language = "Turkish",
                            Link = "https://www.youtube.com/watch?v=fjuSAN4HTqQ&list=PLK37qYAhi0Ec8_8aX3RKHjzZvRNr-mAl3",
                            NumberOfPage = 35,
                            Year = 2021
                        },
                        new
                        {
                            BookDetailId = 3,
                            BookId = 3,
                            Country = "Turkey",
                            Description = "Yazılım Gereksinimi ve Modelleme",
                            Language = "Turkish",
                            Link = "https://www.youtube.com/watch?v=VK49Ov5i8GQ&list=PLK37qYAhi0Efy7-vlU8QSjB_nc6qPf8sJ",
                            NumberOfPage = 35,
                            Year = 2021
                        });
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("No info.");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Computer Science"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Classic"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Literature"
                        });
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Book", b =>
                {
                    b.HasOne("YazılımGercekleme.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YazılımGercekleme.Models.BookAuthor", b =>
                {
                    b.HasOne("YazılımGercekleme.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YazılımGercekleme.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("YazılımGercekleme.Models.BookDetail", b =>
                {
                    b.HasOne("YazılımGercekleme.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("YazılımGercekleme.Models.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("YazılımGercekleme.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
