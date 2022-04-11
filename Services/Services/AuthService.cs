using DataAccess.Interfaces;
using Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AuthService: BaseService
    {
        public AuthService(IRepository repo)
            : base(repo)
        {

        }
    }
}
