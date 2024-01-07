using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MovieSearch
{
    public class MediaContext : DbContext
    {
        public DbSet<Media> Media { get; set; }
        public DbSet<SearchPaths> SearchPaths { get; set; }

        public string DbPath { get; }

        public MediaContext()
        {
            DbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MovieSearch\MovieSearch.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
    }

    public class SearchPaths
    {
        public int Id { get; set; }
        public string Directory { get; set; }
    }
}
