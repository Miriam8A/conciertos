using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace conciertos.Data
{
    public class ApplicationDbContext:IdentityDbContext       
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {}
    
    public DbSet<conciertos.Models.Concierto> DataConciertos {get; set; }

    }
}