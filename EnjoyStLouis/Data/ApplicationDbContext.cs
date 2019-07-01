using System;
using System.Collections.Generic;
using System.Text;
using EnjoyStLouis.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnjoyStLouis.Data
{
    public class ApplicationDbContext : IdentityDbContext 
    {
        public DbSet<Buisness> Buisnesses { get; set; }
        public DbSet<RateReview> RateReviews { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
