using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MAUIBoxSample.MVVM.ViewModels;

public partial class FormPageVM : ObservableObject
{
    public List<string> Planets { get; }
    [ObservableProperty]
    private Field planetField;
    [ObservableProperty]
    private Field nameField;

    public FormPageVM()
    {
        Planets = new List<string>
        {
                "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
        };


        LoadData();
    }
    private void LoadData()
    {
        NameField = new Field { InitialItem = "Venutian"};
        PlanetField = new Field { InitialItem = "Venutian" };
    }

    [RelayCommand]
    private void HandleField(string afield)
    {
        Console.WriteLine(afield);

        //var field = (Field)afield;
        Console.WriteLine("*************************************");
        Console.WriteLine("*************************************");
        Console.WriteLine("*************************************");
        Console.WriteLine("*************************************");
        //if (field.InitialItem == field.SelectedItem)
        //{
        //    field.BorderColor = "#123456";
        //}
        //else
        //{
        //    field.BorderColor = "#654321";
        //}
    }
}
