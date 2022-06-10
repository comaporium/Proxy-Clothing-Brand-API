using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProxyAPI.Models
{
    public partial class OnlineShopContext : DbContext
    {
        public OnlineShopContext()
        {
        }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikli> Artiklis { get; set; }
        public virtual DbSet<Boje> Bojes { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Korpa> Korpas { get; set; }
        public virtual DbSet<Nabavljaci> Nabavljacis { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<Slike> Slikes { get; set; }
        public virtual DbSet<Stanje> Stanjes { get; set; }
        public virtual DbSet<Velicine> Velicines { get; set; }
        public virtual DbSet<VrsteArtikla> VrsteArtiklas { get; set; }
        public virtual DbSet<VwSlikeArtikala> VwSlikeArtikalas { get; set; }
        public virtual DbSet<VwStanjeArtikala> VwStanjeArtikalas { get; set; }
        public virtual DbSet<VwSveOartiklima> VwSveOartiklimas { get; set; }
        public virtual DbSet<VwZadnjiPetAccesory> VwZadnjiPetAccesories { get; set; }
        public virtual DbSet<VwZadnjiPetArtikli> VwZadnjiPetArtiklis { get; set; }
        public virtual DbSet<VwZadnjiPetBot> VwZadnjiPetBots { get; set; }
        public virtual DbSet<VwZadnjiPetSneaker> VwZadnjiPetSneakers { get; set; }
        public virtual DbSet<VwZadnjiPetTop> VwZadnjiPetTops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=OnlineShop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artikli>(entity =>
            {
                entity.HasKey(e => e.Idartikla)
                    .HasName("PK__Artikli__C09BA51B66049C72");

                entity.ToTable("Artikli");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.GlavnaSlika).HasColumnName("glavnaSlika");

                entity.Property(e => e.Idboje).HasColumnName("IDBoje");

                entity.Property(e => e.Idnabavljaca).HasColumnName("IDNabavljaca");

                entity.Property(e => e.IdvrsteArtikla).HasColumnName("IDVrsteArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.VrijemeDodavanja)
                    .HasColumnType("datetime")
                    .HasColumnName("vrijeme_dodavanja")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdbojeNavigation)
                    .WithMany(p => p.Artiklis)
                    .HasForeignKey(d => d.Idboje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Artikli__IDBoje__49C3F6B7");

                entity.HasOne(d => d.IdnabavljacaNavigation)
                    .WithMany(p => p.Artiklis)
                    .HasForeignKey(d => d.Idnabavljaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Artikli__IDNabav__48CFD27E");

                entity.HasOne(d => d.IdvrsteArtiklaNavigation)
                    .WithMany(p => p.Artiklis)
                    .HasForeignKey(d => d.IdvrsteArtikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Artikli__IDVrste__47DBAE45");
            });

            modelBuilder.Entity<Boje>(entity =>
            {
                entity.HasKey(e => e.Idboje)
                    .HasName("PK__Boje__2339EC2C280561A1");

                entity.ToTable("Boje");

                entity.HasIndex(e => e.Sifra, "UQ__Boje__3E8DFF119EC43B93")
                    .IsUnique();

                entity.HasIndex(e => e.NazivBoje, "UQ__Boje__C7F1CA9F476DCE82")
                    .IsUnique();

                entity.Property(e => e.Idboje).HasColumnName("IDBoje");

                entity.Property(e => e.NazivBoje)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("naziv_boje")
                    .IsFixedLength(true);

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sifra")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.Idkorisnika)
                    .HasName("PK__Korisnik__99ACC3B64FBF69F1");

                entity.ToTable("Korisnik");

                entity.HasIndex(e => e.Username, "UQ__Korisnik__F3DBC572C8970643")
                    .IsUnique();

                entity.Property(e => e.Idkorisnika).HasColumnName("IDKorisnika");

                entity.Property(e => e.AdresaStanovanja)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("adresa_stanovanja");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ime");

                entity.Property(e => e.KontaktTelefon)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("kontakt_telefon");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("prezime");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Korpa>(entity =>
            {
                entity.HasKey(e => e.Idkorpe)
                    .HasName("PK__Korpa__D3AD2F6A3A114CD8");

                entity.ToTable("Korpa");

                entity.Property(e => e.Idkorpe).HasColumnName("IDKorpe");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("adresa");

                entity.Property(e => e.Broj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("broj");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.Email)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Idnarudzbe).HasColumnName("IDNarudzbe");

                entity.Property(e => e.Ime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ime");

                entity.Property(e => e.Komada).HasColumnName("komada");

                entity.Property(e => e.Prezime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("prezime");

                entity.HasOne(d => d.IdartiklaNavigation)
                    .WithMany(p => p.Korpas)
                    .HasForeignKey(d => d.Idartikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Korpa__IDArtikla__619B8048");

                entity.HasOne(d => d.IdnarudzbeNavigation)
                    .WithMany(p => p.Korpas)
                    .HasForeignKey(d => d.Idnarudzbe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Korpa__IDNarudzb__60A75C0F");
            });

            modelBuilder.Entity<Nabavljaci>(entity =>
            {
                entity.HasKey(e => e.Idnabavljaca)
                    .HasName("PK__Nabavlja__082FE31441395A97");

                entity.ToTable("Nabavljaci");

                entity.Property(e => e.Idnabavljaca).HasColumnName("IDNabavljaca");

                entity.Property(e => e.Broj)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("broj");

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.HasKey(e => e.Idnarudzbe)
                    .HasName("PK__Narudzba__458DF9D572B1A30F");

                entity.ToTable("Narudzba");

                entity.Property(e => e.Idnarudzbe).HasColumnName("IDNarudzbe");

                entity.Property(e => e.Idkorisnika).HasColumnName("IDKorisnika");

                entity.Property(e => e.Vrijeme)
                    .HasColumnType("datetime")
                    .HasColumnName("vrijeme")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdkorisnikaNavigation)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.Idkorisnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Narudzba__IDKori__5BE2A6F2");
            });

            modelBuilder.Entity<Slike>(entity =>
            {
                entity.HasKey(e => e.Idslike)
                    .HasName("PK__Slike__0B8D89BB8B8B72F1");

                entity.ToTable("Slike");

                entity.Property(e => e.Idslike).HasColumnName("IDSlike");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.HasOne(d => d.IdartiklaNavigation)
                    .WithMany(p => p.Slikes)
                    .HasForeignKey(d => d.Idartikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Slike__IDArtikla__5441852A");
            });

            modelBuilder.Entity<Stanje>(entity =>
            {
                entity.HasKey(e => e.Idstanja)
                    .HasName("PK__Stanje__3B231D32F6B1B2B1");

                entity.ToTable("Stanje");

                entity.Property(e => e.Idstanja).HasColumnName("IDStanja");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Idvelicine).HasColumnName("IDVelicine");

                entity.Property(e => e.Stanje1).HasColumnName("Stanje");

                entity.HasOne(d => d.IdartiklaNavigation)
                    .WithMany(p => p.Stanjes)
                    .HasForeignKey(d => d.Idartikla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stanje__IDArtikl__5070F446");

                entity.HasOne(d => d.IdvelicineNavigation)
                    .WithMany(p => p.Stanjes)
                    .HasForeignKey(d => d.Idvelicine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stanje__IDVelici__5165187F");
            });

            modelBuilder.Entity<Velicine>(entity =>
            {
                entity.HasKey(e => e.Idvelicine)
                    .HasName("PK__Velicine__BAA0E0257E00C891");

                entity.ToTable("Velicine");

                entity.HasIndex(e => e.Velicina, "UQ__Velicine__42F3DE67A3A3D8D8")
                    .IsUnique();

                entity.Property(e => e.Idvelicine).HasColumnName("IDVelicine");

                entity.Property(e => e.Velicina)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VrsteArtikla>(entity =>
            {
                entity.HasKey(e => e.IdvrsteArtikla)
                    .HasName("PK__VrsteArt__FF4D5D7AB077F882");

                entity.ToTable("VrsteArtikla");

                entity.HasIndex(e => e.VrstaArtikla, "UQ__VrsteArt__7B9E8D17BAF0D1C7")
                    .IsUnique();

                entity.Property(e => e.IdvrsteArtikla).HasColumnName("IDVrsteArtikla");

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwSlikeArtikala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSlikeArtikala");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");
            });

            modelBuilder.Entity<VwStanjeArtikala>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStanjeArtikala");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Velicina)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwSveOartiklima>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSveOArtiklima");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwZadnjiPetAccesory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwZadnjiPetAccesories");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwZadnjiPetArtikli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwZadnjiPetArtikli");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwZadnjiPetBot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwZadnjiPetBot");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwZadnjiPetSneaker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwZadnjiPetSneakers");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwZadnjiPetTop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwZadnjiPetTop");

                entity.Property(e => e.Cijena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cijena");

                entity.Property(e => e.DodatneInformacije)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dodatne_informacije");

                entity.Property(e => e.Idartikla).HasColumnName("IDArtikla");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NazivNabavljaca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("naziv_nabavljaca")
                    .IsFixedLength(true);

                entity.Property(e => e.Parent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spol");

                entity.Property(e => e.UrlSlike)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_slike");

                entity.Property(e => e.VrstaArtikla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vrsta_artikla")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
