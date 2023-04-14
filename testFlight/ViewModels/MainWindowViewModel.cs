using System;
using testFlight.Commands;
using testFlight.Models;
using testFlight.Services.DialogServices.Interfaces;
using testFlight.Services.SerializerService.Interfaces;

namespace testFlight.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly ISerializerService serializerService;
        private readonly IFileDialogService fileDialogService;
        private readonly IMessageService messageService;

        public MainWindowViewModel(ISerializerService serializerService, IFileDialogService fileDialogService, IMessageService messageService)
        {
            this.serializerService = serializerService;
            this.fileDialogService = fileDialogService;
            this.messageService = messageService; 
        }

        private Flight flight;

        public Flight Flight 
        {
            get => flight;
            set
            {                
                if (flight != value)
                {
                    flight = value;
                    OnPropertyChanged(nameof(Flight));
                }
            }
        }


        private RelayCommand openFileCommand;
        public RelayCommand OpenFileCommand
        {
            get
            {
                return openFileCommand ??= new RelayCommand(obj =>
                {
                    try
                    {
                        if (fileDialogService.OpenDialog())
                        {
                            Flight = serializerService.Deserialize<Flight>(fileDialogService.FileFullName);
                            Flight.UpdatePassengers();
                            messageService.Show("Данные о рейсе загружены");
                        }
                    }
                    catch (Exception ex)
                    {
                        messageService.Show(ex.Message, MessageType.Error);
                    }
                  });
            }
        }

        private RelayCommand saveFileCommand;
        public RelayCommand SaveFileCommand
        {
            get
            {
                return saveFileCommand ??= new RelayCommand(obj =>
                {
                    if (Flight == null)
                    {
                        messageService.Show("Нет данных о рейсе", MessageType.Warning);
                        return;
                    }

                    try
                    {
                        if (fileDialogService.SaveDialog())
                        {
                            serializerService.Serialize(Flight, fileDialogService.FileFullName);
                            messageService.Show("Данные о рейсе сохранены");
                        }
                    }
                    catch (Exception ex)
                    {
                        messageService.Show(ex.Message, MessageType.Error);
                    }
                });
            }
        }
    }
}
