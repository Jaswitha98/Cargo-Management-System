// <auto-generated />
using Cargomanage.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cargomanage.DAL.Migrations
{
    [DbContext(typeof(CargoDBcontext))]
    partial class CargoDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cargomanage.Entity.Models.Cargoregister", b =>
                {
                    b.Property<string>("Emailid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MobileNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Retypepswd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emailid");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("Cargomanage.Entity.Models.Cust_details", b =>
                {
                    b.Property<int>("Sender_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reciever_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reciever_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reciever_id")
                        .HasColumnType("int");

                    b.Property<int>("Reciever_mobno")
                        .HasColumnType("int");

                    b.Property<string>("Reciever_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reciever_pincode")
                        .HasColumnType("int");

                    b.Property<string>("Sender_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_mobno")
                        .HasColumnType("int");

                    b.Property<string>("Sender_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_pincode")
                        .HasColumnType("int");

                    b.HasKey("Sender_id");

                    b.ToTable("Customer_Details");
                });

            modelBuilder.Entity("Cargomanage.Entity.Models.Transaction", b =>
                {
                    b.Property<int>("Bill_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cust_id")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Goods_Qty")
                        .HasColumnType("int");

                    b.Property<string>("Receiver_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sending_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trans_amount")
                        .HasColumnType("int");

                    b.Property<string>("Type_of_goods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bill_no");

                    b.HasIndex("Cust_id");

                    b.ToTable("Transaction_Details");
                });

            modelBuilder.Entity("Cargomanage.Entity.Models.Transaction", b =>
                {
                    b.HasOne("Cargomanage.Entity.Models.Cust_details", "Sender_id")
                        .WithMany()
                        .HasForeignKey("Cust_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender_id");
                });
#pragma warning restore 612, 618
        }
    }
}
