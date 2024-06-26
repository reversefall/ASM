using ASM.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASM.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser, ApplicationRole, string,
        IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public DbSet<JobList> JobList { get; set; }
        public DbSet<Application> Application { get; set; }
    }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var JobSeeker = new IdentityRole("JobSeeker");
            JobSeeker.NormalizedName = "JobSeeker";

            var Employer = new IdentityRole("Employer");
            Employer.NormalizedName = "Employer";

            ModelBuilder.Entity<IdentityRole>().HasData(admin, JobSeeker,Employer);


        }
    }