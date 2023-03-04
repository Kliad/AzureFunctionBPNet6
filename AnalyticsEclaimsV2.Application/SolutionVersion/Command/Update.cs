using Dapper;
using System.Data.SqlClient;
using AnalyticsEclaimsV2.Service; 
using AnalyticsEclaimsV2.Application.Database; 
namespace AnalyticsEclaimsV2.Application.SolutionVersion.Command;

public sealed class Update 
{
    private readonly IDBcx cx;  
    public Update(DBcx cx) {  this.cx = cx; }

    public async Task ExecuteAsync()
    {
        Action ac = new(() => {
            using SqlConnection conn = new(cx.AnalyticsDbString);
            var selectQuery = "SELECT TOP 1 ClientName FROM DimClients ";
            var client = conn.QueryFirstOrDefault<string>(selectQuery);
            cx.LogInfo(client);
            conn.Close();
            conn.Dispose();
        });

        if (await cx.CheckConnectionAsync()) 
            await cx.RunDbAction(ac); 
    }
}