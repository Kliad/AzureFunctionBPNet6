namespace AnalyticsEclaimsV2.Application.Helper; 
public  class CronHelper
{

    public const string EVERY_5_SEC  = "5 * * * * *";
    public const string EVERY_15_SEC = "15 * * * * *";

    public const string EVERY_MINUTE     = "0 */1 * * * *";
    public const string EVERY_5_MINUTES  = "0 */5 * * * *";
    public const string EVERY_10_MINUTES = "0 */10 * * * *";
    public const string EVERY_15_MINUTES = "0 */15 * * * *";
    public const string EVERY_30_MINUTES = "0 */30 * * * *";
    public const string EVERY_45_MINUTES = "0 */45 * * * *";

    public const string EVERY_HOUR   = "0 0 * * * *";
    public const string EVERY_2HOURS = "0 0 */2 * * *";
    public const string EVERY_3HOURS = "0 0 */3 * * *";
    public const string EVERY_4HOURS = "0 0 */4 * * *";
    public const string EVERY_ONE_HOUR_AND_15MIN = "* */15 */1 * * *";
    public const string EVERY_ONE_HOUR_AND_30MIN = "* */30 */1 * * *";
    public const string EVERY_ONE_HOUR_AND_45MIN = "* */45 */1 * * *";


    public const string EVERYDAY_1AM = "0 0 1 * * *";
    public const string EVERYDAY_2AM = "0 0 2 * * *";
    public const string EVERYDAY_3AM = "0 0 3 * * *";
    public const string EVERYDAY_4AM = "0 0 4 * * *";
    public const string EVERYDAY_5AM = "0 0 5 * * *";
    public const string EVERYDAY_6AM = "0 0 6 * * *";
    public const string EVERYDAY_7AM = "0 0 7 * * *";
    public const string EVERYDAY_8AM = "0 0 8 * * *";
    public const string EVERYDAY_9AM = "0 0 9 * * *";
    public const string EVERYDAY_10AM = "0 0 10 * * *";
    public const string EVERYDAY_11AM = "0 0 11 * * *";  
     

    public const string EVERY_15MIN_215AM_10AM = "0 */15 2-10 * * *";

    public const string EVERY_15MIN_215AM_11AM = "0 */15 2-11 * * *";

    public const string EVERY_15MIN_215AM_12NM = "0 */15 2-12 * * *"; 

    public const string EVERY_15MIN_315AM_10AM = "0 */15 3-10 * * *";

    public const string EVERY_15MIN_6PM_11PM   = "0 */15 20-23 * * *";

    public const string EVERY_15MIN_315AM_12NM = "0 */15 3-12 * * *";

    public const string EVERY_15MIN_DAY3_DAY10 = "0 */15 * 3-10 * *"; 


    public const string EVERY_45MIN_DAY3_DAY15 = "0 */45 * 3-15 * *";


    public const string EVERY_30MIN_330AM_12AM = "0 */30 3-23 * * *";

    public const string EVERY_30MIN_330AM_10AM = "0 */30 3-10 * * *";

    public const string EVERY_30MIN_330AM_11AM = "0 */30 3-11 * * *";

    public const string EVERY_30MIN_630PM_11PM = "0 */30 18-23 * * *";

    public const string EVERY_30MIN_730AM_10AM = "0 */30 7-10 * * *";

    public const string EVERY_30MIN_830AM_11AM = "0 */30 8-11 * * *";


    public const string EVERY_4HOURS_5AM_9PM = "0 0 */4 5-21 * *";
}

