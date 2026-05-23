namespace UserMgmt.Sdk.Models;

public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string MaidenName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string BirthDate { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string BloodGroup { get; set; } = string.Empty;
    public double Height { get; set; }
    public double Weight { get; set; }
    public string EyeColor { get; set; } = string.Empty;
    public HairDto? Hair { get; set; }
    public string Ip { get; set; } = string.Empty;
    public AddressDto? Address { get; set; }
    public string MacAddress { get; set; } = string.Empty;
    public string University { get; set; } = string.Empty;
    public BankDto? Bank { get; set; }
    public CompanyDto? Company { get; set; }
    public string Ein { get; set; } = string.Empty;
    public string Ssn { get; set; } = string.Empty;
    public string UserAgent { get; set; } = string.Empty;
    public CryptoDto? Crypto { get; set; }
    public string Role { get; set; } = string.Empty;
}

public class HairDto
{
    public string Color { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}

public class CoordinatesDto
{
    public double Lat { get; set; }
    public double Lng { get; set; }
}

public class AddressDto
{
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string StateCode { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public CoordinatesDto? Coordinates { get; set; }
    public string Country { get; set; } = string.Empty;
}

public class BankDto
{
    public string CardExpire { get; set; } = string.Empty;
    public string CardNumber { get; set; } = string.Empty;
    public string CardType { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
}

public class CompanyDto
{
    public string Department { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public AddressDto? Address { get; set; }
}

public class CryptoDto
{
    public string Coin { get; set; } = string.Empty;
    public string Wallet { get; set; } = string.Empty;
    public string Network { get; set; } = string.Empty;
}

