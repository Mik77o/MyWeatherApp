using System;

namespace MyWeatherApp.Helpers
{
    public static class DateAndTimeHelper
    { 
        public static string ConvertToDateAndTime(string seconds, TypeForDateAndTimeFormat type)
        {
            if (Int32.TryParse(seconds, out int result))
            {
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(result).ToLocalTime();

                switch (type)
                {
                    case TypeForDateAndTimeFormat.COMMON_DATETIME:
                        return dtDateTime.ToString("dddd, MMM dd").ToUpper();
                    case TypeForDateAndTimeFormat.TIME:
                        return dtDateTime.ToString("t").ToUpper();
                    case TypeForDateAndTimeFormat.DATE_AND_TIME_FOR_48FORECAST:
                        return dtDateTime.ToString("dddd, MMM dd - H:mm").ToUpper();
                }

            }
            return "Błąd parsowania";
        }

        public enum TypeForDateAndTimeFormat
        {
            COMMON_DATETIME,
            TIME,
            DATE_AND_TIME_FOR_48FORECAST
        }
    }
}
