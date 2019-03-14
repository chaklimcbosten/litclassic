using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace litclassic
{
    public partial class LitClassicBooksContext : DbContext
    {
        public LitClassicBooksContext()
        {
        }

        public LitClassicBooksContext(DbContextOptions<LitClassicBooksContext> options) : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksDescriptions> BooksDescriptions { get; set; }
        public virtual DbSet<BooksLines> BooksLines { get; set; }
        public virtual DbSet<Particles> Particles { get; set; }
        public virtual DbSet<Particles00> Particles00 { get; set; }
        public virtual DbSet<Particles01> Particles01 { get; set; }
        public virtual DbSet<Particles02> Particles02 { get; set; }
        public virtual DbSet<Particles03> Particles03 { get; set; }
        public virtual DbSet<Particles10> Particles10 { get; set; }
        public virtual DbSet<Particles11> Particles11 { get; set; }
        public virtual DbSet<Particles12> Particles12 { get; set; }
        public virtual DbSet<Particles13> Particles13 { get; set; }
        public virtual DbSet<Particles20> Particles20 { get; set; }
        public virtual DbSet<Particles21> Particles21 { get; set; }
        public virtual DbSet<Particles22> Particles22 { get; set; }
        public virtual DbSet<Particles23> Particles23 { get; set; }
        public virtual DbSet<Particles30> Particles30 { get; set; }
        public virtual DbSet<Particles31> Particles31 { get; set; }
        public virtual DbSet<Particles32> Particles32 { get; set; }
        public virtual DbSet<Particles33> Particles33 { get; set; }
        public virtual DbSet<Particles40> Particles40 { get; set; }
        public virtual DbSet<Particles41> Particles41 { get; set; }
        public virtual DbSet<Particles42> Particles42 { get; set; }
        public virtual DbSet<Particles43> Particles43 { get; set; }
        public virtual DbSet<Particles50> Particles50 { get; set; }
        public virtual DbSet<Particles51> Particles51 { get; set; }
        public virtual DbSet<Particles52> Particles52 { get; set; }
        public virtual DbSet<Particles53> Particles53 { get; set; }
        public virtual DbSet<Particles60> Particles60 { get; set; }
        public virtual DbSet<Particles61> Particles61 { get; set; }
        public virtual DbSet<Particles62> Particles62 { get; set; }
        public virtual DbSet<Particles63> Particles63 { get; set; }
        public virtual DbSet<Particles70> Particles70 { get; set; }
        public virtual DbSet<Particles71> Particles71 { get; set; }
        public virtual DbSet<Particles72> Particles72 { get; set; }
        public virtual DbSet<Particles73> Particles73 { get; set; }
        public virtual DbSet<Particles80> Particles80 { get; set; }
        public virtual DbSet<Particles81> Particles81 { get; set; }
        public virtual DbSet<Particles82> Particles82 { get; set; }
        public virtual DbSet<Particles83> Particles83 { get; set; }
        public virtual DbSet<Particles90> Particles90 { get; set; }
        public virtual DbSet<Particles91> Particles91 { get; set; }
        public virtual DbSet<Particles92> Particles92 { get; set; }
        public virtual DbSet<Particles93> Particles93 { get; set; }
        public virtual DbSet<Words> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BookPath)
                    .IsRequired()
                    .HasColumnName("bookPath");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");
            });

            modelBuilder.Entity<BooksDescriptions>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Annotation).HasColumnName("annotation");

                entity.Property(e => e.Binary).HasColumnName("binary");

                entity.Property(e => e.BookId).HasColumnName("bookID");

                entity.Property(e => e.BookName).HasColumnName("bookName");

                entity.Property(e => e.BookTitle).HasColumnName("bookTitle");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Coverpage).HasColumnName("coverpage");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50);

                entity.Property(e => e.DocAuthorEmail)
                    .HasColumnName("docAuthorEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.DocAuthorFirstName)
                    .HasColumnName("docAuthorFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.DocAuthorHomePage).HasColumnName("docAuthorHomePage");

                entity.Property(e => e.DocAuthorLastName)
                    .HasColumnName("docAuthorLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.DocAuthorMiddleName)
                    .HasColumnName("docAuthorMiddleName")
                    .HasMaxLength(50);

                entity.Property(e => e.DocAuthorNickname)
                    .HasColumnName("docAuthorNickname")
                    .HasMaxLength(50);

                entity.Property(e => e.DocDate)
                    .HasColumnName("docDate")
                    .HasMaxLength(50);

                entity.Property(e => e.DocId)
                    .HasColumnName("docID")
                    .HasMaxLength(50);

                entity.Property(e => e.FictionBook)
                    .HasColumnName("fictionBook")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.Genre)
                    .HasColumnName("genre")
                    .HasMaxLength(50);

                entity.Property(e => e.History).HasColumnName("history");

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middleName")
                    .HasMaxLength(50);

                entity.Property(e => e.PreReform)
                    .HasColumnName("preReform")
                    .HasMaxLength(50);

                entity.Property(e => e.ProgramUsed)
                    .HasColumnName("programUsed")
                    .HasMaxLength(50);

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasMaxLength(50);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.SrcLang)
                    .HasColumnName("srcLang")
                    .HasMaxLength(50);

                entity.Property(e => e.SrcOcr)
                    .HasColumnName("srcOCR")
                    .HasMaxLength(50);

                entity.Property(e => e.SrcUrl).HasColumnName("srcURL");

                entity.Property(e => e.TranslatorEmail)
                    .HasColumnName("translatorEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.TranslatorFirstName)
                    .HasColumnName("translatorFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.TranslatorHomePage).HasColumnName("translatorHomePage");

                entity.Property(e => e.TranslatorLastName)
                    .HasColumnName("translatorLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.TranslatorMiddleName)
                    .HasColumnName("translatorMiddleName")
                    .HasMaxLength(50);

                entity.Property(e => e.TranslatorNickname)
                    .HasColumnName("translatorNickname")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BooksDescriptions)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BooksDescriptions_Books");
            });

            modelBuilder.Entity<BooksLines>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("bookID");

                entity.Property(e => e.Line).HasColumnName("line");

                entity.Property(e => e.LineIndex).HasColumnName("lineIndex");

                entity.Property(e => e.RecommendConnection).HasColumnName("recommendConnection");

                entity.Property(e => e.StrongConnection).HasColumnName("strongConnection");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BooksLines)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BooksLines_Books");
            });

            modelBuilder.Entity<Particles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BookId).HasColumnName("bookID");

                entity.Property(e => e.IndexLastLine).HasColumnName("indexLastLine");

                entity.Property(e => e.Line).HasColumnName("line");

                entity.Property(e => e.SumStrongConnections).HasColumnName("sumStrongConnections");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Particles)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals_Books");
            });

            modelBuilder.Entity<Particles00>(entity =>
            {
                entity.ToTable("Particles-0-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles00)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-0-0_Particals");
            });

            modelBuilder.Entity<Particles01>(entity =>
            {
                entity.ToTable("Particles-0-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles01)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-0-1_Particals");
            });

            modelBuilder.Entity<Particles02>(entity =>
            {
                entity.ToTable("Particles-0-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles02)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-0-2_Particals");
            });

            modelBuilder.Entity<Particles03>(entity =>
            {
                entity.ToTable("Particles-0-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles03)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-0-3_Particals");
            });

            modelBuilder.Entity<Particles10>(entity =>
            {
                entity.ToTable("Particles-1-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles10)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-1-0_Particals");
            });

            modelBuilder.Entity<Particles11>(entity =>
            {
                entity.ToTable("Particles-1-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles11)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-1-1_Particals");
            });

            modelBuilder.Entity<Particles12>(entity =>
            {
                entity.ToTable("Particles-1-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles12)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-1-2_Particals");
            });

            modelBuilder.Entity<Particles13>(entity =>
            {
                entity.ToTable("Particles-1-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles13)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-1-3_Particals");
            });

            modelBuilder.Entity<Particles20>(entity =>
            {
                entity.ToTable("Particles-2-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles20)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-2-0_Particals");
            });

            modelBuilder.Entity<Particles21>(entity =>
            {
                entity.ToTable("Particles-2-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles21)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-2-1_Particals");
            });

            modelBuilder.Entity<Particles22>(entity =>
            {
                entity.ToTable("Particles-2-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles22)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-2-2_Particals");
            });

            modelBuilder.Entity<Particles23>(entity =>
            {
                entity.ToTable("Particles-2-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles23)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-2-3_Particals");
            });

            modelBuilder.Entity<Particles30>(entity =>
            {
                entity.ToTable("Particles-3-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles30)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-3-0_Particals");
            });

            modelBuilder.Entity<Particles31>(entity =>
            {
                entity.ToTable("Particles-3-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles31)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-3-1_Particals");
            });

            modelBuilder.Entity<Particles32>(entity =>
            {
                entity.ToTable("Particles-3-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles32)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-3-2_Particals");
            });

            modelBuilder.Entity<Particles33>(entity =>
            {
                entity.ToTable("Particles-3-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles33)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-3-3_Particals");
            });

            modelBuilder.Entity<Particles40>(entity =>
            {
                entity.ToTable("Particles-4-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles40)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-4-0_Particals");
            });

            modelBuilder.Entity<Particles41>(entity =>
            {
                entity.ToTable("Particles-4-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles41)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-4-1_Particals");
            });

            modelBuilder.Entity<Particles42>(entity =>
            {
                entity.ToTable("Particles-4-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles42)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-4-2_Particals");
            });

            modelBuilder.Entity<Particles43>(entity =>
            {
                entity.ToTable("Particles-4-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles43)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-4-3_Particals");
            });

            modelBuilder.Entity<Particles50>(entity =>
            {
                entity.ToTable("Particles-5-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles50)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-5-0_Particals");
            });

            modelBuilder.Entity<Particles51>(entity =>
            {
                entity.ToTable("Particles-5-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles51)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-5-1_Particals");
            });

            modelBuilder.Entity<Particles52>(entity =>
            {
                entity.ToTable("Particles-5-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles52)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-5-2_Particals");
            });

            modelBuilder.Entity<Particles53>(entity =>
            {
                entity.ToTable("Particles-5-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles53)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-5-3_Particals");
            });

            modelBuilder.Entity<Particles60>(entity =>
            {
                entity.ToTable("Particles-6-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles60)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-6-0_Particals");
            });

            modelBuilder.Entity<Particles61>(entity =>
            {
                entity.ToTable("Particles-6-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles61)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-6-1_Particals");
            });

            modelBuilder.Entity<Particles62>(entity =>
            {
                entity.ToTable("Particles-6-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles62)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-6-2_Particals");
            });

            modelBuilder.Entity<Particles63>(entity =>
            {
                entity.ToTable("Particles-6-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles63)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-6-3_Particals");
            });

            modelBuilder.Entity<Particles70>(entity =>
            {
                entity.ToTable("Particles-7-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles70)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-7-0_Particals");
            });

            modelBuilder.Entity<Particles71>(entity =>
            {
                entity.ToTable("Particles-7-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles71)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-7-1_Particals");
            });

            modelBuilder.Entity<Particles72>(entity =>
            {
                entity.ToTable("Particles-7-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles72)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-7-2_Particals");
            });

            modelBuilder.Entity<Particles73>(entity =>
            {
                entity.ToTable("Particles-7-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles73)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-7-3_Particals");
            });

            modelBuilder.Entity<Particles80>(entity =>
            {
                entity.ToTable("Particles-8-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles80)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-8-0_Particals");
            });

            modelBuilder.Entity<Particles81>(entity =>
            {
                entity.ToTable("Particles-8-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles81)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-8-1_Particals");
            });

            modelBuilder.Entity<Particles82>(entity =>
            {
                entity.ToTable("Particles-8-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles82)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-8-2_Particals");
            });

            modelBuilder.Entity<Particles83>(entity =>
            {
                entity.ToTable("Particles-8-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles83)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-8-3_Particals");
            });

            modelBuilder.Entity<Particles90>(entity =>
            {
                entity.ToTable("Particles-9-0");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles90)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-9-0_Particals");
            });

            modelBuilder.Entity<Particles91>(entity =>
            {
                entity.ToTable("Particles-9-1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles91)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-9-1_Particals");
            });

            modelBuilder.Entity<Particles92>(entity =>
            {
                entity.ToTable("Particles-9-2");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles92)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-9-2_Particals");
            });

            modelBuilder.Entity<Particles93>(entity =>
            {
                entity.ToTable("Particles-9-3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idparticles).HasColumnName("IDParticles");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.HasOne(d => d.IdparticlesNavigation)
                    .WithMany(p => p.Particles93)
                    .HasForeignKey(d => d.Idparticles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Particals-9-3_Particals");
            });

            modelBuilder.Entity<Words>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstLetter)
                    .HasColumnName("firstLetter")
                    .HasMaxLength(1);

                entity.Property(e => e.Links)
                    .HasColumnName("links")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.Property(e => e.Value).HasColumnName("value");
            });
        }
    }
}
