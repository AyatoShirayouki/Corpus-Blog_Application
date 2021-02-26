using CorpusSMDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class CommentsRepository : BaseRepository<Comment>
    {
        public CommentsRepository() : base() { }
        public CommentsRepository(UnitOfWork uow) : base(uow) { }
        protected override IQueryable<Comment> CascadeInclude(IQueryable<Comment> query)
        {
            return query.Include(c => c.ParentPost);
        }
    }
}
