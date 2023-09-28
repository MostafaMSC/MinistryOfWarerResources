using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinistryOfWarerResources.Models;

namespace MinistryOfWarerResources.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DaawaModel> DawwaTable { get; set; }
        public DbSet<JazaeaModule> JazaeaTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            const string Owner_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string OwnerRole_ID = "oi2eoij-1oqjsdkj-kaslk-OwnerRole";

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "owner",
                Name = "owner",
                NormalizedName = "OWNER"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "admin",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "DawaView",
                Name = "DawaView",
                NormalizedName = "DAWAVIEW"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "eatalaJazaea",
                Name = "eatalaJazaea",
                NormalizedName = "EATALAJAZAEA"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "admin2",
                Name = "admin2",
                NormalizedName = "ADMIN2"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "SuperAdmin",
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "regulator",
                Name = "regulator",
                NormalizedName = "REGULATOR"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = Owner_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin",
                NormalizedEmail = "admin",
                EmailConfirmed = true,
                PasswordHash = "000000",
                SecurityStamp = Guid.NewGuid().ToString()
            });
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "cvfgrtbvdscvfd",
                UserName = "admin2",
                NormalizedUserName = "ADMIN2",
                Email = "admin",
                NormalizedEmail = "admin",
                EmailConfirmed = true,
                PasswordHash = "000000",
                SecurityStamp = Guid.NewGuid().ToString()
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "dASDadadasdasdasdsa",
                UserName = "owner",
                NormalizedUserName = "OWNER",
                Email = "owner",
                NormalizedEmail = "owner",
                EmailConfirmed = true,
                PasswordHash = "000000",
                SecurityStamp = Guid.NewGuid().ToString()
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = OwnerRole_ID,
                UserId = Owner_ID
            });



        }
    


    }
}