﻿using Microsoft.EntityFrameworkCore;
using WEB.Models;
using Task = WEB.Models.Task;

namespace WebApplication1.Contexts;

public class DatabaseContext : DbContext
{
    public DbSet<Language> Languages { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Record> Records { get; set; }
    
    protected DatabaseContext() {}
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Language>()
            .HasIndex(l => l.Name)
            .IsUnique();
        
        modelBuilder.Entity<Language>().HasData(
            new Language {Id = 1, Name = "English"},
            new Language {Id = 2, Name = "Spanish"},
            new Language {Id = 3, Name = "Polish"}
        );
        
        modelBuilder.Entity<Task>().
            HasIndex(t => t.Name)
            .IsUnique();

        modelBuilder.Entity <Task>().HasData(
            new Task {Id = 1, Name = "Dijkstra", Description = "Solve this problem using Dijkstra algorithm."},
            new Task {Id = 2, Name = "DFS", Description = "Solve this problem using DFS algorithm."}, 
            new Task {Id = 3, Name = "BFS", Description = "Solve this problem using BFS algorithm."}
        );

        modelBuilder.Entity<Student>()
            .HasIndex(s => s.Email)
            .IsUnique();
        
        modelBuilder.Entity<Student>().HasData(
            new Student {Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com"},
            new Student {Id = 2, FirstName = "Michael", LastName = "Myers", Email = "michael@example.com"},
            new Student {Id = 3, FirstName = "Jordan", LastName = "Carter", Email = "jordan@example.com"}
        );

        modelBuilder.Entity<Record>().HasData(
            new Record {Id = 1, StudentId = 1, TaskId = 1, LanguageId = 1, ExecutionTime = 10, CreatedAt = new DateTime(2018, 9, 20)},
            new Record {Id = 2, StudentId = 2, TaskId = 2, LanguageId = 2, ExecutionTime = 5, CreatedAt = new DateTime(2019, 2, 3)},
            new Record {Id = 3, StudentId = 3, TaskId = 3, LanguageId = 3, ExecutionTime = 1, CreatedAt = new DateTime(2025, 11, 8)}
        );
    }
}