using CorpusSMDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class PostsRepository : BaseRepository<Post>
    {
        public PostsRepository(UnitOfWork uow) : base(uow)
        {

        }
        public PostsRepository() : base()
        {

        }
        protected override IQueryable<Post> CascadeInclude(IQueryable<Post> query)
        {
            return query.Include(c => c.ParentUser);
        }
    }
}
