﻿using SimpleWeather.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;

namespace SimpleWeather.WeatherData
{
    public partial class WeatherAlert
    {
        public WeatherAlert(NWS.AlertGraph alert)
        {
            // Alert Type
            switch (alert._event)
            {
                case "Hurricane Local Statement":
                case "Hurricane Force Wind Watch":
                case "Hurricane Watch":
                case "Hurricane Force Wind Warning":
                case "Hurricane Warning":
                    Type = WeatherAlertType.HurricaneWindWarning;
                    break;

                case "Tornado Warning":
                    Type = WeatherAlertType.TornadoWarning;
                    break;

                case "Tornado Watch":
                    Type = WeatherAlertType.TornadoWatch;
                    break;

                case "Severe Thunderstorm Warning":
                    Type = WeatherAlertType.SevereThunderstormWarning;
                    break;

                case "Severe Thunderstorm Watch":
                    Type = WeatherAlertType.SevereThunderstormWatch;
                    break;

                case "Excessive Heat Warning":
                case "Excessive Heat Watch":
                case "Heat Advisory":
                    Type = WeatherAlertType.Heat;
                    break;

                case "Dense Fog Advisory":
                    Type = WeatherAlertType.DenseFog;
                    break;

                case "Dense Smoke Advisory":
                    Type = WeatherAlertType.DenseSmoke;
                    break;

                case "Extreme Fire Danger":
                case "Fire Warning":
                case "Fire Weather Watch":
                    Type = WeatherAlertType.Fire;
                    break;

                case "Volcano Warning":
                    Type = WeatherAlertType.Volcano;
                    break;

                case "Extreme Wind Warning":
                case "High Wind Warning":
                case "High Wind Watch":
                case "Lake Wind Advisory":
                case "Wind Advisory":
                    Type = WeatherAlertType.HighWind;
                    break;

                case "Lake Effect Snow Advisory":
                case "Lake Effect Snow Warning":
                case "Lake Effect Snow Watch":
                case "Snow Squall Warning":
                case "Ice Storm Warning":
                case "Winter Storm Warning":
                case "Winter Storm Watch":
                case "Winter Weather Advisory":
                    Type = WeatherAlertType.WinterWeather;
                    break;

                case "Earthquake Warning":
                    Type = WeatherAlertType.EarthquakeWarning;
                    break;

                case "Gale Warning":
                case "Gale Watch":
                    Type = WeatherAlertType.GaleWarning;
                    break;

                default:
                    if (alert._event.Contains("Flood Warning"))
                        Type = WeatherAlertType.FloodWarning;
                    else if (alert._event.Contains("Flood"))
                        Type = WeatherAlertType.FloodWatch;
                    else if (alert._event.Contains("Snow") || alert._event.Contains("Blizzard") ||
                        alert._event.Contains("Winter") || alert._event.Contains("Ice") ||
                        alert._event.Contains("Avalanche") || alert._event.Contains("Cold") ||
                        alert._event.Contains("Freez") || alert._event.Contains("Frost") ||
                        alert._event.Contains("Chill"))
                    {
                        Type = WeatherAlertType.WinterWeather;
                    }
                    else if (alert._event.Contains("Dust"))
                        Type = WeatherAlertType.DustAdvisory;
                    else if (alert._event.Contains("Small Craft"))
                        Type = WeatherAlertType.SmallCraft;
                    else if (alert._event.Contains("Storm"))
                        Type = WeatherAlertType.StormWarning;
                    else if (alert._event.Contains("Tsunami"))
                        Type = WeatherAlertType.TsunamiWarning;
                    else
                        Type = WeatherAlertType.SpecialWeatherAlert;
                    break;
            }

            switch (alert.severity)
            {
                case "Minor":
                    Severity = WeatherAlertSeverity.Minor;
                    break;

                case "Moderate":
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "Severe":
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "Extreme":
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "Unknown":
                default:
                    Severity = WeatherAlertSeverity.Unknown;
                    break;
            }

            Title = alert._event;
            Message = string.Format("{0}\n{1}", alert.description, alert.instruction);

            Date = alert.sent;
            ExpiresDate = alert.expires;

            Attribution = "Information provided by the U.S. National Weather Service";
        }

