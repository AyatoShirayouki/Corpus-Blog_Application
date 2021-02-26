using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class AdminsRepository : BaseRepository<Admin>
    {
        public AdminsRepository(UnitOfWork uow) : base(uow)
        {

        }
        public AdminsRepository() : base()
        {

        }
    }
}
