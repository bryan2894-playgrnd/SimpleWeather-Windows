﻿#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Resolvers
{
    using System;
    using Utf8Json;

    public class GeneratedResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new GeneratedResolver();

        GeneratedResolver()
        {

        }

        public global::Utf8Json.IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::Utf8Json.IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(93)
            {
                {typeof(global::SimpleWeather.Bing.Value[]), 0 },
                {typeof(global::SimpleWeather.Bing.Resource[]), 1 },
                {typeof(global::SimpleWeather.Bing.Resourceset[]), 2 },
                {typeof(global::SimpleWeather.HERE.Timesegment[]), 3 },
                {typeof(global::SimpleWeather.HERE.Alert[]), 4 },
                {typeof(global::SimpleWeather.HERE.Additionaldata[]), 5 },
                {typeof(global::SimpleWeather.HERE.Suggestion[]), 6 },
                {typeof(global::SimpleWeather.HERE.Navigationposition[]), 7 },
                {typeof(global::SimpleWeather.HERE.Result[]), 8 },
                {typeof(global::SimpleWeather.HERE.View[]), 9 },
                {typeof(global::SimpleWeather.HERE.Observation[]), 10 },
                {typeof(global::SimpleWeather.HERE.Location[]), 11 },
                {typeof(global::SimpleWeather.HERE.Forecast[]), 12 },
                {typeof(global::SimpleWeather.HERE.Forecast1[]), 13 },
                {typeof(global::SimpleWeather.HERE.Astronomy1[]), 14 },
                {typeof(global::SimpleWeather.NWS.AlertGraph[]), 15 },
                {typeof(global::SimpleWeather.NWS.Period[]), 16 },
                {typeof(global::SimpleWeather.OpenWeather.Weather[]), 17 },
                {typeof(global::SimpleWeather.OpenWeather.List[]), 18 },
                {typeof(global::SimpleWeather.WeatherYahoo.Forecast[]), 19 },
                {typeof(global::SimpleWeather.Bing.Address), 20 },
                {typeof(global::SimpleWeather.Bing.Value), 21 },
                {typeof(global::SimpleWeather.Bing.Resource), 22 },
                {typeof(global::SimpleWeather.Bing.Resourceset), 23 },
                {typeof(global::SimpleWeather.Bing.AC_Rootobject), 24 },
                {typeof(global::SimpleWeather.HERE.Timesegment), 25 },
                {typeof(global::SimpleWeather.HERE.Alert), 26 },
                {typeof(global::SimpleWeather.HERE.Alerts), 27 },
                {typeof(global::SimpleWeather.HERE.Additionaldata), 28 },
                {typeof(global::SimpleWeather.HERE.Address), 29 },
                {typeof(global::SimpleWeather.HERE.Suggestion), 30 },
                {typeof(global::SimpleWeather.HERE.AC_Rootobject), 31 },
                {typeof(global::SimpleWeather.HERE.Metainfo), 32 },
                {typeof(global::SimpleWeather.HERE.Matchquality), 33 },
                {typeof(global::SimpleWeather.HERE.Displayposition), 34 },
                {typeof(global::SimpleWeather.HERE.Navigationposition), 35 },
                {typeof(global::SimpleWeather.HERE.Timezone), 36 },
                {typeof(global::SimpleWeather.HERE.Admininfo), 37 },
                {typeof(global::SimpleWeather.HERE.GeoLocation), 38 },
                {typeof(global::SimpleWeather.HERE.Result), 39 },
                {typeof(global::SimpleWeather.HERE.View), 40 },
                {typeof(global::SimpleWeather.HERE.Response), 41 },
                {typeof(global::SimpleWeather.HERE.Geo_Rootobject), 42 },
                {typeof(global::SimpleWeather.HERE.TokenRootobject), 43 },
                {typeof(global::SimpleWeather.HERE.Token), 44 },
                {typeof(global::SimpleWeather.HERE.Observation), 45 },
                {typeof(global::SimpleWeather.HERE.Location), 46 },
                {typeof(global::SimpleWeather.HERE.Observations), 47 },
                {typeof(global::SimpleWeather.HERE.Forecast), 48 },
                {typeof(global::SimpleWeather.HERE.Forecastlocation), 49 },
                {typeof(global::SimpleWeather.HERE.Dailyforecasts), 50 },
                {typeof(global::SimpleWeather.HERE.Forecast1), 51 },
                {typeof(global::SimpleWeather.HERE.Forecastlocation1), 52 },
                {typeof(global::SimpleWeather.HERE.Hourlyforecasts), 53 },
                {typeof(global::SimpleWeather.HERE.Astronomy1), 54 },
                {typeof(global::SimpleWeather.HERE.Astronomy), 55 },
                {typeof(global::SimpleWeather.HERE.Rootobject), 56 },
                {typeof(global::SimpleWeather.NWS.AlertGraph), 57 },
                {typeof(global::SimpleWeather.NWS.AlertRootobject), 58 },
                {typeof(global::SimpleWeather.NWS.PointsRootobject), 59 },
                {typeof(global::SimpleWeather.NWS.Period), 60 },
                {typeof(global::SimpleWeather.NWS.ForecastRootobject), 61 },
                {typeof(global::SimpleWeather.NWS.ObservationsStationsRootobject), 62 },
                {typeof(global::SimpleWeather.NWS.Temperature), 63 },
                {typeof(global::SimpleWeather.NWS.Dewpoint), 64 },
                {typeof(global::SimpleWeather.NWS.Winddirection), 65 },
                {typeof(global::SimpleWeather.NWS.Windspeed), 66 },
                {typeof(global::SimpleWeather.NWS.Barometricpressure), 67 },
                {typeof(global::SimpleWeather.NWS.Visibility), 68 },
                {typeof(global::SimpleWeather.NWS.Relativehumidity), 69 },
                {typeof(global::SimpleWeather.NWS.ObservationsCurrentRootobject), 70 },
                {typeof(global::SimpleWeather.OpenWeather.Coord), 71 },
                {typeof(global::SimpleWeather.OpenWeather.Weather), 72 },
                {typeof(global::SimpleWeather.OpenWeather.Main), 73 },
                {typeof(global::SimpleWeather.OpenWeather.Wind), 74 },
                {typeof(global::SimpleWeather.OpenWeather.Clouds), 75 },
                {typeof(global::SimpleWeather.OpenWeather.Rain), 76 },
                {typeof(global::SimpleWeather.OpenWeather.Snow), 77 },
                {typeof(global::SimpleWeather.OpenWeather.Sys), 78 },
                {typeof(global::SimpleWeather.OpenWeather.CurrentRootobject), 79 },
                {typeof(global::SimpleWeather.OpenWeather.ForecastSys), 80 },
                {typeof(global::SimpleWeather.OpenWeather.List), 81 },
                {typeof(global::SimpleWeather.OpenWeather.City), 82 },
                {typeof(global::SimpleWeather.OpenWeather.ForecastRootobject), 83 },
                {typeof(global::SimpleWeather.OpenWeather.Rootobject), 84 },
                {typeof(global::SimpleWeather.WeatherYahoo.Location), 85 },
                {typeof(global::SimpleWeather.WeatherYahoo.Wind), 86 },
                {typeof(global::SimpleWeather.WeatherYahoo.Atmosphere), 87 },
                {typeof(global::SimpleWeather.WeatherYahoo.Astronomy), 88 },
                {typeof(global::SimpleWeather.WeatherYahoo.Condition), 89 },
                {typeof(global::SimpleWeather.WeatherYahoo.Current_Observation), 90 },
                {typeof(global::SimpleWeather.WeatherYahoo.Forecast), 91 },
                {typeof(global::SimpleWeather.WeatherYahoo.Rootobject), 92 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Value>();
                case 1: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Resource>();
                case 2: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.Bing.Resourceset>();
                case 3: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Timesegment>();
                case 4: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Alert>();
                case 5: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Additionaldata>();
                case 6: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Suggestion>();
                case 7: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Navigationposition>();
                case 8: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Result>();
                case 9: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.View>();
                case 10: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Observation>();
                case 11: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Location>();
                case 12: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Forecast>();
                case 13: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Forecast1>();
                case 14: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.HERE.Astronomy1>();
                case 15: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.AlertGraph>();
                case 16: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.NWS.Period>();
                case 17: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.OpenWeather.Weather>();
                case 18: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.OpenWeather.List>();
                case 19: return new global::Utf8Json.Formatters.ArrayFormatter<global::SimpleWeather.WeatherYahoo.Forecast>();
                case 20: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.AddressFormatter();
                case 21: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ValueFormatter();
                case 22: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ResourceFormatter();
                case 23: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.ResourcesetFormatter();
                case 24: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing.AC_RootobjectFormatter();
                case 25: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TimesegmentFormatter();
                case 26: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AlertFormatter();
                case 27: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AlertsFormatter();
                case 28: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AdditionaldataFormatter();
                case 29: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AddressFormatter();
                case 30: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.SuggestionFormatter();
                case 31: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AC_RootobjectFormatter();
                case 32: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.MetainfoFormatter();
                case 33: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.MatchqualityFormatter();
                case 34: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.DisplaypositionFormatter();
                case 35: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.NavigationpositionFormatter();
                case 36: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TimezoneFormatter();
                case 37: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AdmininfoFormatter();
                case 38: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.GeoLocationFormatter();
                case 39: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ResultFormatter();
                case 40: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ViewFormatter();
                case 41: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ResponseFormatter();
                case 42: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Geo_RootobjectFormatter();
                case 43: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TokenRootobjectFormatter();
                case 44: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.TokenFormatter();
                case 45: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ObservationFormatter();
                case 46: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.LocationFormatter();
                case 47: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ObservationsFormatter();
                case 48: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ForecastFormatter();
                case 49: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.ForecastlocationFormatter();
                case 50: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.DailyforecastsFormatter();
                case 51: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Forecast1Formatter();
                case 52: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Forecastlocation1Formatter();
                case 53: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.HourlyforecastsFormatter();
                case 54: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.Astronomy1Formatter();
                case 55: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.AstronomyFormatter();
                case 56: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE.RootobjectFormatter();
                case 57: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.AlertGraphFormatter();
                case 58: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.AlertRootobjectFormatter();
                case 59: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PointsRootobjectFormatter();
                case 60: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.PeriodFormatter();
                case 61: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ForecastRootobjectFormatter();
                case 62: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObservationsStationsRootobjectFormatter();
                case 63: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.TemperatureFormatter();
                case 64: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.DewpointFormatter();
                case 65: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WinddirectionFormatter();
                case 66: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.WindspeedFormatter();
                case 67: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.BarometricpressureFormatter();
                case 68: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.VisibilityFormatter();
                case 69: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.RelativehumidityFormatter();
                case 70: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS.ObservationsCurrentRootobjectFormatter();
                case 71: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CoordFormatter();
                case 72: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.WeatherFormatter();
                case 73: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.MainFormatter();
                case 74: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.WindFormatter();
                case 75: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CloudsFormatter();
                case 76: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.RainFormatter();
                case 77: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.SnowFormatter();
                case 78: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.SysFormatter();
                case 79: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CurrentRootobjectFormatter();
                case 80: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ForecastSysFormatter();
                case 81: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ListFormatter();
                case 82: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.CityFormatter();
                case 83: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.ForecastRootobjectFormatter();
                case 84: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather.RootobjectFormatter();
                case 85: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.LocationFormatter();
                case 86: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.WindFormatter();
                case 87: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.AtmosphereFormatter();
                case 88: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.AstronomyFormatter();
                case 89: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.ConditionFormatter();
                case 90: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.Current_ObservationFormatter();
                case 91: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.ForecastFormatter();
                case 92: return new SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo.RootobjectFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.Bing
{
    using System;
    using Utf8Json;


    public sealed class AddressFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Address>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AddressFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryRegion"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locality"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminDistrict"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryRegionIso2"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("formattedAddress"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminDistrict2"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("streetName"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("addressLine"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("neighborhood"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("entityType"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 12},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("countryRegion"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locality"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminDistrict"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("countryRegionIso2"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("formattedAddress"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminDistrict2"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("streetName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("addressLine"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("neighborhood"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("entityType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Address value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.countryRegion);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.locality);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.adminDistrict);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.countryRegionIso2);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.formattedAddress);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.adminDistrict2);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.streetName);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.addressLine);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.neighborhood);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.postalCode);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.entityType);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.name);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Address Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __countryRegion__ = default(string);
            var __countryRegion__b__ = false;
            var __locality__ = default(string);
            var __locality__b__ = false;
            var __adminDistrict__ = default(string);
            var __adminDistrict__b__ = false;
            var __countryRegionIso2__ = default(string);
            var __countryRegionIso2__b__ = false;
            var __formattedAddress__ = default(string);
            var __formattedAddress__b__ = false;
            var __adminDistrict2__ = default(string);
            var __adminDistrict2__b__ = false;
            var __houseNumber__ = default(string);
            var __houseNumber__b__ = false;
            var __streetName__ = default(string);
            var __streetName__b__ = false;
            var __addressLine__ = default(string);
            var __addressLine__b__ = false;
            var __neighborhood__ = default(string);
            var __neighborhood__b__ = false;
            var __postalCode__ = default(string);
            var __postalCode__b__ = false;
            var __entityType__ = default(string);
            var __entityType__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __countryRegion__ = reader.ReadString();
                        __countryRegion__b__ = true;
                        break;
                    case 1:
                        __locality__ = reader.ReadString();
                        __locality__b__ = true;
                        break;
                    case 2:
                        __adminDistrict__ = reader.ReadString();
                        __adminDistrict__b__ = true;
                        break;
                    case 3:
                        __countryRegionIso2__ = reader.ReadString();
                        __countryRegionIso2__b__ = true;
                        break;
                    case 4:
                        __formattedAddress__ = reader.ReadString();
                        __formattedAddress__b__ = true;
                        break;
                    case 5:
                        __adminDistrict2__ = reader.ReadString();
                        __adminDistrict2__b__ = true;
                        break;
                    case 6:
                        __houseNumber__ = reader.ReadString();
                        __houseNumber__b__ = true;
                        break;
                    case 7:
                        __streetName__ = reader.ReadString();
                        __streetName__b__ = true;
                        break;
                    case 8:
                        __addressLine__ = reader.ReadString();
                        __addressLine__b__ = true;
                        break;
                    case 9:
                        __neighborhood__ = reader.ReadString();
                        __neighborhood__b__ = true;
                        break;
                    case 10:
                        __postalCode__ = reader.ReadString();
                        __postalCode__b__ = true;
                        break;
                    case 11:
                        __entityType__ = reader.ReadString();
                        __entityType__b__ = true;
                        break;
                    case 12:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Address();
            if(__countryRegion__b__) ____result.countryRegion = __countryRegion__;
            if(__locality__b__) ____result.locality = __locality__;
            if(__adminDistrict__b__) ____result.adminDistrict = __adminDistrict__;
            if(__countryRegionIso2__b__) ____result.countryRegionIso2 = __countryRegionIso2__;
            if(__formattedAddress__b__) ____result.formattedAddress = __formattedAddress__;
            if(__adminDistrict2__b__) ____result.adminDistrict2 = __adminDistrict2__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__streetName__b__) ____result.streetName = __streetName__;
            if(__addressLine__b__) ____result.addressLine = __addressLine__;
            if(__neighborhood__b__) ____result.neighborhood = __neighborhood__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;
            if(__entityType__b__) ____result.entityType = __entityType__;
            if(__name__b__) ____result.name = __name__;

            return ____result;
        }
    }


    public sealed class ValueFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Value>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ValueFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("__type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("__type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Value value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.__type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Address>().Serialize(ref writer, value.address, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Value Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ____type__ = default(string);
            var ____type__b__ = false;
            var __address__ = default(global::SimpleWeather.Bing.Address);
            var __address__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        ____type__ = reader.ReadString();
                        ____type__b__ = true;
                        break;
                    case 1:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Value();
            if(____type__b__) ____result.__type = ____type__;
            if(__address__b__) ____result.address = __address__;

            return ____result;
        }
    }


    public sealed class ResourceFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Resource>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResourceFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("__type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("__type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("value"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Resource value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.__type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Value[]>().Serialize(ref writer, value.value, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Resource Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ____type__ = default(string);
            var ____type__b__ = false;
            var __value__ = default(global::SimpleWeather.Bing.Value[]);
            var __value__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        ____type__ = reader.ReadString();
                        ____type__b__ = true;
                        break;
                    case 1:
                        __value__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Value[]>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Resource();
            if(____type__b__) ____result.__type = ____type__;
            if(__value__b__) ____result.value = __value__;

            return ____result;
        }
    }


    public sealed class ResourcesetFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.Resourceset>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResourcesetFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("estimatedTotal"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("resources"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("estimatedTotal"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("resources"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.Resourceset value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.estimatedTotal);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resource[]>().Serialize(ref writer, value.resources, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.Resourceset Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __estimatedTotal__ = default(int);
            var __estimatedTotal__b__ = false;
            var __resources__ = default(global::SimpleWeather.Bing.Resource[]);
            var __resources__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __estimatedTotal__ = reader.ReadInt32();
                        __estimatedTotal__b__ = true;
                        break;
                    case 1:
                        __resources__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resource[]>().Deserialize(ref reader, formatterResolver);
                        __resources__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.Resourceset();
            if(__estimatedTotal__b__) ____result.estimatedTotal = __estimatedTotal__;
            if(__resources__b__) ____result.resources = __resources__;

            return ____result;
        }
    }


    public sealed class AC_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.Bing.AC_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("authenticationResultCode"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("brandLogoUri"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("copyright"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("resourceSets"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("statusCode"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("statusDescription"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("traceId"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("authenticationResultCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("brandLogoUri"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("copyright"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("resourceSets"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("statusCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("statusDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("traceId"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.Bing.AC_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.authenticationResultCode);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.brandLogoUri);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.copyright);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resourceset[]>().Serialize(ref writer, value.resourceSets, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.statusCode);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.statusDescription);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.traceId);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.Bing.AC_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __authenticationResultCode__ = default(string);
            var __authenticationResultCode__b__ = false;
            var __brandLogoUri__ = default(string);
            var __brandLogoUri__b__ = false;
            var __copyright__ = default(string);
            var __copyright__b__ = false;
            var __resourceSets__ = default(global::SimpleWeather.Bing.Resourceset[]);
            var __resourceSets__b__ = false;
            var __statusCode__ = default(int);
            var __statusCode__b__ = false;
            var __statusDescription__ = default(string);
            var __statusDescription__b__ = false;
            var __traceId__ = default(string);
            var __traceId__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __authenticationResultCode__ = reader.ReadString();
                        __authenticationResultCode__b__ = true;
                        break;
                    case 1:
                        __brandLogoUri__ = reader.ReadString();
                        __brandLogoUri__b__ = true;
                        break;
                    case 2:
                        __copyright__ = reader.ReadString();
                        __copyright__b__ = true;
                        break;
                    case 3:
                        __resourceSets__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.Bing.Resourceset[]>().Deserialize(ref reader, formatterResolver);
                        __resourceSets__b__ = true;
                        break;
                    case 4:
                        __statusCode__ = reader.ReadInt32();
                        __statusCode__b__ = true;
                        break;
                    case 5:
                        __statusDescription__ = reader.ReadString();
                        __statusDescription__b__ = true;
                        break;
                    case 6:
                        __traceId__ = reader.ReadString();
                        __traceId__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.Bing.AC_Rootobject();
            if(__authenticationResultCode__b__) ____result.authenticationResultCode = __authenticationResultCode__;
            if(__brandLogoUri__b__) ____result.brandLogoUri = __brandLogoUri__;
            if(__copyright__b__) ____result.copyright = __copyright__;
            if(__resourceSets__b__) ____result.resourceSets = __resourceSets__;
            if(__statusCode__b__) ____result.statusCode = __statusCode__;
            if(__statusDescription__b__) ____result.statusDescription = __statusDescription__;
            if(__traceId__b__) ____result.traceId = __traceId__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.HERE
{
    using System;
    using Utf8Json;


    public sealed class TimesegmentFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Timesegment>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TimesegmentFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("segment"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("day_of_week"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("segment"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("day_of_week"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Timesegment value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.segment);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.day_of_week);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Timesegment Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(string);
            var __value__b__ = false;
            var __segment__ = default(string);
            var __segment__b__ = false;
            var __day_of_week__ = default(string);
            var __day_of_week__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = reader.ReadString();
                        __value__b__ = true;
                        break;
                    case 1:
                        __segment__ = reader.ReadString();
                        __segment__b__ = true;
                        break;
                    case 2:
                        __day_of_week__ = reader.ReadString();
                        __day_of_week__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Timesegment();
            if(__value__b__) ____result.value = __value__;
            if(__segment__b__) ____result.segment = __segment__;
            if(__day_of_week__b__) ____result.day_of_week = __day_of_week__;

            return ____result;
        }
    }


    public sealed class AlertFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Alert>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeSegment"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("timeSegment"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Alert value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timesegment[]>().Serialize(ref writer, value.timeSegment, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.description);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Alert Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __timeSegment__ = default(global::SimpleWeather.HERE.Timesegment[]);
            var __timeSegment__b__ = false;
            var __type__ = default(string);
            var __type__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __timeSegment__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timesegment[]>().Deserialize(ref reader, formatterResolver);
                        __timeSegment__b__ = true;
                        break;
                    case 1:
                        __type__ = reader.ReadString();
                        __type__b__ = true;
                        break;
                    case 2:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Alert();
            if(__timeSegment__b__) ____result.timeSegment = __timeSegment__;
            if(__type__b__) ____result.type = __type__;
            if(__description__b__) ____result.description = __description__;

            return ____result;
        }
    }


    public sealed class AlertsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Alerts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("alerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Alerts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alert[]>().Serialize(ref writer, value.alerts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Alerts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __alerts__ = default(global::SimpleWeather.HERE.Alert[]);
            var __alerts__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alert[]>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Alerts();
            if(__alerts__b__) ____result.alerts = __alerts__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class AdditionaldataFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Additionaldata>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AdditionaldataFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("key"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("key"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Additionaldata value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.value);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.key);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Additionaldata Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(string);
            var __value__b__ = false;
            var __key__ = default(string);
            var __key__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = reader.ReadString();
                        __value__b__ = true;
                        break;
                    case 1:
                        __key__ = reader.ReadString();
                        __key__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Additionaldata();
            if(__value__b__) ____result.value = __value__;
            if(__key__b__) ____result.key = __key__;

            return ____result;
        }
    }


    public sealed class AddressFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Address>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AddressFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("district"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("street"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("label"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("additionalData"), 9},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("district"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("street"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("label"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("additionalData"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Address value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.county);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.postalCode);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.district);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.street);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.label);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Additionaldata[]>().Serialize(ref writer, value.additionalData, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Address Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __county__ = default(string);
            var __county__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __postalCode__ = default(string);
            var __postalCode__b__ = false;
            var __district__ = default(string);
            var __district__b__ = false;
            var __street__ = default(string);
            var __street__b__ = false;
            var __label__ = default(string);
            var __label__b__ = false;
            var __houseNumber__ = default(string);
            var __houseNumber__b__ = false;
            var __additionalData__ = default(global::SimpleWeather.HERE.Additionaldata[]);
            var __additionalData__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 2:
                        __county__ = reader.ReadString();
                        __county__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __postalCode__ = reader.ReadString();
                        __postalCode__b__ = true;
                        break;
                    case 5:
                        __district__ = reader.ReadString();
                        __district__b__ = true;
                        break;
                    case 6:
                        __street__ = reader.ReadString();
                        __street__b__ = true;
                        break;
                    case 7:
                        __label__ = reader.ReadString();
                        __label__b__ = true;
                        break;
                    case 8:
                        __houseNumber__ = reader.ReadString();
                        __houseNumber__b__ = true;
                        break;
                    case 9:
                        __additionalData__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Additionaldata[]>().Deserialize(ref reader, formatterResolver);
                        __additionalData__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Address();
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__county__b__) ____result.county = __county__;
            if(__city__b__) ____result.city = __city__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;
            if(__district__b__) ____result.district = __district__;
            if(__street__b__) ____result.street = __street__;
            if(__label__b__) ____result.label = __label__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__additionalData__b__) ____result.additionalData = __additionalData__;

            return ____result;
        }
    }


    public sealed class SuggestionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Suggestion>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SuggestionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("label"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("language"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("countryCode"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationId"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchLevel"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("label"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("language"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("countryCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationId"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchLevel"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Suggestion value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.label);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.language);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.countryCode);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.locationId);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Serialize(ref writer, value.address, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.matchLevel);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Suggestion Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __label__ = default(string);
            var __label__b__ = false;
            var __language__ = default(string);
            var __language__b__ = false;
            var __countryCode__ = default(string);
            var __countryCode__b__ = false;
            var __locationId__ = default(string);
            var __locationId__b__ = false;
            var __address__ = default(global::SimpleWeather.HERE.Address);
            var __address__b__ = false;
            var __matchLevel__ = default(string);
            var __matchLevel__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __label__ = reader.ReadString();
                        __label__b__ = true;
                        break;
                    case 1:
                        __language__ = reader.ReadString();
                        __language__b__ = true;
                        break;
                    case 2:
                        __countryCode__ = reader.ReadString();
                        __countryCode__b__ = true;
                        break;
                    case 3:
                        __locationId__ = reader.ReadString();
                        __locationId__b__ = true;
                        break;
                    case 4:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    case 5:
                        __matchLevel__ = reader.ReadString();
                        __matchLevel__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Suggestion();
            if(__label__b__) ____result.label = __label__;
            if(__language__b__) ____result.language = __language__;
            if(__countryCode__b__) ____result.countryCode = __countryCode__;
            if(__locationId__b__) ____result.locationId = __locationId__;
            if(__address__b__) ____result.address = __address__;
            if(__matchLevel__b__) ____result.matchLevel = __matchLevel__;

            return ____result;
        }
    }


    public sealed class AC_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.AC_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AC_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("suggestions"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("suggestions"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.AC_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Suggestion[]>().Serialize(ref writer, value.suggestions, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.AC_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __suggestions__ = default(global::SimpleWeather.HERE.Suggestion[]);
            var __suggestions__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __suggestions__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Suggestion[]>().Deserialize(ref reader, formatterResolver);
                        __suggestions__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.AC_Rootobject();
            if(__suggestions__b__) ____result.suggestions = __suggestions__;

            return ____result;
        }
    }


    public sealed class MetainfoFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Metainfo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MetainfoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timestamp"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nextPageInformation"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("timestamp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nextPageInformation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Metainfo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.timestamp);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.nextPageInformation);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Metainfo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __timestamp__ = default(string);
            var __timestamp__b__ = false;
            var __nextPageInformation__ = default(string);
            var __nextPageInformation__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __timestamp__ = reader.ReadString();
                        __timestamp__b__ = true;
                        break;
                    case 1:
                        __nextPageInformation__ = reader.ReadString();
                        __nextPageInformation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Metainfo();
            if(__timestamp__b__) ____result.timestamp = __timestamp__;
            if(__nextPageInformation__b__) ____result.nextPageInformation = __nextPageInformation__;

            return ____result;
        }
    }


    public sealed class MatchqualityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Matchquality>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MatchqualityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("county"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("district"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("street"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("houseNumber"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("postalCode"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("county"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("district"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("street"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("houseNumber"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("postalCode"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Matchquality value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.country);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.state);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.county);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.district);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<float[]>().Serialize(ref writer, value.street, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.houseNumber);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteSingle(value.postalCode);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Matchquality Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __country__ = default(float);
            var __country__b__ = false;
            var __state__ = default(float);
            var __state__b__ = false;
            var __county__ = default(float);
            var __county__b__ = false;
            var __city__ = default(float);
            var __city__b__ = false;
            var __district__ = default(float);
            var __district__b__ = false;
            var __street__ = default(float[]);
            var __street__b__ = false;
            var __houseNumber__ = default(float);
            var __houseNumber__b__ = false;
            var __postalCode__ = default(float);
            var __postalCode__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __country__ = reader.ReadSingle();
                        __country__b__ = true;
                        break;
                    case 1:
                        __state__ = reader.ReadSingle();
                        __state__b__ = true;
                        break;
                    case 2:
                        __county__ = reader.ReadSingle();
                        __county__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadSingle();
                        __city__b__ = true;
                        break;
                    case 4:
                        __district__ = reader.ReadSingle();
                        __district__b__ = true;
                        break;
                    case 5:
                        __street__ = formatterResolver.GetFormatterWithVerify<float[]>().Deserialize(ref reader, formatterResolver);
                        __street__b__ = true;
                        break;
                    case 6:
                        __houseNumber__ = reader.ReadSingle();
                        __houseNumber__b__ = true;
                        break;
                    case 7:
                        __postalCode__ = reader.ReadSingle();
                        __postalCode__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Matchquality();
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__county__b__) ____result.county = __county__;
            if(__city__b__) ____result.city = __city__;
            if(__district__b__) ____result.district = __district__;
            if(__street__b__) ____result.street = __street__;
            if(__houseNumber__b__) ____result.houseNumber = __houseNumber__;
            if(__postalCode__b__) ____result.postalCode = __postalCode__;

            return ____result;
        }
    }


    public sealed class DisplaypositionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Displayposition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DisplaypositionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Displayposition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.longitude);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Displayposition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 1:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Displayposition();
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;

            return ____result;
        }
    }


    public sealed class NavigationpositionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Navigationposition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public NavigationpositionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Navigationposition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.longitude);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Navigationposition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 1:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Navigationposition();
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;

            return ____result;
        }
    }


    public sealed class TimezoneFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Timezone>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TimezoneFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("offset"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rawOffset"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameShort"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameLong"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameDstShort"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nameDstLong"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("inDaylightTime"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dstSavings"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("offset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rawOffset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameLong"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameDstShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nameDstLong"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("inDaylightTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dstSavings"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Timezone value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.offset);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.rawOffset);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.nameShort);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.nameLong);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.nameDstShort);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.nameDstLong);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteBoolean(value.inDaylightTime);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.dstSavings);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.id);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Timezone Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __offset__ = default(int);
            var __offset__b__ = false;
            var __rawOffset__ = default(int);
            var __rawOffset__b__ = false;
            var __nameShort__ = default(string);
            var __nameShort__b__ = false;
            var __nameLong__ = default(string);
            var __nameLong__b__ = false;
            var __nameDstShort__ = default(string);
            var __nameDstShort__b__ = false;
            var __nameDstLong__ = default(string);
            var __nameDstLong__b__ = false;
            var __inDaylightTime__ = default(bool);
            var __inDaylightTime__b__ = false;
            var __dstSavings__ = default(int);
            var __dstSavings__b__ = false;
            var __id__ = default(string);
            var __id__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __offset__ = reader.ReadInt32();
                        __offset__b__ = true;
                        break;
                    case 1:
                        __rawOffset__ = reader.ReadInt32();
                        __rawOffset__b__ = true;
                        break;
                    case 2:
                        __nameShort__ = reader.ReadString();
                        __nameShort__b__ = true;
                        break;
                    case 3:
                        __nameLong__ = reader.ReadString();
                        __nameLong__b__ = true;
                        break;
                    case 4:
                        __nameDstShort__ = reader.ReadString();
                        __nameDstShort__b__ = true;
                        break;
                    case 5:
                        __nameDstLong__ = reader.ReadString();
                        __nameDstLong__b__ = true;
                        break;
                    case 6:
                        __inDaylightTime__ = reader.ReadBoolean();
                        __inDaylightTime__b__ = true;
                        break;
                    case 7:
                        __dstSavings__ = reader.ReadInt32();
                        __dstSavings__b__ = true;
                        break;
                    case 8:
                        __id__ = reader.ReadString();
                        __id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Timezone();
            if(__offset__b__) ____result.offset = __offset__;
            if(__rawOffset__b__) ____result.rawOffset = __rawOffset__;
            if(__nameShort__b__) ____result.nameShort = __nameShort__;
            if(__nameLong__b__) ____result.nameLong = __nameLong__;
            if(__nameDstShort__b__) ____result.nameDstShort = __nameDstShort__;
            if(__nameDstLong__b__) ____result.nameDstLong = __nameDstLong__;
            if(__inDaylightTime__b__) ____result.inDaylightTime = __inDaylightTime__;
            if(__dstSavings__b__) ____result.dstSavings = __dstSavings__;
            if(__id__b__) ____result.id = __id__;

            return ____result;
        }
    }


    public sealed class AdmininfoFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Admininfo>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AdmininfoFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTime"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("currency"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("drivingSide"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("systemOfMeasure"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeZone"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("localTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("currency"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("drivingSide"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("systemOfMeasure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timeZone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Admininfo value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.localTime);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.currency);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.drivingSide);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.systemOfMeasure);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timezone>().Serialize(ref writer, value.timeZone, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Admininfo Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __localTime__ = default(string);
            var __localTime__b__ = false;
            var __currency__ = default(string);
            var __currency__b__ = false;
            var __drivingSide__ = default(string);
            var __drivingSide__b__ = false;
            var __systemOfMeasure__ = default(string);
            var __systemOfMeasure__b__ = false;
            var __timeZone__ = default(global::SimpleWeather.HERE.Timezone);
            var __timeZone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __localTime__ = reader.ReadString();
                        __localTime__b__ = true;
                        break;
                    case 1:
                        __currency__ = reader.ReadString();
                        __currency__b__ = true;
                        break;
                    case 2:
                        __drivingSide__ = reader.ReadString();
                        __drivingSide__b__ = true;
                        break;
                    case 3:
                        __systemOfMeasure__ = reader.ReadString();
                        __systemOfMeasure__b__ = true;
                        break;
                    case 4:
                        __timeZone__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Timezone>().Deserialize(ref reader, formatterResolver);
                        __timeZone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Admininfo();
            if(__localTime__b__) ____result.localTime = __localTime__;
            if(__currency__b__) ____result.currency = __currency__;
            if(__drivingSide__b__) ____result.drivingSide = __drivingSide__;
            if(__systemOfMeasure__b__) ____result.systemOfMeasure = __systemOfMeasure__;
            if(__timeZone__b__) ____result.timeZone = __timeZone__;

            return ____result;
        }
    }


    public sealed class GeoLocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.GeoLocation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public GeoLocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationId"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("locationType"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("displayPosition"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("navigationPosition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("address"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("adminInfo"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("locationId"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("locationType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("displayPosition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("navigationPosition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("address"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("adminInfo"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.GeoLocation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.locationId);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.locationType);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Displayposition>().Serialize(ref writer, value.displayPosition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Navigationposition[]>().Serialize(ref writer, value.navigationPosition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Serialize(ref writer, value.address, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Admininfo>().Serialize(ref writer, value.adminInfo, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.GeoLocation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __locationId__ = default(string);
            var __locationId__b__ = false;
            var __locationType__ = default(string);
            var __locationType__b__ = false;
            var __displayPosition__ = default(global::SimpleWeather.HERE.Displayposition);
            var __displayPosition__b__ = false;
            var __navigationPosition__ = default(global::SimpleWeather.HERE.Navigationposition[]);
            var __navigationPosition__b__ = false;
            var __address__ = default(global::SimpleWeather.HERE.Address);
            var __address__b__ = false;
            var __adminInfo__ = default(global::SimpleWeather.HERE.Admininfo);
            var __adminInfo__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __locationId__ = reader.ReadString();
                        __locationId__b__ = true;
                        break;
                    case 1:
                        __locationType__ = reader.ReadString();
                        __locationType__b__ = true;
                        break;
                    case 2:
                        __displayPosition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Displayposition>().Deserialize(ref reader, formatterResolver);
                        __displayPosition__b__ = true;
                        break;
                    case 3:
                        __navigationPosition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Navigationposition[]>().Deserialize(ref reader, formatterResolver);
                        __navigationPosition__b__ = true;
                        break;
                    case 4:
                        __address__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Address>().Deserialize(ref reader, formatterResolver);
                        __address__b__ = true;
                        break;
                    case 5:
                        __adminInfo__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Admininfo>().Deserialize(ref reader, formatterResolver);
                        __adminInfo__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.GeoLocation();
            if(__locationId__b__) ____result.locationId = __locationId__;
            if(__locationType__b__) ____result.locationType = __locationType__;
            if(__displayPosition__b__) ____result.displayPosition = __displayPosition__;
            if(__navigationPosition__b__) ____result.navigationPosition = __navigationPosition__;
            if(__address__b__) ____result.address = __address__;
            if(__adminInfo__b__) ____result.adminInfo = __adminInfo__;

            return ____result;
        }
    }


    public sealed class ResultFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Result>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResultFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relevance"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchLevel"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchQuality"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("matchType"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("relevance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchLevel"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchQuality"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("matchType"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("location"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Result value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.relevance);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.matchLevel);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Matchquality>().Serialize(ref writer, value.matchQuality, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.matchType);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.GeoLocation>().Serialize(ref writer, value.location, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Result Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __relevance__ = default(float);
            var __relevance__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __matchLevel__ = default(string);
            var __matchLevel__b__ = false;
            var __matchQuality__ = default(global::SimpleWeather.HERE.Matchquality);
            var __matchQuality__b__ = false;
            var __matchType__ = default(string);
            var __matchType__b__ = false;
            var __location__ = default(global::SimpleWeather.HERE.GeoLocation);
            var __location__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __relevance__ = reader.ReadSingle();
                        __relevance__b__ = true;
                        break;
                    case 1:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 2:
                        __matchLevel__ = reader.ReadString();
                        __matchLevel__b__ = true;
                        break;
                    case 3:
                        __matchQuality__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Matchquality>().Deserialize(ref reader, formatterResolver);
                        __matchQuality__b__ = true;
                        break;
                    case 4:
                        __matchType__ = reader.ReadString();
                        __matchType__b__ = true;
                        break;
                    case 5:
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.GeoLocation>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Result();
            if(__relevance__b__) ____result.relevance = __relevance__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__matchLevel__b__) ____result.matchLevel = __matchLevel__;
            if(__matchQuality__b__) ____result.matchQuality = __matchQuality__;
            if(__matchType__b__) ____result.matchType = __matchType__;
            if(__location__b__) ____result.location = __location__;

            return ____result;
        }
    }


    public sealed class ViewFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.View>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ViewFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("result"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("viewId"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("result"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("viewId"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.View value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Result[]>().Serialize(ref writer, value.result, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.viewId);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.View Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __result__ = default(global::SimpleWeather.HERE.Result[]);
            var __result__b__ = false;
            var __viewId__ = default(int);
            var __viewId__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __result__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Result[]>().Deserialize(ref reader, formatterResolver);
                        __result__b__ = true;
                        break;
                    case 1:
                        __viewId__ = reader.ReadInt32();
                        __viewId__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.View();
            if(__result__b__) ____result.result = __result__;
            if(__viewId__b__) ____result.viewId = __viewId__;

            return ____result;
        }
    }


    public sealed class ResponseFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Response>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ResponseFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metaInfo"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("view"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("metaInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("view"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Response value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Metainfo>().Serialize(ref writer, value.metaInfo, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.View[]>().Serialize(ref writer, value.view, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Response Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __metaInfo__ = default(global::SimpleWeather.HERE.Metainfo);
            var __metaInfo__b__ = false;
            var __view__ = default(global::SimpleWeather.HERE.View[]);
            var __view__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __metaInfo__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Metainfo>().Deserialize(ref reader, formatterResolver);
                        __metaInfo__b__ = true;
                        break;
                    case 1:
                        __view__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.View[]>().Deserialize(ref reader, formatterResolver);
                        __view__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Response();
            if(__metaInfo__b__) ____result.metaInfo = __metaInfo__;
            if(__view__b__) ____result.view = __view__;

            return ____result;
        }
    }


    public sealed class Geo_RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Geo_Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Geo_RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("response"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("response"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Geo_Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Response>().Serialize(ref writer, value.response, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Geo_Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __response__ = default(global::SimpleWeather.HERE.Response);
            var __response__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __response__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Response>().Deserialize(ref reader, formatterResolver);
                        __response__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Geo_Rootobject();
            if(__response__b__) ____result.response = __response__;

            return ____result;
        }
    }


    public sealed class TokenRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.TokenRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TokenRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("access_token"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("token_type"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires_in"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("access_token"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("token_type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires_in"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.TokenRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.access_token);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.token_type);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.expires_in);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.TokenRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __access_token__ = default(string);
            var __access_token__b__ = false;
            var __token_type__ = default(string);
            var __token_type__b__ = false;
            var __expires_in__ = default(int);
            var __expires_in__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __access_token__ = reader.ReadString();
                        __access_token__b__ = true;
                        break;
                    case 1:
                        __token_type__ = reader.ReadString();
                        __token_type__b__ = true;
                        break;
                    case 2:
                        __expires_in__ = reader.ReadInt32();
                        __expires_in__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.TokenRootobject();
            if(__access_token__b__) ____result.access_token = __access_token__;
            if(__token_type__b__) ____result.token_type = __token_type__;
            if(__expires_in__b__) ____result.expires_in = __expires_in__;

            return ____result;
        }
    }


    internal sealed class TokenFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Token>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TokenFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("access_token"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expiration_date"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("access_token"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expiration_date"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Token value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.access_token);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Serialize(ref writer, value.expiration_date, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Token Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __access_token__ = default(string);
            var __access_token__b__ = false;
            var __expiration_date__ = default(global::System.DateTime);
            var __expiration_date__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __access_token__ = reader.ReadString();
                        __access_token__b__ = true;
                        break;
                    case 1:
                        __expiration_date__ = formatterResolver.GetFormatterWithVerify<global::System.DateTime>().Deserialize(ref reader, formatterResolver);
                        __expiration_date__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Token();
            if(__access_token__b__) ____result.access_token = __access_token__;
            if(__expiration_date__b__) ____result.expiration_date = __expiration_date__;

            return ____result;
        }
    }


    public sealed class ObservationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Observation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("highTemperature"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lowTemperature"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation1H"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation3H"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation6H"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation12H"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitation24H"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerTrend"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowCover"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ageMinutes"), 30},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("activeAlerts"), 31},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 32},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 33},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 34},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 35},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 36},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 37},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("elevation"), 38},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 39},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("highTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lowTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation1H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation3H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation6H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation12H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitation24H"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerTrend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowCover"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ageMinutes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("activeAlerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("elevation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Observation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.highTemperature);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.lowTemperature);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.precipitation1H);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.precipitation3H);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.precipitation6H);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.precipitation12H);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.precipitation24H);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerTrend);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.snowCover);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[30]);
            writer.WriteString(value.ageMinutes);
            writer.WriteRaw(this.____stringByteKeys[31]);
            writer.WriteString(value.activeAlerts);
            writer.WriteRaw(this.____stringByteKeys[32]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[33]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[34]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[35]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[36]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[37]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[38]);
            writer.WriteSingle(value.elevation);
            writer.WriteRaw(this.____stringByteKeys[39]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Observation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperature__ = default(string);
            var __temperature__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __highTemperature__ = default(string);
            var __highTemperature__b__ = false;
            var __lowTemperature__ = default(string);
            var __lowTemperature__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitation1H__ = default(string);
            var __precipitation1H__b__ = false;
            var __precipitation3H__ = default(string);
            var __precipitation3H__b__ = false;
            var __precipitation6H__ = default(string);
            var __precipitation6H__b__ = false;
            var __precipitation12H__ = default(string);
            var __precipitation12H__b__ = false;
            var __precipitation24H__ = default(string);
            var __precipitation24H__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __barometerTrend__ = default(string);
            var __barometerTrend__b__ = false;
            var __visibility__ = default(string);
            var __visibility__b__ = false;
            var __snowCover__ = default(string);
            var __snowCover__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __ageMinutes__ = default(string);
            var __ageMinutes__b__ = false;
            var __activeAlerts__ = default(string);
            var __activeAlerts__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __elevation__ = default(float);
            var __elevation__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperature__ = reader.ReadString();
                        __temperature__b__ = true;
                        break;
                    case 5:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 6:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 7:
                        __highTemperature__ = reader.ReadString();
                        __highTemperature__b__ = true;
                        break;
                    case 8:
                        __lowTemperature__ = reader.ReadString();
                        __lowTemperature__b__ = true;
                        break;
                    case 9:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 10:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 11:
                        __precipitation1H__ = reader.ReadString();
                        __precipitation1H__b__ = true;
                        break;
                    case 12:
                        __precipitation3H__ = reader.ReadString();
                        __precipitation3H__b__ = true;
                        break;
                    case 13:
                        __precipitation6H__ = reader.ReadString();
                        __precipitation6H__b__ = true;
                        break;
                    case 14:
                        __precipitation12H__ = reader.ReadString();
                        __precipitation12H__b__ = true;
                        break;
                    case 15:
                        __precipitation24H__ = reader.ReadString();
                        __precipitation24H__b__ = true;
                        break;
                    case 16:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 17:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 18:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 19:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 20:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 21:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 22:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 23:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 24:
                        __barometerTrend__ = reader.ReadString();
                        __barometerTrend__b__ = true;
                        break;
                    case 25:
                        __visibility__ = reader.ReadString();
                        __visibility__b__ = true;
                        break;
                    case 26:
                        __snowCover__ = reader.ReadString();
                        __snowCover__b__ = true;
                        break;
                    case 27:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 28:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 29:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 30:
                        __ageMinutes__ = reader.ReadString();
                        __ageMinutes__b__ = true;
                        break;
                    case 31:
                        __activeAlerts__ = reader.ReadString();
                        __activeAlerts__b__ = true;
                        break;
                    case 32:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 33:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 34:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 35:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 36:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 37:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 38:
                        __elevation__ = reader.ReadSingle();
                        __elevation__b__ = true;
                        break;
                    case 39:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Observation();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__highTemperature__b__) ____result.highTemperature = __highTemperature__;
            if(__lowTemperature__b__) ____result.lowTemperature = __lowTemperature__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitation1H__b__) ____result.precipitation1H = __precipitation1H__;
            if(__precipitation3H__b__) ____result.precipitation3H = __precipitation3H__;
            if(__precipitation6H__b__) ____result.precipitation6H = __precipitation6H__;
            if(__precipitation12H__b__) ____result.precipitation12H = __precipitation12H__;
            if(__precipitation24H__b__) ____result.precipitation24H = __precipitation24H__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__barometerTrend__b__) ____result.barometerTrend = __barometerTrend__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__snowCover__b__) ____result.snowCover = __snowCover__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__ageMinutes__b__) ____result.ageMinutes = __ageMinutes__;
            if(__activeAlerts__b__) ____result.activeAlerts = __activeAlerts__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__elevation__b__) ____result.elevation = __elevation__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observation"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("observation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observation[]>().Serialize(ref writer, value.observation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __observation__ = default(global::SimpleWeather.HERE.Observation[]);
            var __observation__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __observation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observation[]>().Deserialize(ref reader, formatterResolver);
                        __observation__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Location();
            if(__observation__b__) ____result.observation = __observation__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class ObservationsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Observations>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("location"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Observations value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Location[]>().Serialize(ref writer, value.location, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Observations Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __location__ = default(global::SimpleWeather.HERE.Location[]);
            var __location__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Location[]>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Observations();
            if(__location__b__) ____result.location = __location__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("highTemperature"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lowTemperature"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationProbability"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rainFall"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowFall"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortScale"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortDescription"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvIndex"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvDesc"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dayOfWeek"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 30},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("highTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lowTemperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationProbability"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rainFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortScale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvIndex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dayOfWeek"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.highTemperature);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.lowTemperature);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.precipitationProbability);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.rainFall);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.snowFall);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.beaufortScale);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.beaufortDescription);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.uvIndex);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.uvDesc);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.dayOfWeek);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.weekday);
            writer.WriteRaw(this.____stringByteKeys[30]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __highTemperature__ = default(string);
            var __highTemperature__b__ = false;
            var __lowTemperature__ = default(string);
            var __lowTemperature__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitationProbability__ = default(string);
            var __precipitationProbability__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __rainFall__ = default(string);
            var __rainFall__b__ = false;
            var __snowFall__ = default(string);
            var __snowFall__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __beaufortScale__ = default(string);
            var __beaufortScale__b__ = false;
            var __beaufortDescription__ = default(string);
            var __beaufortDescription__b__ = false;
            var __uvIndex__ = default(string);
            var __uvIndex__b__ = false;
            var __uvDesc__ = default(string);
            var __uvDesc__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __dayOfWeek__ = default(string);
            var __dayOfWeek__b__ = false;
            var __weekday__ = default(string);
            var __weekday__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 5:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 6:
                        __highTemperature__ = reader.ReadString();
                        __highTemperature__b__ = true;
                        break;
                    case 7:
                        __lowTemperature__ = reader.ReadString();
                        __lowTemperature__b__ = true;
                        break;
                    case 8:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 9:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 10:
                        __precipitationProbability__ = reader.ReadString();
                        __precipitationProbability__b__ = true;
                        break;
                    case 11:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 12:
                        __rainFall__ = reader.ReadString();
                        __rainFall__b__ = true;
                        break;
                    case 13:
                        __snowFall__ = reader.ReadString();
                        __snowFall__b__ = true;
                        break;
                    case 14:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 15:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 16:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 17:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 18:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 19:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 20:
                        __beaufortScale__ = reader.ReadString();
                        __beaufortScale__b__ = true;
                        break;
                    case 21:
                        __beaufortDescription__ = reader.ReadString();
                        __beaufortDescription__b__ = true;
                        break;
                    case 22:
                        __uvIndex__ = reader.ReadString();
                        __uvIndex__b__ = true;
                        break;
                    case 23:
                        __uvDesc__ = reader.ReadString();
                        __uvDesc__b__ = true;
                        break;
                    case 24:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 25:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 26:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 27:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 28:
                        __dayOfWeek__ = reader.ReadString();
                        __dayOfWeek__b__ = true;
                        break;
                    case 29:
                        __weekday__ = reader.ReadString();
                        __weekday__b__ = true;
                        break;
                    case 30:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecast();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__highTemperature__b__) ____result.highTemperature = __highTemperature__;
            if(__lowTemperature__b__) ____result.lowTemperature = __lowTemperature__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitationProbability__b__) ____result.precipitationProbability = __precipitationProbability__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__rainFall__b__) ____result.rainFall = __rainFall__;
            if(__snowFall__b__) ____result.snowFall = __snowFall__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__beaufortScale__b__) ____result.beaufortScale = __beaufortScale__;
            if(__beaufortDescription__b__) ____result.beaufortDescription = __beaufortDescription__;
            if(__uvIndex__b__) ____result.uvIndex = __uvIndex__;
            if(__uvDesc__b__) ____result.uvDesc = __uvDesc__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__dayOfWeek__b__) ____result.dayOfWeek = __dayOfWeek__;
            if(__weekday__b__) ____result.weekday = __weekday__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class ForecastlocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecastlocation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastlocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecastlocation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast[]>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecastlocation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecast__ = default(global::SimpleWeather.HERE.Forecast[]);
            var __forecast__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast[]>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecastlocation();
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class DailyforecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Dailyforecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DailyforecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastLocation"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecastLocation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Dailyforecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation>().Serialize(ref writer, value.forecastLocation, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Dailyforecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecastLocation__ = default(global::SimpleWeather.HERE.Forecastlocation);
            var __forecastLocation__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __forecastLocation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation>().Deserialize(ref reader, formatterResolver);
                        __forecastLocation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Dailyforecasts();
            if(__forecastLocation__b__) ____result.forecastLocation = __forecastLocation__;

            return ____result;
        }
    }


    public sealed class Forecast1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecast1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Forecast1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("daylight"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyInfo"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("skyDescription"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("comfort"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("humidity"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewPoint"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationProbability"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("precipitationDesc"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rainFall"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snowFall"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airInfo"), 13},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("airDescription"), 14},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 15},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 16},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDesc"), 17},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDescShort"), 18},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortScale"), 19},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("beaufortDescription"), 20},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvIndex"), 21},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("uvDesc"), 22},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 23},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometerPressure"), 24},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 25},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 26},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconLink"), 27},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dayOfWeek"), 28},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weekday"), 29},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 30},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTime"), 31},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("localTimeFormat"), 32},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("daylight"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("skyDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("comfort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("humidity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewPoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationProbability"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("precipitationDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rainFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snowFall"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airInfo"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("airDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDescShort"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortScale"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("beaufortDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvIndex"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("uvDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometerPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconLink"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dayOfWeek"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weekday"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("localTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("localTimeFormat"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecast1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.daylight);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.skyInfo);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.skyDescription);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.temperatureDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.comfort);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.humidity);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.dewPoint);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.precipitationProbability);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.precipitationDesc);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.rainFall);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.snowFall);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteString(value.airInfo);
            writer.WriteRaw(this.____stringByteKeys[14]);
            writer.WriteString(value.airDescription);
            writer.WriteRaw(this.____stringByteKeys[15]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[16]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[17]);
            writer.WriteString(value.windDesc);
            writer.WriteRaw(this.____stringByteKeys[18]);
            writer.WriteString(value.windDescShort);
            writer.WriteRaw(this.____stringByteKeys[19]);
            writer.WriteString(value.beaufortScale);
            writer.WriteRaw(this.____stringByteKeys[20]);
            writer.WriteString(value.beaufortDescription);
            writer.WriteRaw(this.____stringByteKeys[21]);
            writer.WriteString(value.uvIndex);
            writer.WriteRaw(this.____stringByteKeys[22]);
            writer.WriteString(value.uvDesc);
            writer.WriteRaw(this.____stringByteKeys[23]);
            writer.WriteString(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[24]);
            writer.WriteString(value.barometerPressure);
            writer.WriteRaw(this.____stringByteKeys[25]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[26]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[27]);
            writer.WriteString(value.iconLink);
            writer.WriteRaw(this.____stringByteKeys[28]);
            writer.WriteString(value.dayOfWeek);
            writer.WriteRaw(this.____stringByteKeys[29]);
            writer.WriteString(value.weekday);
            writer.WriteRaw(this.____stringByteKeys[30]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[31]);
            writer.WriteString(value.localTime);
            writer.WriteRaw(this.____stringByteKeys[32]);
            writer.WriteString(value.localTimeFormat);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecast1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __daylight__ = default(string);
            var __daylight__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __skyInfo__ = default(string);
            var __skyInfo__b__ = false;
            var __skyDescription__ = default(string);
            var __skyDescription__b__ = false;
            var __temperature__ = default(string);
            var __temperature__b__ = false;
            var __temperatureDesc__ = default(string);
            var __temperatureDesc__b__ = false;
            var __comfort__ = default(string);
            var __comfort__b__ = false;
            var __humidity__ = default(string);
            var __humidity__b__ = false;
            var __dewPoint__ = default(string);
            var __dewPoint__b__ = false;
            var __precipitationProbability__ = default(string);
            var __precipitationProbability__b__ = false;
            var __precipitationDesc__ = default(string);
            var __precipitationDesc__b__ = false;
            var __rainFall__ = default(string);
            var __rainFall__b__ = false;
            var __snowFall__ = default(string);
            var __snowFall__b__ = false;
            var __airInfo__ = default(string);
            var __airInfo__b__ = false;
            var __airDescription__ = default(string);
            var __airDescription__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __windDesc__ = default(string);
            var __windDesc__b__ = false;
            var __windDescShort__ = default(string);
            var __windDescShort__b__ = false;
            var __beaufortScale__ = default(string);
            var __beaufortScale__b__ = false;
            var __beaufortDescription__ = default(string);
            var __beaufortDescription__b__ = false;
            var __uvIndex__ = default(string);
            var __uvIndex__b__ = false;
            var __uvDesc__ = default(string);
            var __uvDesc__b__ = false;
            var __visibility__ = default(string);
            var __visibility__b__ = false;
            var __barometerPressure__ = default(string);
            var __barometerPressure__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __iconLink__ = default(string);
            var __iconLink__b__ = false;
            var __dayOfWeek__ = default(string);
            var __dayOfWeek__b__ = false;
            var __weekday__ = default(string);
            var __weekday__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;
            var __localTime__ = default(string);
            var __localTime__b__ = false;
            var __localTimeFormat__ = default(string);
            var __localTimeFormat__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __daylight__ = reader.ReadString();
                        __daylight__b__ = true;
                        break;
                    case 1:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 2:
                        __skyInfo__ = reader.ReadString();
                        __skyInfo__b__ = true;
                        break;
                    case 3:
                        __skyDescription__ = reader.ReadString();
                        __skyDescription__b__ = true;
                        break;
                    case 4:
                        __temperature__ = reader.ReadString();
                        __temperature__b__ = true;
                        break;
                    case 5:
                        __temperatureDesc__ = reader.ReadString();
                        __temperatureDesc__b__ = true;
                        break;
                    case 6:
                        __comfort__ = reader.ReadString();
                        __comfort__b__ = true;
                        break;
                    case 7:
                        __humidity__ = reader.ReadString();
                        __humidity__b__ = true;
                        break;
                    case 8:
                        __dewPoint__ = reader.ReadString();
                        __dewPoint__b__ = true;
                        break;
                    case 9:
                        __precipitationProbability__ = reader.ReadString();
                        __precipitationProbability__b__ = true;
                        break;
                    case 10:
                        __precipitationDesc__ = reader.ReadString();
                        __precipitationDesc__b__ = true;
                        break;
                    case 11:
                        __rainFall__ = reader.ReadString();
                        __rainFall__b__ = true;
                        break;
                    case 12:
                        __snowFall__ = reader.ReadString();
                        __snowFall__b__ = true;
                        break;
                    case 13:
                        __airInfo__ = reader.ReadString();
                        __airInfo__b__ = true;
                        break;
                    case 14:
                        __airDescription__ = reader.ReadString();
                        __airDescription__b__ = true;
                        break;
                    case 15:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 16:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 17:
                        __windDesc__ = reader.ReadString();
                        __windDesc__b__ = true;
                        break;
                    case 18:
                        __windDescShort__ = reader.ReadString();
                        __windDescShort__b__ = true;
                        break;
                    case 19:
                        __beaufortScale__ = reader.ReadString();
                        __beaufortScale__b__ = true;
                        break;
                    case 20:
                        __beaufortDescription__ = reader.ReadString();
                        __beaufortDescription__b__ = true;
                        break;
                    case 21:
                        __uvIndex__ = reader.ReadString();
                        __uvIndex__b__ = true;
                        break;
                    case 22:
                        __uvDesc__ = reader.ReadString();
                        __uvDesc__b__ = true;
                        break;
                    case 23:
                        __visibility__ = reader.ReadString();
                        __visibility__b__ = true;
                        break;
                    case 24:
                        __barometerPressure__ = reader.ReadString();
                        __barometerPressure__b__ = true;
                        break;
                    case 25:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 26:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 27:
                        __iconLink__ = reader.ReadString();
                        __iconLink__b__ = true;
                        break;
                    case 28:
                        __dayOfWeek__ = reader.ReadString();
                        __dayOfWeek__b__ = true;
                        break;
                    case 29:
                        __weekday__ = reader.ReadString();
                        __weekday__b__ = true;
                        break;
                    case 30:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    case 31:
                        __localTime__ = reader.ReadString();
                        __localTime__b__ = true;
                        break;
                    case 32:
                        __localTimeFormat__ = reader.ReadString();
                        __localTimeFormat__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecast1();
            if(__daylight__b__) ____result.daylight = __daylight__;
            if(__description__b__) ____result.description = __description__;
            if(__skyInfo__b__) ____result.skyInfo = __skyInfo__;
            if(__skyDescription__b__) ____result.skyDescription = __skyDescription__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureDesc__b__) ____result.temperatureDesc = __temperatureDesc__;
            if(__comfort__b__) ____result.comfort = __comfort__;
            if(__humidity__b__) ____result.humidity = __humidity__;
            if(__dewPoint__b__) ____result.dewPoint = __dewPoint__;
            if(__precipitationProbability__b__) ____result.precipitationProbability = __precipitationProbability__;
            if(__precipitationDesc__b__) ____result.precipitationDesc = __precipitationDesc__;
            if(__rainFall__b__) ____result.rainFall = __rainFall__;
            if(__snowFall__b__) ____result.snowFall = __snowFall__;
            if(__airInfo__b__) ____result.airInfo = __airInfo__;
            if(__airDescription__b__) ____result.airDescription = __airDescription__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windDesc__b__) ____result.windDesc = __windDesc__;
            if(__windDescShort__b__) ____result.windDescShort = __windDescShort__;
            if(__beaufortScale__b__) ____result.beaufortScale = __beaufortScale__;
            if(__beaufortDescription__b__) ____result.beaufortDescription = __beaufortDescription__;
            if(__uvIndex__b__) ____result.uvIndex = __uvIndex__;
            if(__uvDesc__b__) ____result.uvDesc = __uvDesc__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__barometerPressure__b__) ____result.barometerPressure = __barometerPressure__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__iconLink__b__) ____result.iconLink = __iconLink__;
            if(__dayOfWeek__b__) ____result.dayOfWeek = __dayOfWeek__;
            if(__weekday__b__) ____result.weekday = __weekday__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;
            if(__localTime__b__) ____result.localTime = __localTime__;
            if(__localTimeFormat__b__) ____result.localTimeFormat = __localTimeFormat__;

            return ____result;
        }
    }


    public sealed class Forecastlocation1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Forecastlocation1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Forecastlocation1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("distance"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("distance"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Forecastlocation1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast1[]>().Serialize(ref writer, value.forecast, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.distance);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Forecastlocation1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecast__ = default(global::SimpleWeather.HERE.Forecast1[]);
            var __forecast__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __distance__ = default(float);
            var __distance__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __forecast__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecast1[]>().Deserialize(ref reader, formatterResolver);
                        __forecast__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __distance__ = reader.ReadSingle();
                        __distance__b__ = true;
                        break;
                    case 7:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Forecastlocation1();
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__distance__b__) ____result.distance = __distance__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class HourlyforecastsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Hourlyforecasts>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public HourlyforecastsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastLocation"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecastLocation"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Hourlyforecasts value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation1>().Serialize(ref writer, value.forecastLocation, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Hourlyforecasts Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecastLocation__ = default(global::SimpleWeather.HERE.Forecastlocation1);
            var __forecastLocation__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __forecastLocation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Forecastlocation1>().Deserialize(ref reader, formatterResolver);
                        __forecastLocation__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Hourlyforecasts();
            if(__forecastLocation__b__) ____result.forecastLocation = __forecastLocation__;

            return ____result;
        }
    }


    public sealed class Astronomy1Formatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Astronomy1>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Astronomy1Formatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonrise"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonset"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonPhase"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("moonPhaseDesc"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("iconName"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("utcTime"), 10},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonPhase"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("moonPhaseDesc"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("iconName"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("utcTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Astronomy1 value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.sunset);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.moonrise);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.moonset);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.moonPhase);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.moonPhaseDesc);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.iconName);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.utcTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Astronomy1 Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sunrise__ = default(string);
            var __sunrise__b__ = false;
            var __sunset__ = default(string);
            var __sunset__b__ = false;
            var __moonrise__ = default(string);
            var __moonrise__b__ = false;
            var __moonset__ = default(string);
            var __moonset__b__ = false;
            var __moonPhase__ = default(float);
            var __moonPhase__b__ = false;
            var __moonPhaseDesc__ = default(string);
            var __moonPhaseDesc__b__ = false;
            var __iconName__ = default(string);
            var __iconName__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __utcTime__ = default(global::System.DateTimeOffset);
            var __utcTime__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __sunrise__ = reader.ReadString();
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = reader.ReadString();
                        __sunset__b__ = true;
                        break;
                    case 2:
                        __moonrise__ = reader.ReadString();
                        __moonrise__b__ = true;
                        break;
                    case 3:
                        __moonset__ = reader.ReadString();
                        __moonset__b__ = true;
                        break;
                    case 4:
                        __moonPhase__ = reader.ReadSingle();
                        __moonPhase__b__ = true;
                        break;
                    case 5:
                        __moonPhaseDesc__ = reader.ReadString();
                        __moonPhaseDesc__b__ = true;
                        break;
                    case 6:
                        __iconName__ = reader.ReadString();
                        __iconName__b__ = true;
                        break;
                    case 7:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 8:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 9:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 10:
                        __utcTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __utcTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Astronomy1();
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;
            if(__moonrise__b__) ____result.moonrise = __moonrise__;
            if(__moonset__b__) ____result.moonset = __moonset__;
            if(__moonPhase__b__) ____result.moonPhase = __moonPhase__;
            if(__moonPhaseDesc__b__) ____result.moonPhaseDesc = __moonPhaseDesc__;
            if(__iconName__b__) ____result.iconName = __iconName__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__utcTime__b__) ____result.utcTime = __utcTime__;

            return ____result;
        }
    }


    public sealed class AstronomyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Astronomy>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AstronomyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("state"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("latitude"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("longitude"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("state"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("latitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("longitude"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Astronomy value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy1[]>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.state);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.latitude);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.longitude);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteInt32(value.timezone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Astronomy Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __astronomy__ = default(global::SimpleWeather.HERE.Astronomy1[]);
            var __astronomy__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __state__ = default(string);
            var __state__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __latitude__ = default(float);
            var __latitude__b__ = false;
            var __longitude__ = default(float);
            var __longitude__b__ = false;
            var __timezone__ = default(int);
            var __timezone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy1[]>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 1:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 2:
                        __state__ = reader.ReadString();
                        __state__b__ = true;
                        break;
                    case 3:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 4:
                        __latitude__ = reader.ReadSingle();
                        __latitude__b__ = true;
                        break;
                    case 5:
                        __longitude__ = reader.ReadSingle();
                        __longitude__b__ = true;
                        break;
                    case 6:
                        __timezone__ = reader.ReadInt32();
                        __timezone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Astronomy();
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__country__b__) ____result.country = __country__;
            if(__state__b__) ____result.state = __state__;
            if(__city__b__) ____result.city = __city__;
            if(__latitude__b__) ____result.latitude = __latitude__;
            if(__longitude__b__) ____result.longitude = __longitude__;
            if(__timezone__b__) ____result.timezone = __timezone__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.HERE.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observations"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dailyForecasts"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("hourlyForecasts"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("alerts"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("feedCreation"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("metric"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Type"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("Message"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("observations"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dailyForecasts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("hourlyForecasts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("alerts"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("feedCreation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("metric"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("Message"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.HERE.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observations>().Serialize(ref writer, value.observations, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Dailyforecasts>().Serialize(ref writer, value.dailyForecasts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Hourlyforecasts>().Serialize(ref writer, value.hourlyForecasts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alerts>().Serialize(ref writer, value.alerts, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.feedCreation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteBoolean(value.metric);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.Type);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.Message, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.HERE.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __observations__ = default(global::SimpleWeather.HERE.Observations);
            var __observations__b__ = false;
            var __dailyForecasts__ = default(global::SimpleWeather.HERE.Dailyforecasts);
            var __dailyForecasts__b__ = false;
            var __hourlyForecasts__ = default(global::SimpleWeather.HERE.Hourlyforecasts);
            var __hourlyForecasts__b__ = false;
            var __alerts__ = default(global::SimpleWeather.HERE.Alerts);
            var __alerts__b__ = false;
            var __astronomy__ = default(global::SimpleWeather.HERE.Astronomy);
            var __astronomy__b__ = false;
            var __feedCreation__ = default(global::System.DateTimeOffset);
            var __feedCreation__b__ = false;
            var __metric__ = default(bool);
            var __metric__b__ = false;
            var __Type__ = default(string);
            var __Type__b__ = false;
            var __Message__ = default(string[]);
            var __Message__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __observations__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Observations>().Deserialize(ref reader, formatterResolver);
                        __observations__b__ = true;
                        break;
                    case 1:
                        __dailyForecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Dailyforecasts>().Deserialize(ref reader, formatterResolver);
                        __dailyForecasts__b__ = true;
                        break;
                    case 2:
                        __hourlyForecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Hourlyforecasts>().Deserialize(ref reader, formatterResolver);
                        __hourlyForecasts__b__ = true;
                        break;
                    case 3:
                        __alerts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Alerts>().Deserialize(ref reader, formatterResolver);
                        __alerts__b__ = true;
                        break;
                    case 4:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.HERE.Astronomy>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 5:
                        __feedCreation__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __feedCreation__b__ = true;
                        break;
                    case 6:
                        __metric__ = reader.ReadBoolean();
                        __metric__b__ = true;
                        break;
                    case 7:
                        __Type__ = reader.ReadString();
                        __Type__b__ = true;
                        break;
                    case 8:
                        __Message__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __Message__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.HERE.Rootobject();
            if(__observations__b__) ____result.observations = __observations__;
            if(__dailyForecasts__b__) ____result.dailyForecasts = __dailyForecasts__;
            if(__hourlyForecasts__b__) ____result.hourlyForecasts = __hourlyForecasts__;
            if(__alerts__b__) ____result.alerts = __alerts__;
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__feedCreation__b__) ____result.feedCreation = __feedCreation__;
            if(__metric__b__) ____result.metric = __metric__;
            if(__Type__b__) ____result.Type = __Type__;
            if(__Message__b__) ____result.Message = __Message__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.NWS
{
    using System;
    using Utf8Json;


    public sealed class AlertGraphFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.AlertGraph>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertGraphFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sent"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("effective"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("onset"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expires"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("severity"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("event"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("instruction"), 7},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sent"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("effective"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("onset"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expires"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("severity"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("event"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("instruction"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.AlertGraph value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.sent, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.effective, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.onset, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.expires, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.severity);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value._event);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.instruction);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.AlertGraph Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sent__ = default(global::System.DateTimeOffset);
            var __sent__b__ = false;
            var __effective__ = default(global::System.DateTimeOffset);
            var __effective__b__ = false;
            var __onset__ = default(global::System.DateTimeOffset);
            var __onset__b__ = false;
            var __expires__ = default(global::System.DateTimeOffset);
            var __expires__b__ = false;
            var __severity__ = default(string);
            var __severity__b__ = false;
            var ___event__ = default(string);
            var ___event__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __instruction__ = default(string);
            var __instruction__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __sent__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __sent__b__ = true;
                        break;
                    case 1:
                        __effective__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __effective__b__ = true;
                        break;
                    case 2:
                        __onset__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __onset__b__ = true;
                        break;
                    case 3:
                        __expires__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __expires__b__ = true;
                        break;
                    case 4:
                        __severity__ = reader.ReadString();
                        __severity__b__ = true;
                        break;
                    case 5:
                        ___event__ = reader.ReadString();
                        ___event__b__ = true;
                        break;
                    case 6:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 7:
                        __instruction__ = reader.ReadString();
                        __instruction__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.AlertGraph();
            if(__sent__b__) ____result.sent = __sent__;
            if(__effective__b__) ____result.effective = __effective__;
            if(__onset__b__) ____result.onset = __onset__;
            if(__expires__b__) ____result.expires = __expires__;
            if(__severity__b__) ____result.severity = __severity__;
            if(___event__b__) ____result._event = ___event__;
            if(__description__b__) ____result.description = __description__;
            if(__instruction__b__) ____result.instruction = __instruction__;

            return ____result;
        }
    }


    public sealed class AlertRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.AlertRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AlertRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("@graph"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("title"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("@graph"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("title"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.AlertRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.AlertGraph[]>().Serialize(ref writer, value.graph, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.title);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.AlertRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __graph__ = default(global::SimpleWeather.NWS.AlertGraph[]);
            var __graph__b__ = false;
            var __title__ = default(string);
            var __title__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __graph__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.AlertGraph[]>().Deserialize(ref reader, formatterResolver);
                        __graph__b__ = true;
                        break;
                    case 1:
                        __title__ = reader.ReadString();
                        __title__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.AlertRootobject();
            if(__graph__b__) ____result.graph = __graph__;
            if(__title__b__) ____result.title = __title__;

            return ____result;
        }
    }


    public sealed class PointsRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.PointsRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PointsRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecast"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastHourly"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecastGridData"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observationStations"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timeZone"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("forecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastHourly"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecastGridData"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("observationStations"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timeZone"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.PointsRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.forecast);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.forecastHourly);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.forecastGridData);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.observationStations);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.timeZone);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.PointsRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __forecast__ = default(string);
            var __forecast__b__ = false;
            var __forecastHourly__ = default(string);
            var __forecastHourly__b__ = false;
            var __forecastGridData__ = default(string);
            var __forecastGridData__b__ = false;
            var __observationStations__ = default(string);
            var __observationStations__b__ = false;
            var __timeZone__ = default(string);
            var __timeZone__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __forecast__ = reader.ReadString();
                        __forecast__b__ = true;
                        break;
                    case 1:
                        __forecastHourly__ = reader.ReadString();
                        __forecastHourly__b__ = true;
                        break;
                    case 2:
                        __forecastGridData__ = reader.ReadString();
                        __forecastGridData__b__ = true;
                        break;
                    case 3:
                        __observationStations__ = reader.ReadString();
                        __observationStations__b__ = true;
                        break;
                    case 4:
                        __timeZone__ = reader.ReadString();
                        __timeZone__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.PointsRootobject();
            if(__forecast__b__) ____result.forecast = __forecast__;
            if(__forecastHourly__b__) ____result.forecastHourly = __forecastHourly__;
            if(__forecastGridData__b__) ____result.forecastGridData = __forecastGridData__;
            if(__observationStations__b__) ____result.observationStations = __observationStations__;
            if(__timeZone__b__) ____result.timeZone = __timeZone__;

            return ____result;
        }
    }


    public sealed class PeriodFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Period>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public PeriodFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("number"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("startTime"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("endTime"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("isDaytime"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureUnit"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperatureTrend"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("shortForecast"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("detailedForecast"), 12},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("number"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("startTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("endTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("isDaytime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureUnit"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperatureTrend"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("shortForecast"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("detailedForecast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Period value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.number);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.startTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.endTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteBoolean(value.isDaytime);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt32(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.temperatureUnit);
            writer.WriteRaw(this.____stringByteKeys[7]);
            writer.WriteString(value.temperatureTrend);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.windSpeed);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteString(value.windDirection);
            writer.WriteRaw(this.____stringByteKeys[10]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteString(value.shortForecast);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.detailedForecast);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Period Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __number__ = default(int);
            var __number__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __startTime__ = default(global::System.DateTimeOffset);
            var __startTime__b__ = false;
            var __endTime__ = default(global::System.DateTimeOffset);
            var __endTime__b__ = false;
            var __isDaytime__ = default(bool);
            var __isDaytime__b__ = false;
            var __temperature__ = default(int);
            var __temperature__b__ = false;
            var __temperatureUnit__ = default(string);
            var __temperatureUnit__b__ = false;
            var __temperatureTrend__ = default(string);
            var __temperatureTrend__b__ = false;
            var __windSpeed__ = default(string);
            var __windSpeed__b__ = false;
            var __windDirection__ = default(string);
            var __windDirection__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __shortForecast__ = default(string);
            var __shortForecast__b__ = false;
            var __detailedForecast__ = default(string);
            var __detailedForecast__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __number__ = reader.ReadInt32();
                        __number__b__ = true;
                        break;
                    case 1:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 2:
                        __startTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __startTime__b__ = true;
                        break;
                    case 3:
                        __endTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __endTime__b__ = true;
                        break;
                    case 4:
                        __isDaytime__ = reader.ReadBoolean();
                        __isDaytime__b__ = true;
                        break;
                    case 5:
                        __temperature__ = reader.ReadInt32();
                        __temperature__b__ = true;
                        break;
                    case 6:
                        __temperatureUnit__ = reader.ReadString();
                        __temperatureUnit__b__ = true;
                        break;
                    case 7:
                        __temperatureTrend__ = reader.ReadString();
                        __temperatureTrend__b__ = true;
                        break;
                    case 8:
                        __windSpeed__ = reader.ReadString();
                        __windSpeed__b__ = true;
                        break;
                    case 9:
                        __windDirection__ = reader.ReadString();
                        __windDirection__b__ = true;
                        break;
                    case 10:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 11:
                        __shortForecast__ = reader.ReadString();
                        __shortForecast__b__ = true;
                        break;
                    case 12:
                        __detailedForecast__ = reader.ReadString();
                        __detailedForecast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Period();
            if(__number__b__) ____result.number = __number__;
            if(__name__b__) ____result.name = __name__;
            if(__startTime__b__) ____result.startTime = __startTime__;
            if(__endTime__b__) ____result.endTime = __endTime__;
            if(__isDaytime__b__) ____result.isDaytime = __isDaytime__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__temperatureUnit__b__) ____result.temperatureUnit = __temperatureUnit__;
            if(__temperatureTrend__b__) ____result.temperatureTrend = __temperatureTrend__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__shortForecast__b__) ____result.shortForecast = __shortForecast__;
            if(__detailedForecast__b__) ____result.detailedForecast = __detailedForecast__;

            return ____result;
        }
    }


    public sealed class ForecastRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ForecastRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("updated"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("units"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("generatedAt"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("updateTime"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("validTimes"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("periods"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("updated"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("units"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("generatedAt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("updateTime"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("validTimes"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("periods"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ForecastRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.updated, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.units);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.generatedAt, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.updateTime, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteString(value.validTimes);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Period[]>().Serialize(ref writer, value.periods, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ForecastRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __updated__ = default(global::System.DateTimeOffset);
            var __updated__b__ = false;
            var __units__ = default(string);
            var __units__b__ = false;
            var __generatedAt__ = default(global::System.DateTimeOffset);
            var __generatedAt__b__ = false;
            var __updateTime__ = default(global::System.DateTimeOffset);
            var __updateTime__b__ = false;
            var __validTimes__ = default(string);
            var __validTimes__b__ = false;
            var __periods__ = default(global::SimpleWeather.NWS.Period[]);
            var __periods__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __updated__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __updated__b__ = true;
                        break;
                    case 1:
                        __units__ = reader.ReadString();
                        __units__b__ = true;
                        break;
                    case 2:
                        __generatedAt__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __generatedAt__b__ = true;
                        break;
                    case 3:
                        __updateTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __updateTime__b__ = true;
                        break;
                    case 4:
                        __validTimes__ = reader.ReadString();
                        __validTimes__b__ = true;
                        break;
                    case 5:
                        __periods__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Period[]>().Deserialize(ref reader, formatterResolver);
                        __periods__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ForecastRootobject();
            if(__updated__b__) ____result.updated = __updated__;
            if(__units__b__) ____result.units = __units__;
            if(__generatedAt__b__) ____result.generatedAt = __generatedAt__;
            if(__updateTime__b__) ____result.updateTime = __updateTime__;
            if(__validTimes__b__) ____result.validTimes = __validTimes__;
            if(__periods__b__) ____result.periods = __periods__;

            return ____result;
        }
    }


    public sealed class ObservationsStationsRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ObservationsStationsRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsStationsRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("observationStations"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("observationStations"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ObservationsStationsRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<string[]>().Serialize(ref writer, value.observationStations, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ObservationsStationsRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __observationStations__ = default(string[]);
            var __observationStations__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __observationStations__ = formatterResolver.GetFormatterWithVerify<string[]>().Deserialize(ref reader, formatterResolver);
                        __observationStations__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ObservationsStationsRootobject();
            if(__observationStations__b__) ____result.observationStations = __observationStations__;

            return ____result;
        }
    }


    public sealed class TemperatureFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Temperature>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public TemperatureFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Temperature value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Temperature Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Temperature();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class DewpointFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Dewpoint>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public DewpointFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Dewpoint value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Dewpoint Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Dewpoint();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WinddirectionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Winddirection>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WinddirectionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Winddirection value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Winddirection Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Winddirection();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class WindspeedFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Windspeed>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindspeedFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Windspeed value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Windspeed Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Windspeed();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class BarometricpressureFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Barometricpressure>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public BarometricpressureFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Barometricpressure value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Barometricpressure Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Barometricpressure();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class VisibilityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Visibility>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public VisibilityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Visibility value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Visibility Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Visibility();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class RelativehumidityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.Relativehumidity>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RelativehumidityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("value"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("unitCode"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("qualityControl"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("value"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("unitCode"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("qualityControl"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.Relativehumidity value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<float?>().Serialize(ref writer, value.value, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.unitCode);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.qualityControl);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.Relativehumidity Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __value__ = default(float?);
            var __value__b__ = false;
            var __unitCode__ = default(string);
            var __unitCode__b__ = false;
            var __qualityControl__ = default(string);
            var __qualityControl__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __value__ = formatterResolver.GetFormatterWithVerify<float?>().Deserialize(ref reader, formatterResolver);
                        __value__b__ = true;
                        break;
                    case 1:
                        __unitCode__ = reader.ReadString();
                        __unitCode__b__ = true;
                        break;
                    case 2:
                        __qualityControl__ = reader.ReadString();
                        __qualityControl__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.Relativehumidity();
            if(__value__b__) ____result.value = __value__;
            if(__unitCode__b__) ____result.unitCode = __unitCode__;
            if(__qualityControl__b__) ____result.qualityControl = __qualityControl__;

            return ____result;
        }
    }


    public sealed class ObservationsCurrentRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.NWS.ObservationsCurrentRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ObservationsCurrentRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timestamp"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("textDescription"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dewpoint"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windDirection"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("windSpeed"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("barometricPressure"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("relativeHumidity"), 9},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("timestamp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("textDescription"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dewpoint"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windDirection"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("windSpeed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("barometricPressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("relativeHumidity"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.NWS.ObservationsCurrentRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.timestamp, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.textDescription);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.icon);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Temperature>().Serialize(ref writer, value.temperature, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Dewpoint>().Serialize(ref writer, value.dewpoint, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Winddirection>().Serialize(ref writer, value.windDirection, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windspeed>().Serialize(ref writer, value.windSpeed, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Barometricpressure>().Serialize(ref writer, value.barometricPressure, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Visibility>().Serialize(ref writer, value.visibility, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativehumidity>().Serialize(ref writer, value.relativeHumidity, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.NWS.ObservationsCurrentRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __timestamp__ = default(global::System.DateTimeOffset);
            var __timestamp__b__ = false;
            var __textDescription__ = default(string);
            var __textDescription__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;
            var __temperature__ = default(global::SimpleWeather.NWS.Temperature);
            var __temperature__b__ = false;
            var __dewpoint__ = default(global::SimpleWeather.NWS.Dewpoint);
            var __dewpoint__b__ = false;
            var __windDirection__ = default(global::SimpleWeather.NWS.Winddirection);
            var __windDirection__b__ = false;
            var __windSpeed__ = default(global::SimpleWeather.NWS.Windspeed);
            var __windSpeed__b__ = false;
            var __barometricPressure__ = default(global::SimpleWeather.NWS.Barometricpressure);
            var __barometricPressure__b__ = false;
            var __visibility__ = default(global::SimpleWeather.NWS.Visibility);
            var __visibility__b__ = false;
            var __relativeHumidity__ = default(global::SimpleWeather.NWS.Relativehumidity);
            var __relativeHumidity__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __timestamp__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __timestamp__b__ = true;
                        break;
                    case 1:
                        __textDescription__ = reader.ReadString();
                        __textDescription__b__ = true;
                        break;
                    case 2:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    case 3:
                        __temperature__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Temperature>().Deserialize(ref reader, formatterResolver);
                        __temperature__b__ = true;
                        break;
                    case 4:
                        __dewpoint__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Dewpoint>().Deserialize(ref reader, formatterResolver);
                        __dewpoint__b__ = true;
                        break;
                    case 5:
                        __windDirection__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Winddirection>().Deserialize(ref reader, formatterResolver);
                        __windDirection__b__ = true;
                        break;
                    case 6:
                        __windSpeed__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Windspeed>().Deserialize(ref reader, formatterResolver);
                        __windSpeed__b__ = true;
                        break;
                    case 7:
                        __barometricPressure__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Barometricpressure>().Deserialize(ref reader, formatterResolver);
                        __barometricPressure__b__ = true;
                        break;
                    case 8:
                        __visibility__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Visibility>().Deserialize(ref reader, formatterResolver);
                        __visibility__b__ = true;
                        break;
                    case 9:
                        __relativeHumidity__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.NWS.Relativehumidity>().Deserialize(ref reader, formatterResolver);
                        __relativeHumidity__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.NWS.ObservationsCurrentRootobject();
            if(__timestamp__b__) ____result.timestamp = __timestamp__;
            if(__textDescription__b__) ____result.textDescription = __textDescription__;
            if(__icon__b__) ____result.icon = __icon__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__dewpoint__b__) ____result.dewpoint = __dewpoint__;
            if(__windDirection__b__) ____result.windDirection = __windDirection__;
            if(__windSpeed__b__) ____result.windSpeed = __windSpeed__;
            if(__barometricPressure__b__) ____result.barometricPressure = __barometricPressure__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__relativeHumidity__b__) ____result.relativeHumidity = __relativeHumidity__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.OpenWeather
{
    using System;
    using Utf8Json;


    public sealed class CoordFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Coord>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CoordFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lon"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("lon"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Coord value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.lon);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.lat);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Coord Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __lon__ = default(float);
            var __lon__b__ = false;
            var __lat__ = default(float);
            var __lat__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __lon__ = reader.ReadSingle();
                        __lon__b__ = true;
                        break;
                    case 1:
                        __lat__ = reader.ReadSingle();
                        __lat__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Coord();
            if(__lon__b__) ____result.lon = __lon__;
            if(__lat__b__) ____result.lat = __lat__;

            return ____result;
        }
    }


    public sealed class WeatherFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Weather>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WeatherFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("description"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("icon"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("description"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("icon"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Weather value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.main);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.description);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.icon);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Weather Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(int);
            var __id__b__ = false;
            var __main__ = default(string);
            var __main__b__ = false;
            var __description__ = default(string);
            var __description__b__ = false;
            var __icon__ = default(string);
            var __icon__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 1:
                        __main__ = reader.ReadString();
                        __main__b__ = true;
                        break;
                    case 2:
                        __description__ = reader.ReadString();
                        __description__b__ = true;
                        break;
                    case 3:
                        __icon__ = reader.ReadString();
                        __icon__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Weather();
            if(__id__b__) ____result.id = __id__;
            if(__main__b__) ____result.main = __main__;
            if(__description__b__) ____result.description = __description__;
            if(__icon__b__) ____result.icon = __icon__;

            return ____result;
        }
    }


    public sealed class MainFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Main>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public MainFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_min"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_max"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sea_level"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("grnd_level"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temp_kf"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("temp"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_min"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_max"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sea_level"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("grnd_level"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temp_kf"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Main value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.temp);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.temp_min);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.temp_max);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteSingle(value.pressure);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteSingle(value.sea_level);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteSingle(value.grnd_level);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteSingle(value.temp_kf);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Main Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __temp__ = default(float);
            var __temp__b__ = false;
            var __temp_min__ = default(float);
            var __temp_min__b__ = false;
            var __temp_max__ = default(float);
            var __temp_max__b__ = false;
            var __pressure__ = default(float);
            var __pressure__b__ = false;
            var __sea_level__ = default(float);
            var __sea_level__b__ = false;
            var __grnd_level__ = default(float);
            var __grnd_level__b__ = false;
            var __temp_kf__ = default(float);
            var __temp_kf__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __temp__ = reader.ReadSingle();
                        __temp__b__ = true;
                        break;
                    case 1:
                        __temp_min__ = reader.ReadSingle();
                        __temp_min__b__ = true;
                        break;
                    case 2:
                        __temp_max__ = reader.ReadSingle();
                        __temp_max__b__ = true;
                        break;
                    case 3:
                        __pressure__ = reader.ReadSingle();
                        __pressure__b__ = true;
                        break;
                    case 4:
                        __sea_level__ = reader.ReadSingle();
                        __sea_level__b__ = true;
                        break;
                    case 5:
                        __grnd_level__ = reader.ReadSingle();
                        __grnd_level__b__ = true;
                        break;
                    case 6:
                        __temp_kf__ = reader.ReadSingle();
                        __temp_kf__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Main();
            if(__temp__b__) ____result.temp = __temp__;
            if(__temp_min__b__) ____result.temp_min = __temp_min__;
            if(__temp_max__b__) ____result.temp_max = __temp_max__;
            if(__pressure__b__) ____result.pressure = __pressure__;
            if(__sea_level__b__) ____result.sea_level = __sea_level__;
            if(__grnd_level__b__) ____result.grnd_level = __grnd_level__;
            if(__temp_kf__b__) ____result.temp_kf = __temp_kf__;

            return ____result;
        }
    }


    public sealed class WindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Wind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("speed"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("deg"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("speed"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("deg"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Wind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.speed);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.deg);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Wind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __speed__ = default(float);
            var __speed__b__ = false;
            var __deg__ = default(float);
            var __deg__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __speed__ = reader.ReadSingle();
                        __speed__b__ = true;
                        break;
                    case 1:
                        __deg__ = reader.ReadSingle();
                        __deg__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Wind();
            if(__speed__b__) ____result.speed = __speed__;
            if(__deg__b__) ____result.deg = __deg__;

            return ____result;
        }
    }


    public sealed class CloudsFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Clouds>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CloudsFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("all"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("all"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Clouds value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.all);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Clouds Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __all__ = default(int);
            var __all__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __all__ = reader.ReadInt32();
                        __all__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Clouds();
            if(__all__b__) ____result.all = __all__;

            return ____result;
        }
    }


    public sealed class RainFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Rain>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RainFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_3h"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_3h"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Rain value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value._3h);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Rain Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___3h__ = default(float);
            var ___3h__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        ___3h__ = reader.ReadSingle();
                        ___3h__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Rain();
            if(___3h__b__) ____result._3h = ___3h__;

            return ____result;
        }
    }


    public sealed class SnowFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Snow>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SnowFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_3h"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("_3h"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Snow value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value._3h);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Snow Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var ___3h__ = default(float);
            var ___3h__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        ___3h__ = reader.ReadSingle();
                        ___3h__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Snow();
            if(___3h__b__) ____result._3h = ___3h__;

            return ____result;
        }
    }


    public sealed class SysFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Sys>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SysFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("type"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("type"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Sys value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.type);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.message);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt64(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteInt64(value.sunset);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Sys Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __type__ = default(int);
            var __type__b__ = false;
            var __id__ = default(int);
            var __id__b__ = false;
            var __message__ = default(float);
            var __message__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __sunrise__ = default(long);
            var __sunrise__b__ = false;
            var __sunset__ = default(long);
            var __sunset__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __type__ = reader.ReadInt32();
                        __type__b__ = true;
                        break;
                    case 1:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 2:
                        __message__ = reader.ReadSingle();
                        __message__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __sunrise__ = reader.ReadInt64();
                        __sunrise__b__ = true;
                        break;
                    case 5:
                        __sunset__ = reader.ReadInt64();
                        __sunset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Sys();
            if(__type__b__) ____result.type = __type__;
            if(__id__b__) ____result.id = __id__;
            if(__message__b__) ____result.message = __message__;
            if(__country__b__) ____result.country = __country__;
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;

            return ____result;
        }
    }


    public sealed class CurrentRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.CurrentRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CurrentRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("coord"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("_base"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("clouds"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rain"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow"), 8},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt"), 9},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sys"), 10},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 11},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 12},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 13},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("coord"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("_base"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("clouds"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sys"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cod"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.CurrentRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Serialize(ref writer, value.coord, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Serialize(ref writer, value.weather, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value._base);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Serialize(ref writer, value.main, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.visibility);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Serialize(ref writer, value.clouds, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Serialize(ref writer, value.rain, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Serialize(ref writer, value.snow, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[9]);
            writer.WriteInt64(value.dt);
            writer.WriteRaw(this.____stringByteKeys[10]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Sys>().Serialize(ref writer, value.sys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[11]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[12]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[13]);
            writer.WriteInt32(value.cod);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.CurrentRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __coord__ = default(global::SimpleWeather.OpenWeather.Coord);
            var __coord__b__ = false;
            var __weather__ = default(global::SimpleWeather.OpenWeather.Weather[]);
            var __weather__b__ = false;
            var ___base__ = default(string);
            var ___base__b__ = false;
            var __main__ = default(global::SimpleWeather.OpenWeather.Main);
            var __main__b__ = false;
            var __visibility__ = default(int);
            var __visibility__b__ = false;
            var __wind__ = default(global::SimpleWeather.OpenWeather.Wind);
            var __wind__b__ = false;
            var __clouds__ = default(global::SimpleWeather.OpenWeather.Clouds);
            var __clouds__b__ = false;
            var __rain__ = default(global::SimpleWeather.OpenWeather.Rain);
            var __rain__b__ = false;
            var __snow__ = default(global::SimpleWeather.OpenWeather.Snow);
            var __snow__b__ = false;
            var __dt__ = default(long);
            var __dt__b__ = false;
            var __sys__ = default(global::SimpleWeather.OpenWeather.Sys);
            var __sys__b__ = false;
            var __id__ = default(int);
            var __id__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __cod__ = default(int);
            var __cod__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __coord__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Deserialize(ref reader, formatterResolver);
                        __coord__b__ = true;
                        break;
                    case 1:
                        __weather__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Deserialize(ref reader, formatterResolver);
                        __weather__b__ = true;
                        break;
                    case 2:
                        ___base__ = reader.ReadString();
                        ___base__b__ = true;
                        break;
                    case 3:
                        __main__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Deserialize(ref reader, formatterResolver);
                        __main__b__ = true;
                        break;
                    case 4:
                        __visibility__ = reader.ReadInt32();
                        __visibility__b__ = true;
                        break;
                    case 5:
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 6:
                        __clouds__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Deserialize(ref reader, formatterResolver);
                        __clouds__b__ = true;
                        break;
                    case 7:
                        __rain__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Deserialize(ref reader, formatterResolver);
                        __rain__b__ = true;
                        break;
                    case 8:
                        __snow__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Deserialize(ref reader, formatterResolver);
                        __snow__b__ = true;
                        break;
                    case 9:
                        __dt__ = reader.ReadInt64();
                        __dt__b__ = true;
                        break;
                    case 10:
                        __sys__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Sys>().Deserialize(ref reader, formatterResolver);
                        __sys__b__ = true;
                        break;
                    case 11:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 12:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 13:
                        __cod__ = reader.ReadInt32();
                        __cod__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.CurrentRootobject();
            if(__coord__b__) ____result.coord = __coord__;
            if(__weather__b__) ____result.weather = __weather__;
            if(___base__b__) ____result._base = ___base__;
            if(__main__b__) ____result.main = __main__;
            if(__visibility__b__) ____result.visibility = __visibility__;
            if(__wind__b__) ____result.wind = __wind__;
            if(__clouds__b__) ____result.clouds = __clouds__;
            if(__rain__b__) ____result.rain = __rain__;
            if(__snow__b__) ____result.snow = __snow__;
            if(__dt__b__) ____result.dt = __dt__;
            if(__sys__b__) ____result.sys = __sys__;
            if(__id__b__) ____result.id = __id__;
            if(__name__b__) ____result.name = __name__;
            if(__cod__b__) ____result.cod = __cod__;

            return ____result;
        }
    }


    public sealed class ForecastSysFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.ForecastSys>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastSysFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pod"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("pod"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.ForecastSys value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.pod);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.ForecastSys Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __pod__ = default(string);
            var __pod__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __pod__ = reader.ReadString();
                        __pod__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.ForecastSys();
            if(__pod__b__) ____result.pod = __pod__;

            return ____result;
        }
    }


    public sealed class ListFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.List>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ListFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("main"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("weather"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("clouds"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rain"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("snow"), 6},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sys"), 7},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("dt_txt"), 8},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("dt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("main"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("weather"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("clouds"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rain"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("snow"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sys"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("dt_txt"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.List value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt64(value.dt);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Serialize(ref writer, value.main, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Serialize(ref writer, value.weather, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Serialize(ref writer, value.clouds, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[5]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Serialize(ref writer, value.rain, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[6]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Serialize(ref writer, value.snow, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[7]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.ForecastSys>().Serialize(ref writer, value.sys, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[8]);
            writer.WriteString(value.dt_txt);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.List Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __dt__ = default(long);
            var __dt__b__ = false;
            var __main__ = default(global::SimpleWeather.OpenWeather.Main);
            var __main__b__ = false;
            var __weather__ = default(global::SimpleWeather.OpenWeather.Weather[]);
            var __weather__b__ = false;
            var __clouds__ = default(global::SimpleWeather.OpenWeather.Clouds);
            var __clouds__b__ = false;
            var __wind__ = default(global::SimpleWeather.OpenWeather.Wind);
            var __wind__b__ = false;
            var __rain__ = default(global::SimpleWeather.OpenWeather.Rain);
            var __rain__b__ = false;
            var __snow__ = default(global::SimpleWeather.OpenWeather.Snow);
            var __snow__b__ = false;
            var __sys__ = default(global::SimpleWeather.OpenWeather.ForecastSys);
            var __sys__b__ = false;
            var __dt_txt__ = default(string);
            var __dt_txt__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __dt__ = reader.ReadInt64();
                        __dt__b__ = true;
                        break;
                    case 1:
                        __main__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Main>().Deserialize(ref reader, formatterResolver);
                        __main__b__ = true;
                        break;
                    case 2:
                        __weather__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Weather[]>().Deserialize(ref reader, formatterResolver);
                        __weather__b__ = true;
                        break;
                    case 3:
                        __clouds__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Clouds>().Deserialize(ref reader, formatterResolver);
                        __clouds__b__ = true;
                        break;
                    case 4:
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 5:
                        __rain__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Rain>().Deserialize(ref reader, formatterResolver);
                        __rain__b__ = true;
                        break;
                    case 6:
                        __snow__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Snow>().Deserialize(ref reader, formatterResolver);
                        __snow__b__ = true;
                        break;
                    case 7:
                        __sys__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.ForecastSys>().Deserialize(ref reader, formatterResolver);
                        __sys__b__ = true;
                        break;
                    case 8:
                        __dt_txt__ = reader.ReadString();
                        __dt_txt__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.List();
            if(__dt__b__) ____result.dt = __dt__;
            if(__main__b__) ____result.main = __main__;
            if(__weather__b__) ____result.weather = __weather__;
            if(__clouds__b__) ____result.clouds = __clouds__;
            if(__wind__b__) ____result.wind = __wind__;
            if(__rain__b__) ____result.rain = __rain__;
            if(__snow__b__) ____result.snow = __snow__;
            if(__sys__b__) ____result.sys = __sys__;
            if(__dt_txt__b__) ____result.dt_txt = __dt_txt__;

            return ____result;
        }
    }


    public sealed class CityFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.City>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public CityFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("id"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("name"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("coord"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("id"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("name"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("coord"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.City value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.id);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.name);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Serialize(ref writer, value.coord, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.City Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __id__ = default(int);
            var __id__b__ = false;
            var __name__ = default(string);
            var __name__b__ = false;
            var __coord__ = default(global::SimpleWeather.OpenWeather.Coord);
            var __coord__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __id__ = reader.ReadInt32();
                        __id__b__ = true;
                        break;
                    case 1:
                        __name__ = reader.ReadString();
                        __name__b__ = true;
                        break;
                    case 2:
                        __coord__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.Coord>().Deserialize(ref reader, formatterResolver);
                        __coord__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.City();
            if(__id__b__) ____result.id = __id__;
            if(__name__b__) ____result.name = __name__;
            if(__coord__b__) ____result.coord = __coord__;
            if(__country__b__) ____result.country = __country__;

            return ____result;
        }
    }


    public sealed class ForecastRootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.ForecastRootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastRootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cnt"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("list"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("cod"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("cnt"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("list"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.ForecastRootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.cod);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteSingle(value.message);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteInt32(value.cnt);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.List[]>().Serialize(ref writer, value.list, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.City>().Serialize(ref writer, value.city, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.ForecastRootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __cod__ = default(string);
            var __cod__b__ = false;
            var __message__ = default(float);
            var __message__b__ = false;
            var __cnt__ = default(int);
            var __cnt__b__ = false;
            var __list__ = default(global::SimpleWeather.OpenWeather.List[]);
            var __list__b__ = false;
            var __city__ = default(global::SimpleWeather.OpenWeather.City);
            var __city__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __cod__ = reader.ReadString();
                        __cod__b__ = true;
                        break;
                    case 1:
                        __message__ = reader.ReadSingle();
                        __message__b__ = true;
                        break;
                    case 2:
                        __cnt__ = reader.ReadInt32();
                        __cnt__b__ = true;
                        break;
                    case 3:
                        __list__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.List[]>().Deserialize(ref reader, formatterResolver);
                        __list__b__ = true;
                        break;
                    case 4:
                        __city__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.OpenWeather.City>().Deserialize(ref reader, formatterResolver);
                        __city__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.ForecastRootobject();
            if(__cod__b__) ____result.cod = __cod__;
            if(__message__b__) ____result.message = __message__;
            if(__cnt__b__) ____result.cnt = __cnt__;
            if(__list__b__) ____result.list = __list__;
            if(__city__b__) ____result.city = __city__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.OpenWeather.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("cod"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("message"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("cod"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("message"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.OpenWeather.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.cod);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.message);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.OpenWeather.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __cod__ = default(int);
            var __cod__b__ = false;
            var __message__ = default(string);
            var __message__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __cod__ = reader.ReadInt32();
                        __cod__b__ = true;
                        break;
                    case 1:
                        __message__ = reader.ReadString();
                        __message__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.OpenWeather.Rootobject();
            if(__cod__b__) ____result.cod = __cod__;
            if(__message__b__) ____result.message = __message__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.Utf8JsonGen.Formatters.SimpleWeather.WeatherYahoo
{
    using System;
    using Utf8Json;


    public sealed class LocationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Location>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public LocationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("woeid"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("city"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("region"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("country"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("lat"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("long"), 5},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("timezone_id"), 6},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("woeid"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("city"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("region"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("country"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("lat"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("long"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("timezone_id"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Location value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.woeid);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.city);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.region);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteString(value.country);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteDouble(value.lat);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteDouble(value._long);
            writer.WriteRaw(this.____stringByteKeys[6]);
            writer.WriteString(value.timezone_id);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Location Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __woeid__ = default(int);
            var __woeid__b__ = false;
            var __city__ = default(string);
            var __city__b__ = false;
            var __region__ = default(string);
            var __region__b__ = false;
            var __country__ = default(string);
            var __country__b__ = false;
            var __lat__ = default(double);
            var __lat__b__ = false;
            var ___long__ = default(double);
            var ___long__b__ = false;
            var __timezone_id__ = default(string);
            var __timezone_id__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __woeid__ = reader.ReadInt32();
                        __woeid__b__ = true;
                        break;
                    case 1:
                        __city__ = reader.ReadString();
                        __city__b__ = true;
                        break;
                    case 2:
                        __region__ = reader.ReadString();
                        __region__b__ = true;
                        break;
                    case 3:
                        __country__ = reader.ReadString();
                        __country__b__ = true;
                        break;
                    case 4:
                        __lat__ = reader.ReadDouble();
                        __lat__b__ = true;
                        break;
                    case 5:
                        ___long__ = reader.ReadDouble();
                        ___long__b__ = true;
                        break;
                    case 6:
                        __timezone_id__ = reader.ReadString();
                        __timezone_id__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Location();
            if(__woeid__b__) ____result.woeid = __woeid__;
            if(__city__b__) ____result.city = __city__;
            if(__region__b__) ____result.region = __region__;
            if(__country__b__) ____result.country = __country__;
            if(__lat__b__) ____result.lat = __lat__;
            if(___long__b__) ____result._long = ___long__;
            if(__timezone_id__b__) ____result.timezone_id = __timezone_id__;

            return ____result;
        }
    }


    public sealed class WindFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Wind>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WindFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("chill"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("direction"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("speed"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("chill"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("direction"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("speed"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Wind value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.chill);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.direction);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.speed);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Wind Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __chill__ = default(int);
            var __chill__b__ = false;
            var __direction__ = default(int);
            var __direction__b__ = false;
            var __speed__ = default(float);
            var __speed__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __chill__ = reader.ReadInt32();
                        __chill__b__ = true;
                        break;
                    case 1:
                        __direction__ = reader.ReadInt32();
                        __direction__b__ = true;
                        break;
                    case 2:
                        __speed__ = reader.ReadSingle();
                        __speed__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Wind();
            if(__chill__b__) ____result.chill = __chill__;
            if(__direction__b__) ____result.direction = __direction__;
            if(__speed__b__) ____result.speed = __speed__;

            return ____result;
        }
    }


    public sealed class AtmosphereFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Atmosphere>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AtmosphereFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pressure"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("rising"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("visibility"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("pressure"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("rising"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("visibility"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Atmosphere value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteSingle(value.pressure);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.rising);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteSingle(value.visibility);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Atmosphere Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __pressure__ = default(float);
            var __pressure__b__ = false;
            var __rising__ = default(int);
            var __rising__b__ = false;
            var __visibility__ = default(float);
            var __visibility__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __pressure__ = reader.ReadSingle();
                        __pressure__b__ = true;
                        break;
                    case 1:
                        __rising__ = reader.ReadInt32();
                        __rising__b__ = true;
                        break;
                    case 2:
                        __visibility__ = reader.ReadSingle();
                        __visibility__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Atmosphere();
            if(__pressure__b__) ____result.pressure = __pressure__;
            if(__rising__b__) ____result.rising = __rising__;
            if(__visibility__b__) ____result.visibility = __visibility__;

            return ____result;
        }
    }


    public sealed class AstronomyFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Astronomy>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public AstronomyFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunrise"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("sunset"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("sunrise"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("sunset"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Astronomy value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.sunrise);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.sunset);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Astronomy Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __sunrise__ = default(string);
            var __sunrise__b__ = false;
            var __sunset__ = default(string);
            var __sunset__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __sunrise__ = reader.ReadString();
                        __sunrise__b__ = true;
                        break;
                    case 1:
                        __sunset__ = reader.ReadString();
                        __sunset__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Astronomy();
            if(__sunrise__b__) ____result.sunrise = __sunrise__;
            if(__sunset__b__) ____result.sunset = __sunset__;

            return ____result;
        }
    }


    public sealed class ConditionFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Condition>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ConditionFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("code"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("temperature"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("text"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("code"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("temperature"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("text"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Condition value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.code);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.temperature);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.text);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Condition Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __code__ = default(int);
            var __code__b__ = false;
            var __temperature__ = default(int);
            var __temperature__b__ = false;
            var __text__ = default(string);
            var __text__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __code__ = reader.ReadInt32();
                        __code__b__ = true;
                        break;
                    case 1:
                        __temperature__ = reader.ReadInt32();
                        __temperature__b__ = true;
                        break;
                    case 2:
                        __text__ = reader.ReadString();
                        __text__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Condition();
            if(__code__b__) ____result.code = __code__;
            if(__temperature__b__) ____result.temperature = __temperature__;
            if(__text__b__) ____result.text = __text__;

            return ____result;
        }
    }


    public sealed class Current_ObservationFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Current_Observation>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public Current_ObservationFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("wind"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("atmosphere"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("astronomy"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("condition"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("pubDate"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("wind"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("atmosphere"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("astronomy"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("condition"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("pubDate"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Current_Observation value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Wind>().Serialize(ref writer, value.wind, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Atmosphere>().Serialize(ref writer, value.atmosphere, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Astronomy>().Serialize(ref writer, value.astronomy, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Condition>().Serialize(ref writer, value.condition, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt64(value.pubDate);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Current_Observation Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __wind__ = default(global::SimpleWeather.WeatherYahoo.Wind);
            var __wind__b__ = false;
            var __atmosphere__ = default(global::SimpleWeather.WeatherYahoo.Atmosphere);
            var __atmosphere__b__ = false;
            var __astronomy__ = default(global::SimpleWeather.WeatherYahoo.Astronomy);
            var __astronomy__b__ = false;
            var __condition__ = default(global::SimpleWeather.WeatherYahoo.Condition);
            var __condition__b__ = false;
            var __pubDate__ = default(long);
            var __pubDate__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __wind__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Wind>().Deserialize(ref reader, formatterResolver);
                        __wind__b__ = true;
                        break;
                    case 1:
                        __atmosphere__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Atmosphere>().Deserialize(ref reader, formatterResolver);
                        __atmosphere__b__ = true;
                        break;
                    case 2:
                        __astronomy__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Astronomy>().Deserialize(ref reader, formatterResolver);
                        __astronomy__b__ = true;
                        break;
                    case 3:
                        __condition__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Condition>().Deserialize(ref reader, formatterResolver);
                        __condition__b__ = true;
                        break;
                    case 4:
                        __pubDate__ = reader.ReadInt64();
                        __pubDate__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Current_Observation();
            if(__wind__b__) ____result.wind = __wind__;
            if(__atmosphere__b__) ____result.atmosphere = __atmosphere__;
            if(__astronomy__b__) ____result.astronomy = __astronomy__;
            if(__condition__b__) ____result.condition = __condition__;
            if(__pubDate__b__) ____result.pubDate = __pubDate__;

            return ____result;
        }
    }


    public sealed class ForecastFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Forecast>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public ForecastFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("code"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("date"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("day"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("high"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("low"), 4},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("text"), 5},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("code"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("date"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("day"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("high"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("low"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("text"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Forecast value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.code);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt64(value.date);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.day);
            writer.WriteRaw(this.____stringByteKeys[3]);
            writer.WriteInt32(value.high);
            writer.WriteRaw(this.____stringByteKeys[4]);
            writer.WriteInt32(value.low);
            writer.WriteRaw(this.____stringByteKeys[5]);
            writer.WriteString(value.text);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Forecast Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __code__ = default(int);
            var __code__b__ = false;
            var __date__ = default(long);
            var __date__b__ = false;
            var __day__ = default(string);
            var __day__b__ = false;
            var __high__ = default(int);
            var __high__b__ = false;
            var __low__ = default(int);
            var __low__b__ = false;
            var __text__ = default(string);
            var __text__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __code__ = reader.ReadInt32();
                        __code__b__ = true;
                        break;
                    case 1:
                        __date__ = reader.ReadInt64();
                        __date__b__ = true;
                        break;
                    case 2:
                        __day__ = reader.ReadString();
                        __day__b__ = true;
                        break;
                    case 3:
                        __high__ = reader.ReadInt32();
                        __high__b__ = true;
                        break;
                    case 4:
                        __low__ = reader.ReadInt32();
                        __low__b__ = true;
                        break;
                    case 5:
                        __text__ = reader.ReadString();
                        __text__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Forecast();
            if(__code__b__) ____result.code = __code__;
            if(__date__b__) ____result.date = __date__;
            if(__day__b__) ____result.day = __day__;
            if(__high__b__) ____result.high = __high__;
            if(__low__b__) ____result.low = __low__;
            if(__text__b__) ____result.text = __text__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.WeatherYahoo.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("location"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("current_observation"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("forecasts"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("location"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("current_observation"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("forecasts"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.WeatherYahoo.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Location>().Serialize(ref writer, value.location, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Current_Observation>().Serialize(ref writer, value.current_observation, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[2]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Forecast[]>().Serialize(ref writer, value.forecasts, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.WeatherYahoo.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __location__ = default(global::SimpleWeather.WeatherYahoo.Location);
            var __location__b__ = false;
            var __current_observation__ = default(global::SimpleWeather.WeatherYahoo.Current_Observation);
            var __current_observation__b__ = false;
            var __forecasts__ = default(global::SimpleWeather.WeatherYahoo.Forecast[]);
            var __forecasts__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __location__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Location>().Deserialize(ref reader, formatterResolver);
                        __location__b__ = true;
                        break;
                    case 1:
                        __current_observation__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Current_Observation>().Deserialize(ref reader, formatterResolver);
                        __current_observation__b__ = true;
                        break;
                    case 2:
                        __forecasts__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.WeatherYahoo.Forecast[]>().Deserialize(ref reader, formatterResolver);
                        __forecasts__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.WeatherYahoo.Rootobject();
            if(__location__b__) ____result.location = __location__;
            if(__current_observation__b__) ____result.current_observation = __current_observation__;
            if(__forecasts__b__) ____result.forecasts = __forecasts__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