        public WeatherAlert(HERE.Alert alert)
        {
            // Alert Type
            switch (alert.type)
            {
                case "1": // Strong Thunderstorms Anticipated
                    Type = WeatherAlertType.SevereThunderstormWatch;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "2": // Severe Thunderstorms Anticipated
                    Type = WeatherAlertType.SevereThunderstormWarning;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "3": // Tornadoes Possible
                    Type = WeatherAlertType.TornadoWarning;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "4": // Heavy Rain Anticipated
                    Type = WeatherAlertType.FloodWatch;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "5": // Floods Anticipated
                case "6": // Flash Floods Anticipated
                    Type = WeatherAlertType.FloodWarning;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "7": // High Winds Anticipated
                    Type = WeatherAlertType.HighWind;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "8": // Heavy Snow Anticipated
                case "11": // Freezing Rain Anticipated
                case "12": // Ice Storm Anticipated
                    Type = WeatherAlertType.WinterWeather;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "9": // Blizzard Conditions Anticipated
                case "10": // Blowing Snow Anticipated
                    Type = WeatherAlertType.WinterWeather;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "13": // Snow Advisory
                case "14": // Winter Weather Advisory

                case "17": // Wind Chill Alert
                case "18": // Frost Advisory
                case "19": // Freeze Advisory

                    Type = WeatherAlertType.WinterWeather;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "15": // Heat Advisory
                    Type = WeatherAlertType.Heat;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "16": // Excessive Heat Alert
                    Type = WeatherAlertType.Heat;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "20": // Fog Anticipated
                case "22": // Smog Anticipated
                    Type = WeatherAlertType.DenseFog;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "21": // Dense Fog Anticipated
                    Type = WeatherAlertType.DenseFog;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "30": // Tropical Cyclone Conditions Anticipated
                    Type = WeatherAlertType.HurricaneWindWarning;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "31": // Hurricane Conditions Anticipated
                    Type = WeatherAlertType.HurricaneWindWarning;
                    Severity = WeatherAlertSeverity.Extreme;
                    break;

                case "32": // Small Craft Advisory Anticipated
                    Type = WeatherAlertType.SmallCraft;
                    Severity = WeatherAlertSeverity.Moderate;
                    break;

                case "33": // Gale Warning Anticipated
                    Type = WeatherAlertType.GaleWarning;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "34": // High Winds Anticipated (Winds greater than 35 || 50 mph anticipated)
                    Type = WeatherAlertType.HighWind;
                    Severity = WeatherAlertSeverity.Severe;
                    break;

                case "23": // Unknown
                case "24": // Unknown
                case "25": // Unknown
                case "26": // Unknown
                case "27": // Unknown
                case "28": // Unknown
                case "29": // Unknown
                case "35": // Heavy Surf Advisory
                case "36": // Beach Erosion Advisory
                default:
                    Type = WeatherAlertType.SpecialWeatherAlert;
                    Severity = WeatherAlertSeverity.Severe;
                    break;
            }

            Title = alert.description;
            Message = alert.description;

            SetDateTimeFromSegment(alert.timeSegment);

            Attribution = "Information provided by HERE Weather";
        }

        private void SetDateTimeFromSegment(HERE.Timesegment[] timeSegment)
        {
            if (timeSegment.Length > 1)
            {
                var startDate = DateTimeUtils.GetClosestWeekday((DayOfWeek)(int.Parse(timeSegment[0].day_of_week) - 1));
                var endDate = DateTimeUtils.GetClosestWeekday((DayOfWeek)(int.Parse(timeSegment.Last().day_of_week) - 1));

                Date = new DateTimeOffset(startDate.Add(GetTimeFromSegment(timeSegment[0].segment)), TimeSpan.Zero);
                ExpiresDate = new DateTimeOffset(endDate.Add(GetTimeFromSegment(timeSegment.Last().segment)), TimeSpan.Zero);
            }
            else
            {
                var today = DateTimeUtils.GetClosestWeekday((DayOfWeek)(int.Parse(timeSegment[0].day_of_week) - 1));

                switch (timeSegment[0].segment)
                {
                    case "M": // Morning
                    default:
                        Date = new DateTimeOffset(today.Add(GetTimeFromSegment("M")), TimeSpan.Zero);
                        ExpiresDate = new DateTimeOffset(today.Add(GetTimeFromSegment("A")), TimeSpan.Zero);
                        break;

                    case "A": // Afternoon
                        Date = new DateTimeOffset(today.Add(GetTimeFromSegment("A")), TimeSpan.Zero);
                        ExpiresDate = new DateTimeOffset(today.Add(GetTimeFromSegment("E")), TimeSpan.Zero);
                        break;

                    case "E": // Evening
                        Date = new DateTimeOffset(today.Add(GetTimeFromSegment("E")), TimeSpan.Zero);
                        ExpiresDate = new DateTimeOffset(today.Add(GetTimeFromSegment("N")), TimeSpan.Zero);
                        break;

                    case "N": // Night
                        Date = new DateTimeOffset(today.Add(GetTimeFromSegment("N")), TimeSpan.Zero);
                        ExpiresDate = new DateTimeOffset(today.AddDays(1).Add(GetTimeFromSegment("M")), TimeSpan.Zero); // The next morning
                        break;
                }
            }
        }

        private TimeSpan GetTimeFromSegment(String segment)
        {
            TimeSpan span = TimeSpan.Zero;

            switch (segment)
            {
                case "M": // Morning
                    span = new TimeSpan(5, 0, 0); // hh:mm:ss
                    break;

                case "A": // Afternoon
                    span = new TimeSpan(12, 0, 0); // hh:mm:ss
                    break;

                case "E": // Evening
                    span = new TimeSpan(17, 0, 0); // hh:mm:ss
                    break;

                case "N": // Night
                    span = new TimeSpan(21, 0, 0); // hh:mm:ss
                    break;

                default:
                    break;
            }

            return span;
        }
    }
}