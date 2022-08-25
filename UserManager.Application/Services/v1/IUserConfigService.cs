using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Application.Contracts.v1.Users.Response;

namespace UserManager.Application.Services.v1
{
    public interface IUserConfigService
    {
        public Task<GetUsersResponse> GetAllUsersAsync();
        public Task<GetUsersResponse> GetUserByIdAsync(int id);
    }
}
