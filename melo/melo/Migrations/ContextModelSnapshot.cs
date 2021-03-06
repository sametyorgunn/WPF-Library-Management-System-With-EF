// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using melo.Model;

namespace melo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("melo.Model.Login", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("logins");
                });

            modelBuilder.Entity("melo.Model.Publisher", b =>
                {
                    b.Property<int>("publisher_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("publishermail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publishername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publisherphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("publisher_id");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("melo.Model.author", b =>
                {
                    b.Property<int>("author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("author_age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_books")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_life")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("author_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("author_id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("melo.Model.book", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("book_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_page")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_writer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("book_id");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
