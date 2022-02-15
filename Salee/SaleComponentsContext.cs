#nullable disable

using Microsoft.EntityFrameworkCore;

namespace Salee
{
    public partial class SaleComponentsContext : DbContext
    {
        public SaleComponentsContext()
        {
        }

        public SaleComponentsContext(DbContextOptions<SaleComponentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComposCongsign> ComposCongsigns { get; set; }
        public virtual DbSet<Counterparty> Counterparties { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<ListSale> ListSales { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Sum> Sums { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Сonsignment> Сonsignments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // Директива #warning
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BF5FGRD\\SQLEXPRESS;Database=SaleComponents;Trusted_Connection=True;");
#pragma warning restore CS1030 // Директива #warning
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>(entity =>
            {
                entity.ToTable("Basket");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdListPurNavigation)
                    .WithMany(p => p.Baskets)
                    .HasForeignKey(d => d.IdListPur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Basket_List_Sale");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_Components_1");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasOne(d => d.IdCategoriNavigation)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.IdCategori)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Components_Categories");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Components_Type");
            });

            modelBuilder.Entity<ComposCongsign>(entity =>
            {
                entity.ToTable("Compos_Congsign");

                entity.Property(e => e.IdCompon).HasColumnName("Id_Compon");

                entity.Property(e => e.IdConsigm).HasColumnName("Id_Consigm");

                entity.Property(e => e.IdCounterpart).HasColumnName("Id_Counterpart");

                entity.Property(e => e.IdSotrud).HasColumnName("Id_Sotrud");

                entity.HasOne(d => d.IdConsigmNavigation)
                    .WithMany(p => p.ComposCongsigns)
                    .HasForeignKey(d => d.IdConsigm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compos_Congsign_Сonsignment");

                entity.HasOne(d => d.IdCounterpartNavigation)
                    .WithMany(p => p.ComposCongsigns)
                    .HasForeignKey(d => d.IdCounterpart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compos_Congsign_Counterparties");
            });

            modelBuilder.Entity<Counterparty>(entity =>
            {
                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("Contact_Phone");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("INN");

                entity.Property(e => e.NameOrganization)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Name_Organization");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.Login)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_Users");
            });

            modelBuilder.Entity<ListSale>(entity =>
            {
                entity.ToTable("List_Sale");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdSaleNavigation)
                    .WithMany(p => p.ListSales)
                    .HasForeignKey(d => d.IdSale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_List_Sale_Sale");

                entity.HasOne(d => d.IdentificNavigation)
                    .WithMany(p => p.ListSales)
                    .HasForeignKey(d => d.Identific)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_List_Sale_Purchase");

                entity.HasOne(d => d.Identific1)
                    .WithMany(p => p.ListSales)
                    .HasForeignKey(d => d.Identific)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_List_Sale_Sum");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.Property(e => e.Privilege1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Privilege");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sale_Components");

                entity.HasOne(d => d.Name1)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sale_Services");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_Services_1");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasOne(d => d.IdCategoriNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.IdCategori)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Categories");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(205);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Login).HasMaxLength(15);

                entity.Property(e => e.MiddleName).HasMaxLength(25);

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Photo).IsRequired();

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.Login)
                    .HasConstraintName("FK_Staffs_Users1");
            });

            modelBuilder.Entity<Sum>(entity =>
            {
                entity.ToTable("Sum");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Sum1).HasColumnName("Sum");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.Property(e => e.Login).HasMaxLength(15);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdPrivelegeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdPrivelege)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Privileges1");
            });

            modelBuilder.Entity<Сonsignment>(entity =>
            {
                entity.ToTable("Сonsignment");

                entity.Property(e => e.Data).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
