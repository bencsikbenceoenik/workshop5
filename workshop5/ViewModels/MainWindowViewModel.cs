using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Backend.Model;
using System.ComponentModel;
using System.Windows;
using System.Numerics;

namespace workshop5.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        private string inputText = "";
        private string sentby = "";
        public string InputText
        {
            get { return inputText; }
            set { inputText = value; OnPropertyChanged(); (SendCommand as RelayCommand).NotifyCanExecuteChanged(); }
        }
        public ICommand SendCommand { get; set; }
        public RestCollection<Chat> Chats { get; set; }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Chats = new RestCollection<Chat>("http://localhost:53910/", "chat", "hub"); //majd névre figyelni
                SendCommand = new RelayCommand(() =>
                {
                    Chats.Add(new Chat(sentby, InputText, DateTime.Now.ToString("MM/dd/yyyy h:mm tt")));
                    inputText = "";
                });
            }
        }
    }
}
