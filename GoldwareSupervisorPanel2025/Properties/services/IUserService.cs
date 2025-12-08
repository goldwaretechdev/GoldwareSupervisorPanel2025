using GoldwareSupervisorPanel2025.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldwareSupervisorPanel2025.Properties.services
{
    public interface IUserService
    {
        public Task<Result<List<RoleDto>>> Login(string username, string password);
        public Task<Result<string>> Token(LoginInfo info);
    }


    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService()
        {
            _client = new();
        }

        public async Task<Result<List<RoleDto>>> Login(string username, string password)
        {
            LoginInfo info = new()
            {
                UserName = username,
                Password = password
            };
            var content = new StringContent(JsonConvert.SerializeObject(info),Encoding.UTF8,"application/json");
            var response =await _client.PostAsync(Constants.BASE_URL + "/User/Login",content);
            if (!response.IsSuccessStatusCode) return Result<List<RoleDto>>.Fail(ErrorCode.INTERNAL_ERROR, "خطای سرور!");
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Result<List<RoleDto>>>(json);
        }

        public async Task<Result<string>> Token(LoginInfo info)
        {           
            var content = new StringContent(JsonConvert.SerializeObject(info),Encoding.UTF8,"application/json");
            var response =await _client.PostAsync(Constants.BASE_URL + "/User/Token",content);
            if (!response.IsSuccessStatusCode) return Result<string>.Fail(ErrorCode.INTERNAL_ERROR, "خطای سرور!");
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Result<string>>(json);
        }
    }


}
