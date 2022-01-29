using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Common.Interfaces
{
    public interface IDbContext
    {
        DbSet<Activity> Activities { get; set; }
        DbSet<ActivityAttendee> ActivityAttendees { get; set; }
        DbSet<AppUser> Users { get; set; }
        DbSet<Photo> Photos { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<UserFollowing> UserFollowings { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        EntityEntry Remove(object entity);
    }
}