﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nuphos.Helpers;
using System;
using Wpf.Ui.Contracts;

namespace Nuphos.ViewModels.Pages;

public partial class DashboardViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    public DashboardViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    [RelayCommand]
    private void OnCardClick(string parameter)
    {
        if (String.IsNullOrWhiteSpace(parameter))
            return;

        var pageType = NameToPageTypeConverter.Convert(parameter);

        if (pageType == null)
            return;

        _navigationService.Navigate(pageType);
    }
}
