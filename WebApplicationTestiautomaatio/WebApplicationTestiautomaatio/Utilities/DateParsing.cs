﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationTestiautomaatio.Utilities
{
    public class DateParsing
    {
        public static DateTime ParseFinnishDate(string date)
        {
            DateTime result = DateTime.MinValue;
            string finnishFormat = "d.M.yyyy";
            try
            {
                CultureInfo fiFi = new CultureInfo("fi-FI");
                result = DateTime.ParseExact(date, finnishFormat, fiFi);
            }
            catch (Exception ex)
            {
                // TODO: kirjoitetaan poikkeu lokiin
                result = DateTime.MinValue;
            }

            // palautetaan tulos
            return result;
        }
        public static int GetWeekNumber(DateTime date)
        {
            var day = (int)CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(date);
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date.AddDays(4 - (day == 0 ? 7 : day)), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
