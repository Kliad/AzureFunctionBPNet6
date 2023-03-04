namespace AnalyticsEclaimsV2.Domain.ZohoAnalytics;
public class FactSolutionVersion
{
    public int Id { get; set; }
    public int SysType { get; set; }
    public string SysTypeDescription { get; set; } = string.Empty;
    public string SysTypeAbbrev { get; set; } = string.Empty;
    public string SysVersion { get; set; } = string.Empty;
    public DateTime DateAppAccess { get; set; }
    public int Version { get; set; }
    public int DimClientId { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateCreated { get; set; }
} 