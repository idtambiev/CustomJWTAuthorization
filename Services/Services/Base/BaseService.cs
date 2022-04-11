using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Base
{
    public class BaseService
    {
        protected readonly IRepository _repo;
        public BaseService(IRepository repo)
        {
            _repo = repo;
        }
    }
}
