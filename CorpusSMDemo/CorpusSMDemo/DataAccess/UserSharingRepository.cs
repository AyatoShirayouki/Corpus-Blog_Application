using CorpusSMDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class UserSharingRepository : BaseRepository<UserSharing>
    {
        public UserSharingRepository(UnitOfWork uow) : base(uow)
        {

        }
        public UserSharingRepository() : base()
        {

        }
        protected override IQueryable<UserSharing> CascadeInclude(IQueryable<UserSharing> query)
        {
            return query.Include(utc => utc.ParentPost)
                .Include(utc => utc.ParentUser);
        }

        public List<User> GetUserByPost(int postId)
        {
            return Items
                .Include(c => c.ParentUser)
                .Include(c => c.ParentPost)
                .Where(u => u.PostId == postId)
                .Select(u => u.ParentUser)
                .ToList();
        }
    }
}
