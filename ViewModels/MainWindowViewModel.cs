using FuneralCRM.DataBase;
using FuneralCRM.Models;
using FuneralCRM.Services;
using ReactiveUI;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reactive;
using System.Reactive.Linq;

namespace FuneralCRM.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private MenuElement _selectedMenuElement;
    private readonly IAccountatntRepository _accountatntRepository;
    private readonly ObservableAsPropertyHelper<AccountatntDTO> _accountatnt;

    public AccountatntDTO Account => _accountatnt.Value;
    public ReactiveCommand<Unit, AccountatntDTO?> GetAccountatntCommand { get; }
    public IList<MenuElement> MenuElements { get; }
    public IList<MenuElement> OtherMenuElements { get; }
    public MenuElement SelectedMenuElement
    {
        get => _selectedMenuElement;
        set => this.RaiseAndSetIfChanged(ref _selectedMenuElement, value);
    }

    public MainWindowViewModel(IAccountatntRepository accountatntRepository)
    {
        _accountatntRepository = accountatntRepository;
        MenuElements = new List<MenuElement>();
        {
            new MenuElement("Заказы", "order-alphabetical-ascending", () => new Orders());
            new MenuElement("Склад", "warehouse", () => new Warehouse());
            new MenuElement("Подрядчики", "account-multiple", () => new Subcontractor());
            new MenuElement("Отчёты", "file-settings-outline", () => new Subcontractor());
        }
        ;
        OtherMenuElements = new List<MenuElement>();
        {
            new MenuElement("Настройки", "cog", () => new Settings());
        };
    }
}
