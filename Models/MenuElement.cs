using FuneralCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralCRM.Models
{
    public class MenuElement
    {
        private readonly Lazy<ViewModelBase> _viewModel;

        public ViewModelBase ViewModel => _viewModel.Value;

        public string Title { get; set; }
        public string Icon { get; }

        public MenuElement(string title, string icon, Func<ViewModelBase> builder)
        {
            Title = title;
            Icon = icon;
            _viewModel = new Lazy<ViewModelBase>(builder);
        }
    }
}

   