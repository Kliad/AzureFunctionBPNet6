using System.Data.SqlClient;
using AnalyticsEclaimsV2.Service;
using Microsoft.Extensions.Logging;
using AnalyticsEclaimsV2.Application.Helper; 
namespace AnalyticsEclaimsV2.Application.Database;

public readonly struct DBcx : IDBcx
{ 
    private readonly ILogger? Log;
    public readonly string BeaconDbString { get; }
    public readonly string AnalyticsDbString { get; } 

    public DBcx(ILogger? log)
    {
        Log = log;
        BeaconDbString = Environment.GetEnvironmentVariable(Constant.BEACONDB_CONNECTIONSTRING) ?? "";
        AnalyticsDbString = Environment.GetEnvironmentVariable(Constant.ANALYTICSECLAIMSDB_CONNECTIONSTRING) ?? "";
    }

    public async Task<bool> CheckConnectionAsync()
    {
        await Task.Yield();
        Log?.LogInformation("Checking database connections."); 
        BeaconConnection(); AnalyticsConnection();
        Log?.LogInformation("All Good!");
        return true;
    }

    private void BeaconConnection()
    {
        using SqlConnection conn = new(BeaconDbString); 
        conn.Open();
        conn.Close();
        conn.Dispose(); 
    }

    private void AnalyticsConnection()
    {
        using SqlConnection conn = new(AnalyticsDbString);
        conn.Open();
        conn.Close();
        conn.Dispose();
    }

    public async Task RunDbAction(Action action)
    {
        if (action == null) return; 
        var tried = 0;
        var retry = 10;
        var passed = false; 
        while (tried != retry && !passed)
        {
            tried++;
            await Task.Delay(5000);
            try { action.Invoke(); passed = true; }
            catch (Exception e) { Log?.LogError(e.GetBaseException().Message); }
        }
    }

    public void LogError(string message) => Log?.LogError(message);
    public void LogInfo(string message) => Log?.LogInformation(message); 
}
