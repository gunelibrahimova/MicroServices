using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UserManager.Application.Contracts.v1.Users.Response;
using static UserManager.Application.Contracts.v1.Users.Response.GetUsersResponse;

namespace UserManager.Application.Services.v1
{

    public class UserConfigService : IUserConfigService
    {
        private readonly HttpClient _httpClient;

        public UserConfigService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetUsersResponse> GetAllUsersAsync()
        {
            var userResponse = new GetUsersResponse();
            var uri = "https://jsonplaceholder.typicode.com/users";
            var responseString = await _httpClient.GetStringAsync(uri);
            var users = JsonConvert.DeserializeObject<List<User>>(responseString);

            userResponse.Users = users;
            return userResponse;
        }

        public async Task<GetUsersResponse> GetUserByIdAsync(int id)
        {
            var userResponse = new GetUsersResponse();
            var uri = $"https://jsonplaceholder.typicode.com/users?id={id}";
            var responseString = await _httpClient.GetStringAsync(uri);
            var users = JsonConvert.DeserializeObject<List<User>>(responseString);

            userResponse.Users = users;
            return userResponse;
        }
    }
}
