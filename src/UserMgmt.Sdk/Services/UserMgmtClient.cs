using System.Net.Http.Json;
using UserMgmt.Sdk.Models;

namespace UserMgmt.Sdk.Services;

public class UserMgmtClient : IUserMgmtClient
{
    private readonly HttpClient _httpClient;

    public UserMgmtClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UsersResponse> GetUsersAsync()
    {
        // Call API [GET] https://dummyjson.com/users
        return await _httpClient.GetFromJsonAsync<UsersResponse>("users");
    }

    public async Task<ProductsResponse> GetProductsAsync()
    {
        // Call API [GET] https://dummyjson.com/products
        return await _httpClient.GetFromJsonAsync<ProductsResponse>("products");
    }
}
