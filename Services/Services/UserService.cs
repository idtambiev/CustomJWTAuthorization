using DataAccess.Interfaces;
using Services.Interfaces;
using Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService: BaseService, IUserService
    {
        public UserService(IRepository repo)
            :base(repo)
        {

        }


        public async Task GenerateJWTToken()
        {

        }
    }
}
