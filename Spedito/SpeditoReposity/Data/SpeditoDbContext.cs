using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SpeditoReposity.Data
{
    public class SpeditoDbContext : DbContext
    {
        public SpeditoDbContext(DbContextOptions<SpeditoDbContext> options) :base(options) { }
    }
}
