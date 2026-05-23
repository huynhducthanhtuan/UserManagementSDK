using UserMgmt.Sdk.Models;

namespace UserMgmt.Sdk.Services;

public interface IUserMgmtClient
{
    Task<UsersResponse> GetUsersAsync();
    Task<ProductsResponse> GetProductsAsync();
}
