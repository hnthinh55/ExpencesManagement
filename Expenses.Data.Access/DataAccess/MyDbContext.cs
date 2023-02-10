using Expenses.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Access.DataAccess
{

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        #region
        public DbSet<User>? Users { get; set; }
        public DbSet<Expense>? Expenses { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public DbSet<BudgetReport> BudgetReports { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.HasIndex(e => e.UseName).IsUnique();
                entity.Property(e => e.FirstName).HasMaxLength(50);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.Budget).HasDefaultValue(0.0);
                entity.HasOne<BudgetReport>(e => e.BudgetReport)
                .WithOne(e => e.User)
                .HasForeignKey<BudgetReport>(e => e.UserId);

                entity.HasOne(e => e.Roles)
                .WithMany(e => e.Users)
                .HasForeignKey(e => e.RoleId);
            });
            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e=> e.IsDeleted).HasDefaultValue(false);
                
            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ExpenseDetail>(entity =>
            {
                entity.HasOne(e => e.Expense)
                .WithMany(e => e.Details)
                .HasForeignKey(e => e.ExpenseId);

                entity.HasOne(e => e.ExpenseCategory)
                .WithMany(e => e.Expenses)
                .HasForeignKey(e => e.CategoryId);
            });
        }
        }
}
