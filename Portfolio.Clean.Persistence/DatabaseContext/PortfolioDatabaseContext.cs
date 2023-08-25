using Microsoft.EntityFrameworkCore;
using Portfolio.Clean.Domain;
using Portfolio.Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.DatabaseContext;

public class PortfolioDatabaseContext : DbContext
{

    #region Attributes & Accessors
    public DbSet<ContactEmail> ContactEmails { get; set; }
    public DbSet<PCLog> PCLogs { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    #endregion

    #region Constructors
    public PortfolioDatabaseContext(DbContextOptions<PortfolioDatabaseContext> options)
        : base(options)
    {

    }
    #endregion

    #region Methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Apply all the configurations located into Configurations folder 
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDatabaseContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.LastUpdate = DateTime.Now;

            if (entry.State == EntityState.Added)
                entry.Entity.CreationDate = DateTime.Now;

        }

        return base.SaveChangesAsync(cancellationToken);
    }
    #endregion
}
