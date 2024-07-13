using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBoxSample.MVVM.ViewModels;

public class Field2
{
    //[ObservableProperty]
    private string selectedItem;

    public string InitialItem { get; }

    //[ObservableProperty]
    private string borderColor;

    //public Field2(string initialItem)
    //{
    //    InitialItem = initialItem;
    //    SelectedItem = initialItem;
    //    BorderColor = "#123456";
    //}
}
