using Microsoft.AspNetCore.Mvc;
using UserMgmt.Sdk.Models;
using UserMgmt.Sdk.Services;

namespace UserMgmt.Api.Controllers;

[ApiController]
[Route("api/v1/")]
public class UsersController : ControllerBase
{
    private readonly IUserMgmtClient _sdk;

    public UsersController(IUserMgmtClient sdk)
    {
        _sdk = sdk;
    }

    [HttpGet("users")]
    public async Task<ActionResult<UsersResponse>> Get()
    {
        try
        {
            var users = await _sdk.GetUsersAsync();
            return Ok(users);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("products")]
    public async Task<ActionResult<ProductsResponse>> GetProducts()
    {
        try
        {
            var products = await _sdk.GetProductsAsync();
            return Ok(products);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
