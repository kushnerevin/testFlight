using testFlight.Services.SettingsService.Interfaces;

namespace testFlight.Services.SettingsService.Implementations
{
    internal class PropertiesService : ISettingsService
    {
        public T GetValue<T>(string key)
        {
            return (T)Properties.Settings.Default[key];
        }
    }
}
