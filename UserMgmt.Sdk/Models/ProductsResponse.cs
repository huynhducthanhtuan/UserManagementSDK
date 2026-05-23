using System.Collections.Generic;

namespace UserMgmt.Sdk.Models;

public class ProductsResponse
{
    public IEnumerable<ProductFullDto>? Products { get; set; }
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}
