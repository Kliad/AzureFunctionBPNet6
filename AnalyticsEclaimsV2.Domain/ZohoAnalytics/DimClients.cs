namespace AnalyticsEclaimsV2.Domain.ZohoAnalytics;
public class DimClients
{
    public int Id { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public DateTime? BillingStartDate { get; set; }
    public string ZohoBookContactId { get; set; } = string.Empty;
    public DateTime? FirstDateSubmitted { get; set; }
    public DateTime? DateCreated { get; set; }
    public string Product { get; set; } = string.Empty;
    public int ProductInt { get; set; }
    public int Portal { get; set; }
    public string PortalRate { get; set; } = string.Empty;
    public int HIS { get; set; }
    public string HISRate { get; set; } = string.Empty;
    public bool IsDeprecated { get; set; }
    public string ReferenceNumber { get; set; } = string.Empty;
    public string Vatable { get; set; } = string.Empty;
    public string ZohoBookContactName { get; set; } = string.Empty;
    public string Discount { get; set; } = string.Empty;
    public string DiscountValidityDate { get; set; } = string.Empty;
    public string TaxIdentificationNo { get; set; } = string.Empty;
} 