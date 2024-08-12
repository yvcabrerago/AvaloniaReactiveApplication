using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaReactiveApplication.ViewModels;

public  class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        MyCommand = ReactiveCommand.Create(Method);
    }
    [Reactive] public string Greeting { get; set; } = "Welcome to Avalonia!";
    
    private void Method()
    {
        Greeting = "something";
    }

    public ReactiveCommand<Unit, Unit> MyCommand { get; }

}