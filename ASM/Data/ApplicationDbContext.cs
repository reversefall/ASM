using ASM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASM.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var JobSeeker = new IdentityRole("JobSeeker");
            JobSeeker.NormalizedName = "JobSeeker";

            var Employer = new IdentityRole("Employer");
            Employer.NormalizedName = "Employer";

            builder.Entity<IdentityRole>().HasData(admin, JobSeeker,Employer);


        }
    }
}