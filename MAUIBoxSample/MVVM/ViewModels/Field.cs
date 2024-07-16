using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBoxSample.MVVM.ViewModels;

public partial class Field : ObservableObject
{
    [ObservableProperty]
    private string selectedItem;

    private string _initialItem;
    public string InitialItem 
    {
        get => _initialItem; 
        set
        {
            _initialItem = value;
            if(SelectedItem == null)
            {
                SelectedItem = InitialItem;
            }

        } 
    }

    [ObservableProperty]
    private string borderColor;

    public Field()
    {
        //InitialItem = initialItem;
        //SelectedItem = initialItem;
        BorderColor = "#123456";
    }
}
