using Eindwerk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eindwerk.Data
{
    public class EindwerkContext : DbContext
    {
        public EindwerkContext(DbContextOptions options) : base(options) { }

        public DbSet<Aanvraag> Aanvraag {get;set;}
    }
}
