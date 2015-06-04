using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace My_Blog_MVC.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string memberName { get; set; }

        public string memberSurname { get; set; }

        public string memberCountry { get; set; }

        public string e_mail { set; get; }

        public DateTime becomeMemberDate { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
    }
}