using APITest.Models;
using APITest.WeatherRepository;

namespace APITest.WeatherOrchestrator {
    public interface IWeatherForecastOrchestrator {
        IEnumerable<WeatherForecast> GetForecast();
    }

    public class WeatherForecastOrchestrator : IWeatherForecastOrchestrator {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherForecastOrchestrator(IWeatherRepository weatherRepository) {
            _weatherRepository = weatherRepository;
        }

        public IEnumerable<WeatherForecast> GetForecast() {
            // Orchestration logic goes here
            var rawData = _weatherRepository.GenerateForecast();

            // You could add mapping, filtering, enrichment, logging, etc.
            return rawData;
        }
    }

}