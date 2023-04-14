
namespace testFlight.Services.SerializerService.Interfaces
{
    public interface ISerializerService
    {
        void Serialize<T>(T objectToSerialize, string fileName);

        T Deserialize<T>(string fileName) where T : class, new();
    }
}
