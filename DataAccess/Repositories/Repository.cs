using Data.Context;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class Repository: IRepository
    {
        public AppDbCOntext Context { get; set; }

        public Repository(AppDbCOntext context)
        {
            Context = context;
        }
    }
}
