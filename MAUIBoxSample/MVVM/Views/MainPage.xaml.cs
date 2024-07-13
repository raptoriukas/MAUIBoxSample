using MAUIBoxSample.MVVM.ViewModels;

namespace MAUIBoxSample.MVVM.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FormPage));
    }
}
