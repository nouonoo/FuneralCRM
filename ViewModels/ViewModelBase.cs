using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;

namespace FuneralCRM.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public string Title { get; set; }
}

