using System;

namespace SwaggerDemoApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Result
    {
        public string Sem1 { get; set; }
        public string Sem2 { get; set; }
    }
}
