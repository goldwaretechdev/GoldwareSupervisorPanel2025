using GoldwareSupervisorPanel2025.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace GoldwareSupervisorPanel2025.Properties.services
{
    public interface ISettingsService
    {
        public Task<Result<CategorizedVersions>> CategorizedVersionsAsync();
        public Task<Result<List<SelectListItem>>> Owners();
    }


    public class SettingsService : ISettingsService
    {
        private readonly HttpClient _client;
        private readonly string TOKEN;

        public SettingsService()
        {
            _client = new();
            TOKEN = Settings.Default.AuthToken;
        }

        #region CategorizedVersionsAsync
        public async Task<Result<CategorizedVersions>> CategorizedVersionsAsync()
        {           
            var request = new HttpRequestMessage(HttpMethod.Get, Constants.BASE_URL + "/Settings/SoftwareVersions");
            request.Headers.Authorization = new AuthenticationHeaderValue(Constants.AUTH_TYPE, TOKEN );
            var response = await _client.SendAsync(request);
            if (!response.IsSuccessStatusCode) return Result<CategorizedVersions>.Fail(ErrorCode.INTERNAL_ERROR, "خطای سرور!");
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Result<CategorizedVersions>>(json);
        }
        #endregion

        #region Owners
        public async Task<Result<List<SelectListItem>>> Owners()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Constants.BASE_URL + "/Settings/Owners");
            request.Headers.Authorization = new AuthenticationHeaderValue(Constants.AUTH_TYPE, TOKEN);
            var response = await _client.SendAsync(request);
            if (!response.IsSuccessStatusCode) return Result<List<SelectListItem>>.Fail(ErrorCode.INTERNAL_ERROR, "خطای سرور!");
            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Result<List<SelectListItem>>>(json);
        }
        #endregion

    }
}
