﻿namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : IdentityDbContext<ApplicationUser>
{
    private readonly ICurrentUserService _currentUserService;
    public AppDbContext(DbContextOptions options, ICurrentUserService currentUserService) : base(options)
    {
        _currentUserService = currentUserService;
    }

    // DbSet for all entities in the your application.
    public DbSet<Product> products { get; set; } = default!;

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entities = ChangeTracker.Entries<AuditableEntity>();

        foreach (var entity in entities)
        {
            if (entity.State == EntityState.Added)
            {
                entity.Entity.CreatedAt = DateTime.UtcNow;
                entity.Entity.CreatedBy = _currentUserService.UserName; // Set CreatedBy if needed
            }
            else if (entity.State == EntityState.Modified)
            {
                entity.Entity.UpdatedAt = DateTime.UtcNow;
                entity.Entity.UpdatedBy = _currentUserService.UserName; // Set UpdatedBy if needed
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}