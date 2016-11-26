﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace SimpleWeather
{
    public class WeatherNowView
    {
        public string Location { get; set; }
        public string UpdateDate { get; set; }

        // Current Condition
        public string CurTemp { get; set; }
        public string CurCondition { get; set; }
        public string WeatherIcon { get; set; }

        // Weather Details
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string PressureUnit { get; set; }
        public string Visibility { get; set; }
        public string VisibilityUnit { get; set; }
        public string Chill { get; set; }
        public string Speed { get; set; }
        public string SpeedUnit { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        // Forecast
        public ObservableCollection<ForecastItemView> Forecasts { get; set; }

        // Background
        public ImageBrush Background { get; set; }

        public WeatherNowView()
        {
        }

        public WeatherNowView(Weather weather)
        {
            updateView(weather);
        }

        private void updateView(Weather weather)
        {
            // Update background
            Background = WeatherUtils.GetBackground(weather); 

            // Location
            Location = weather.location.description;

            // Date Updated
            UpdateDate = WeatherUtils.GetLastBuildDate(weather);

            // Update Current Condition
            CurTemp = weather.condition.temp +
                (weather.units.temperature == "F" ? "\uf045" : "\uf03c");
            CurCondition = weather.condition.text;
            WeatherIcon = WeatherUtils.GetWeatherIcon(weather.condition.code);

            // WeatherDetails
            // Astronomy
            Sunrise = weather.astronomy.sunrise;
            Sunset = weather.astronomy.sunset;
            // Wind
            Chill = (weather.units.temperature == "F" ? weather.wind.chill : ConversionMethods.FtoC(weather.wind.chill)) + "º";
            Speed = weather.wind.speed;
            SpeedUnit = weather.units.speed;

            // Atmosphere
            Humidity = weather.atmosphere.humidity;
            Pressure = (weather.units.temperature == "F" ?
                weather.atmosphere.pressure : Math.Round(double.Parse(weather.atmosphere.pressure)).ToString());
            PressureUnit = weather.units.pressure;
            Visibility = weather.atmosphere.visibility;
            VisibilityUnit = weather.units.distance;

            // Add UI elements
            Forecasts = new ObservableCollection<ForecastItemView>();
            foreach (Forecast forecast in weather.forecasts)
            {
                ForecastItemView forecastView = new ForecastItemView(forecast);
                Forecasts.Add(forecastView);
            }
        }
    }
}