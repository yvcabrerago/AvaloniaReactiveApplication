using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using AvaloniaReactiveApplication.ViewModels;
using ReactiveUI;

namespace AvaloniaReactiveApplication.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        this.WhenActivated(disposed =>
        {
            this.OneWayBind(ViewModel, vm => vm.Greeting, v => v.TextBlock.Text).DisposeWith(disposed);
            this.BindCommand(ViewModel, vm => vm.MyCommand, v => v.Button).DisposeWith(disposed);
        });
        
        InitializeComponent();
    }
}