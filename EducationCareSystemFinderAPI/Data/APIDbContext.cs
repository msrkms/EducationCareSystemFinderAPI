using EducationCareSystemFinderAPI.Model.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducationCareSystemFinderAPI.Data
{
    public class APIDbContext:IdentityDbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

       public DbSet<ApplicationUserModel> ApplicationUserModel { get; set; }
    }
}
