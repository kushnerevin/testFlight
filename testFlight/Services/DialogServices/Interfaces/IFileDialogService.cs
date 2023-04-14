
namespace testFlight.Services.DialogServices.Interfaces
{
    public interface IFileDialogService
    {
        string FileFullName { get; set; }

        bool OpenDialog();  

        bool SaveDialog();  
    }
}
