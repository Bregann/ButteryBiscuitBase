﻿using ButteryBiscuitBase.Domain.Data.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ButteryBiscuitBase.Domain.Data.Database.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<EnvironmentalSetting> EnvironmentalSettings { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; } = null!;
    }
}
