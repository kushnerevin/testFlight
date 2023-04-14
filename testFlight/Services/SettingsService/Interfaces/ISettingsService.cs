
namespace testFlight.Services.SettingsService.Interfaces
{
    public interface ISettingsService
    {
        T GetValue<T>(string key);        
    }
}
