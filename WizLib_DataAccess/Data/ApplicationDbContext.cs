using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WizLib_DataAccess.FluentConfig;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Generes> Generes { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers{ get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
        public DbSet<Fluent_Book> Fluent_Books { get; set; }
        public DbSet<Fluent_Author> Fluent_Authors { get; set; }
        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }

        public DbSet<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            //change Category table And Column Name
            modelBuilder.Entity<Category>().ToTable("tbl_Category");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");


            //Fluent API Configuration
            //Composite Key
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailsConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            ////BookDetail
            //modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);
            //modelBuilder.Entity<Fluent_BookDetail>().Property(b => b.NumberOfChepters).IsRequired();

            ////one to one relationship between Book and BookDetail using FluentAPI
            //modelBuilder.Entity<Fluent_Book>()
            //    .HasOne(b => b.Fluent_BookDetail).WithOne(b => b.Fluent_Book).HasForeignKey<Fluent_Book>("BookDetail_Id");

            ////one to many relationship between book and publisher
            //modelBuilder.Entity<Fluent_Book>().
            //    HasOne(b => b.Fluent_Publisher).WithMany(b => b.Fluent_Book).HasForeignKey(b =>b.Publisher_Id);

            ////many to many relation between book and Author
            //modelBuilder.Entity<Fluent_BookAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });
            //modelBuilder.Entity<Fluent_BookAuthor>().
            //    HasOne(b => b.Fluent_Book).WithMany(b => b.Fluent_BookAuthors).HasForeignKey(b => b.Book_Id);
            //modelBuilder.Entity<Fluent_BookAuthor>().
            //    HasOne(b => b.Fluent_Author).WithMany(b => b.Fluent_BookAuthors).HasForeignKey(b => b.Author_Id);

            ////Book
            //modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
            //modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
            //modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired();
            //modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();

            ////Many To Many relation Between Book And Author


            ////Author
            //modelBuilder.Entity<Fluent_Author>().HasKey(b => b.Author_Id);
            //modelBuilder.Entity<Fluent_Author>().Property(b => b.FirstName).IsRequired();
            //modelBuilder.Entity<Fluent_Author>().Property(b => b.LastName).IsRequired();
            //modelBuilder.Entity<Fluent_Author>().Ignore(b =>b.FullName);

            ////publisher
            //modelBuilder.Entity<Fluent_Publisher>().HasKey(b => b.Publisher_Id);
            //modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Name).IsRequired();
            //modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Location).IsRequired();

        }
    }
}
