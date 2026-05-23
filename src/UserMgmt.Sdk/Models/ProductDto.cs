namespace UserMgmt.Sdk.Models;

public class ProductDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class DimensionsDto
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public decimal Depth { get; set; }
}

public class ReviewDto
{
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string ReviewerName { get; set; } = string.Empty;
    public string ReviewerEmail { get; set; } = string.Empty;
}

public class MetaDto
{
    public string CreatedAt { get; set; } = string.Empty;
    public string UpdatedAt { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public string QrCode { get; set; } = string.Empty;
}

public class ProductFullDto : ProductDto
{
    public string Category { get; set; } = string.Empty;
    public decimal DiscountPercentage { get; set; }
    public decimal Rating { get; set; }
    public int Stock { get; set; }
    public List<string>? Tags { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public decimal Weight { get; set; }
    public DimensionsDto? Dimensions { get; set; }
    public string WarrantyInformation { get; set; } = string.Empty;
    public string ShippingInformation { get; set; } = string.Empty;
    public string AvailabilityStatus { get; set; } = string.Empty;
    public List<ReviewDto>? Reviews { get; set; }
    public string ReturnPolicy { get; set; } = string.Empty;
    public int MinimumOrderQuantity { get; set; }
    public MetaDto? Meta { get; set; }
    public List<string>? Images { get; set; }
    public string Thumbnail { get; set; } = string.Empty;
}

