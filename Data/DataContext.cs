﻿global using Microsoft.EntityFrameworkCore;
using egolfWebApi.Models.GameType;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace egolfWebApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) 
    {
    }


    public DbSet<Models.Member.Member> Members { get; set; }
    public DbSet<GameType> GameTypes { get; set; }
}