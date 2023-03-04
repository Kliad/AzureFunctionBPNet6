using Microsoft.Azure.WebJobs; 
using Microsoft.Azure.Functions.Worker;  
using AnalyticsEclaimsV2.Application.Helper;
using TimerTriggerAttribute = Microsoft.Azure.Functions.Worker.TimerTriggerAttribute;
using SolutionVersion = AnalyticsEclaimsV2.Application.SolutionVersion.Command;
using AnalyticsEclaimsV2.Application.Database;

namespace AnalyticsEclaimsV2Isolated.TimeTrigger;

public class ClientSolutionVersions
{     
    [Timeout("00:40:00")]
    [Function("ClientSolutionVersions")]
    public static async Task Run([TimerTrigger(CronHelper.EVERY_5_SEC)] FunctionContext executionContext)
    {
        var logger = executionContext.GetLogger("ClientSolutionVersions");
        await new SolutionVersion
        .Update(new DBcx(logger))
        .ExecuteAsync();
    }
} 
