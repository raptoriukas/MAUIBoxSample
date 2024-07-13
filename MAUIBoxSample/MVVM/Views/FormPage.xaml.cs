using MAUIBoxSample.MVVM.ViewModels;

namespace MAUIBoxSample.MVVM.Views;

public partial class FormPage : ContentPage
{
	public FormPage(FormPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}