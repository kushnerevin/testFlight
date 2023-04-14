using Microsoft.Win32;
using System.Windows;
using testFlight.Services.DialogServices.Interfaces;

namespace testFlight.Services.DialogServices.Implementations
{
    internal class FileDialogService : IFileDialogService
    {
        private const string Filter = "XML documents (.xml)|*.xml";
        private const string Extension = ".xml";


        public string FileFullName { get; set; }

        public bool OpenDialog()
        {
            bool dialogResult = false;
            OpenFileDialog openFileDialog = new()
            {
                DefaultExt = Extension,
                Filter = Filter
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FileFullName = openFileDialog.FileName;
                dialogResult = true;
            }
            return dialogResult;
        }

        public bool SaveDialog()
        {
            bool dialogResult = false;
            SaveFileDialog saveFileDialog = new()
            {
                DefaultExt = Extension,
                Filter = Filter
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                FileFullName = saveFileDialog.FileName;
                dialogResult = true;
            }
            return dialogResult;
        }
    }
}
