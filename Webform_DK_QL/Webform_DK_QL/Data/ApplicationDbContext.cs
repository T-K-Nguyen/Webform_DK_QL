using System;
using Microsoft.EntityFrameworkCore;
using Webform_DK_QL.Models;

namespace Webform_DK_QL.Data;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }