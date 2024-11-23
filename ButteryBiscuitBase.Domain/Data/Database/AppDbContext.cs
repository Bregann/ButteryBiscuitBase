using ButteryBiscuitBase.Domain.Data.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButteryBiscuitBase.Domain.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<EnvironmentalSetting> EnvironmentalSettings { get; set; }
    }
}
