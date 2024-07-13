using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIBoxSample.MVVM.Views;


namespace MAUIBoxSample.MVVM.ViewModels;


public partial class MainPageVM : ObservableObject
{


    [RelayCommand]
    private void GoToFormPage()
    {
        Shell.Current.GoToAsync(nameof(FormPage));
    }
}
