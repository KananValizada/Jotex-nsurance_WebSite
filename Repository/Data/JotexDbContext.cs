using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
namespace Repository.Data
{
    public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogSlogan> BlogSlogans { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceFeature> ServiceFeatures { get; set; }
        public DbSet<ServiceReview> ServiceReviews { get; set; }
        public DbSet<ServiceSpec> ServiceSpecs { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
    }
}
