﻿using SimpleWeather.Keys;
using SimpleWeather.Location;
using SimpleWeather.Utils;
using SimpleWeather.WeatherData;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Windows.System.UserProfile;
using Windows.Web;
using Windows.Web.Http;

namespace SimpleWeather.OpenWeather
{
    public partial class OpenWeatherMapProvider : WeatherProviderImpl
    {
        private const String BASE_URL = "https://api.openweathermap.org/data/2.5/";
        private const String KEYCHECK_QUERY_URL = BASE_URL + "forecast?appid=";
        private const String WEATHER_QUERY_URL = BASE_URL + "onecall?{0}&exclude=minutely&appid={1}&lang={2}";

        public OpenWeatherMapProvider() : base()
        {
            LocationProvider = new Bing.BingMapsLocationProvider();
        }

        public override string WeatherAPI => WeatherData.WeatherAPI.OpenWeatherMap;
        public override bool SupportsWeatherLocale => true;
        public override bool KeyRequired => true;
        public override bool SupportsAlerts => true;
        public override bool NeedsExternalAlertData => true;

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public override Task<bool> IsKeyValid(string key)
        {
            return Task.Run(async () =>
            {
                bool isValid = false;
                WeatherException wEx = null;

                try
                {
                    if (String.IsNullOrWhiteSpace(key))
                        throw (wEx = new WeatherException(WeatherUtils.ErrorStatus.InvalidAPIKey));

                    Uri queryURL = new Uri(String.Format("{0}{1}", KEYCHECK_QUERY_URL, key));

                    // Connect to webstream
                    var webClient = SimpleLibrary.WebClient;
                    using (var cts = new CancellationTokenSource(Settings.READ_TIMEOUT))
                    using (var response = await webClient.GetAsync(queryURL).AsTask(cts.Token))
                    {
                        // Check for errors
                        switch (response.StatusCode)
                        {
                            // 400 (OK since this isn't a valid request)
                            case HttpStatusCode.BadRequest:
                                isValid = true;
                                break;
                            // 401 (Unauthorized - Key is invalid)
                            case HttpStatusCode.Unauthorized:
                                wEx = new WeatherException(WeatherUtils.ErrorStatus.InvalidAPIKey);
                                isValid = false;
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    isValid = false;
                }

                if (wEx != null)
                {
                    throw wEx;
                }

                return isValid;
            });
        }

        public override string GetAPIKey()
        {
            return APIKeys.GetOWMKey();
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public override Task<WeatherData.Weather> GetWeather(string location_query, string country_code)
        {
            return Task.Run(async () =>
            {
                WeatherData.Weather weather = null;
                WeatherException wEx = null;

                var culture = CultureUtils.UserCulture;

                string locale = LocaleToLangCode(culture.TwoLetterISOLanguageName, culture.Name);

                string query;
                if (int.TryParse(location_query, out int id))
                {
                    query = string.Format("id={0}", id);
                }
                else
                {
                    query = location_query;
                }

                string key = Settings.UsePersonalKey ? Settings.API_KEY : GetAPIKey();

                try
                {
                    Uri weatherURL = new Uri(string.Format(WEATHER_QUERY_URL, query, key, locale));

                    // Get response
                    var webClient = SimpleLibrary.WebClient;
                    using (var cts = new CancellationTokenSource(Settings.READ_TIMEOUT))
                    using (var response = await webClient.GetAsync(weatherURL).AsTask(cts.Token))
                    {
                        response.EnsureSuccessStatusCode();

                        Stream contentStream = WindowsRuntimeStreamExtensions.AsStreamForRead(await response.Content.ReadAsInputStreamAsync());

                        // Load weather
                        Rootobject root = JSONParser.Deserializer<Rootobject>(contentStream);

                        weather = new WeatherData.Weather(root);
                    }
                }
                catch (Exception ex)
                {
                    weather = null;

                    if (WebError.GetStatus(ex.HResult) > WebErrorStatus.Unknown)
                    {
                        wEx = new WeatherException(WeatherUtils.ErrorStatus.NetworkError);
                    }

                    Logger.WriteLine(LoggerLevel.Error, ex, "OpenWeatherMapProvider: error getting weather data");
                }

                if (weather == null || !weather.IsValid())
                {
                    wEx = new WeatherException(WeatherUtils.ErrorStatus.NoWeather);
                }
                else if (weather != null)
                {
                    if (SupportsWeatherLocale)
                        weather.locale = locale;

                    weather.query = location_query;
                }

                if (wEx != null)
                    throw wEx;

                return weather;
            });
        }

        /// <exception cref="WeatherException">Thrown when task is unable to retrieve data</exception>
        public override async Task<WeatherData.Weather> GetWeather(LocationData location)
        {
            var weather = await base.GetWeather(location);

            // OWM reports datetime in UTC; add location tz_offset
            var offset = location.tz_offset;
            weather.update_time = weather.update_time.ToOffset(offset);
            foreach (HourlyForecast hr_forecast in weather.hr_forecast)
            {
                hr_forecast.date = hr_forecast.date.ToOffset(offset);
            }
            foreach (Forecast forecast in weather.forecast)
            {
                forecast.date = forecast.date.Add(offset);
            }
            weather.astronomy.sunrise = weather.astronomy.sunrise.Add(offset);
            weather.astronomy.sunset = weather.astronomy.sunset.Add(offset);

            return weather;
        }

        public override string UpdateLocationQuery(WeatherData.Weather weather)
        {
            return string.Format(CultureInfo.InvariantCulture, "lat={0:0.####}&lon={1:0.####}", weather.location.latitude, weather.location.longitude);
        }

        public override string UpdateLocationQuery(LocationData location)
        {
            return string.Format(CultureInfo.InvariantCulture, "lat={0:0.####}&lon={1:0.####}", location.latitude, location.longitude);
        }

        public override String LocaleToLangCode(String iso, String name)
        {
            string code = "en";

            switch (iso)
            {
                // Arabic
                case "ar":
                // Bulgarian
                case "bg":
                // Catalan
                case "ca":
                // Croatian
                case "hr":
                // Dutch
                case "nl":
                // Farsi / Persian
                case "fa":
                // Finnish
                case "fi":
                // French
                case "fr":
                // Galician
                case "gl":
                // German
                case "de":
                // Greek
                case "el":
                // Hungarian
                case "hu":
                // Italian
                case "it":
                // Japanese
                case "ja":
                // Lithuanian
                case "lt":
                // Macedonian
                case "mk":
                // Polish
                case "pl":
                // Portuguese
                case "pt":
                // Romanian
                case "ro":
                // Russian
                case "ru":
                // Slovak
                case "sk":
                // Slovenian
                case "sl":
                // Spanish
                case "es":
                // Turkish
                case "tr":
                // Vietnamese
                case "vi":
                    code = iso;
                    break;
                // Chinese
                case "zh":
                    switch (name)
                    {
                        // Chinese - Traditional
                        case "zh-Hant":
                        case "zh-HK":
                        case "zh-MO":
                        case "zh-TW":
                            code = "zh_tw";
                            break;
                        // Chinese - Simplified
                        default:
                            code = "zh_cn";
                            break;
                    }
                    break;
                // Czech
                case "cs":
                    code = "cz";
                    break;
                // Korean
                case "ko":
                    code = "kr";
                    break;
                // Latvian
                case "lv":
                    code = "la";
                    break;
                // Swedish
                case "sv":
                    code = "se";
                    break;
                // Ukrainian
                case "uk":
                    code = "ua";
                    break;

                default:
                    // Default is English
                    code = "en";
                    break;
            }

            return code;
        }

        public override string GetWeatherIcon(string icon)
        {
            bool isNight = false;

            if (icon.EndsWith("n"))
                isNight = true;

            return GetWeatherIcon(isNight, icon);
        }

        public override string GetWeatherIcon(bool isNight, string icon)
        {
            string WeatherIcon = string.Empty;

            switch (icon.Substring(0, 3))
            {
                case "200": // thunderstorm w/ light rain
                case "201": // thunderstorm w/ rain
                case "210": // light thunderstorm
                case "230": // thunderstorm w/ light drizzle
                case "231": // thunderstorm w/ drizzle
                    WeatherIcon = WeatherIcons.STORM_SHOWERS;
                    break;

                case "211": // thunderstorm
                case "212": // heavy thunderstorm
                case "221": // ragged thunderstorm
                case "202": // thunderstorm w/ heavy rain
                case "232": // thunderstorm w/ heavy drizzle
                    WeatherIcon = WeatherIcons.THUNDERSTORM;
                    break;

                case "300": // light intensity drizzle
                case "301": // drizzle
                case "321": // shower drizzle
                    WeatherIcon = WeatherIcons.SPRINKLE;
                    break;

                case "302": // heavy intensity drizzle
                case "311": // drizzle rain
                case "312": // heavy intensity drizzle rain
                case "314": // heavy shower rain and drizzle
                    WeatherIcon = WeatherIcons.RAIN;
                    break;

                case "500": // light rain
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_ALT_SPRINKLE;
                    else
                        WeatherIcon = WeatherIcons.DAY_SPRINKLE;
                    break;

                case "501": // moderate rain
                case "502": // heavy intensity rain
                case "503": // very heavy rain
                case "504": // extreme rain
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_ALT_RAIN;
                    else
                        WeatherIcon = WeatherIcons.DAY_RAIN;
                    break;

                case "310": // light intensity drizzle rain
                case "511": // freezing rain
                case "611": // sleet
                case "612": // shower sleet
                case "615": // light rain and snow
                case "616": // rain and snow
                case "620": // light shower snow
                    WeatherIcon = WeatherIcons.RAIN_MIX;
                    break;

                case "313": // shower rain and drizzle
                case "520": // light intensity shower rain
                case "521": // shower rain
                case "522": // heavy intensity shower rain
                case "701": // mist
                    WeatherIcon = WeatherIcons.SHOWERS;
                    break;

                case "531": // ragged shower rain
                case "901": // tropical storm
                    WeatherIcon = WeatherIcons.STORM_SHOWERS;
                    break;

                case "600": // light snow
                case "601": // snow
                case "621": // shower snow
                case "622": // heavy shower snow
                    WeatherIcon = WeatherIcons.SNOW;
                    break;

                case "602": // heavy snow
                    WeatherIcon = WeatherIcons.SNOW_WIND;
                    break;

                // smoke
                case "711":
                    WeatherIcon = WeatherIcons.SMOKE;
                    break;

                // haze
                case "721":
                    if (isNight)
                        WeatherIcon = WeatherIcons.WINDY;
                    else
                        WeatherIcon = WeatherIcons.DAY_HAZE;
                    break;

                // dust
                case "731":
                case "761":
                case "762":
                    WeatherIcon = WeatherIcons.DUST;
                    break;

                // fog
                case "741":
                    WeatherIcon = WeatherIcons.FOG;
                    break;

                // cloudy-gusts
                case "771": // squalls
                    WeatherIcon = WeatherIcons.CLOUDY_GUSTS;
                    break;

                // tornado
                case "781":
                case "900":
                    WeatherIcon = WeatherIcons.TORNADO;
                    break;

                // day-sunny
                case "800": // clear sky
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_CLEAR;
                    else
                        WeatherIcon = WeatherIcons.DAY_SUNNY;
                    break;

                // cloudy-gusts
                case "801": // few clouds
                case "802": // scattered clouds
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_ALT_CLOUDY_GUSTS;
                    else
                        WeatherIcon = WeatherIcons.DAY_CLOUDY_GUSTS;
                    break;

                // cloudy-gusts
                case "803": // broken clouds
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_ALT_CLOUDY_WINDY;
                    else
                        WeatherIcon = WeatherIcons.DAY_CLOUDY_WINDY;
                    break;

                // cloudy
                case "804": // overcast clouds
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_ALT_CLOUDY;
                    else
                        WeatherIcon = WeatherIcons.DAY_CLOUDY;
                    break;

                // hurricane
                case "902":
                    WeatherIcon = WeatherIcons.HURRICANE;
                    break;

                // cold
                case "903":
                    WeatherIcon = WeatherIcons.SNOWFLAKE_COLD;
                    break;

                // hot
                case "904":
                    if (isNight)
                        WeatherIcon = WeatherIcons.NIGHT_CLEAR;
                    else
                        WeatherIcon = WeatherIcons.DAY_HOT;
                    break;

                // windy
                case "905":
                    WeatherIcon = WeatherIcons.WINDY;
                    break;

                // hail
                case "906":
                    WeatherIcon = WeatherIcons.HAIL;
                    break;

                // strong wind
                case "957":
                    WeatherIcon = WeatherIcons.STRONG_WIND;
                    break;

                default:
                    break;
            }

            if (String.IsNullOrWhiteSpace(WeatherIcon))
            {
                // Not Available
                WeatherIcon = WeatherIcons.NA;
            }

            return WeatherIcon;
        }
    }
}