using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Common.Interfaces
{
    public interface IDbContext
    {
        DbSet<Activity> Activities { get; }
        DbSet<ActivityAttendee> ActivityAttendees { get; }
        DbSet<AppUser> Users { get; }
        DbSet<Photo> Photos { get; }
        DbSet<Comment> Comments { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        EntityEntry Remove(object entity);
    }
}