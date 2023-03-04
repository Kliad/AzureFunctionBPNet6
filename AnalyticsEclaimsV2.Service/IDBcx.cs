namespace AnalyticsEclaimsV2.Service;

public interface IDBcx
{ 
    /// <summary>
    /// ILogger Log Error instance with suppressions
    /// </summary>
    void LogError(string message);

    /// <summary>
    /// ILogger Log Information instance with suppressions
    /// </summary>
    void LogInfo(string message); 

    /// <summary>
    /// Contains connection connection string for beacon database.
    /// </summary>
    string BeaconDbString { get; }

    /// <summary>
    /// Contains connection connection string for eclaims analytics database.
    /// </summary>
    string AnalyticsDbString { get; }

    /// <summary>
    /// Check Database connections and avoid jobs from running when database is unreachable.
    /// </summary>
    /// <returns>Void</returns>
    Task<bool> CheckConnectionAsync();

    /// <summary>
    /// Run SQL database actions with 10 times retry if fails.
    /// </summary>
    /// <param name="action">Dapper implementes SQL queries</param>
    /// <returns></returns>
    Task RunDbAction(Action action);
}
