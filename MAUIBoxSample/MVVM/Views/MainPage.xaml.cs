using CommunityToolkit.Maui.Core;
using MAUIBoxSample.MVVM.ViewModels;

namespace MAUIBoxSample.MVVM.Views;

public partial class MainPage : ContentPage
{

    private ICameraProvider cameraProvider;
    private MainPageVM Vm;
    public MainPage(MainPageVM vm, ICameraProvider cameraProvider)
    {
        this.cameraProvider = cameraProvider;
        InitializeComponent();
        BindingContext = vm;
        Vm = vm;
    }




    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FormPage));
    }

    private void MyCamera_MediaCaptured(object? sender, CommunityToolkit.Maui.Views.MediaCapturedEventArgs e)
    {
        if (Dispatcher.IsDispatchRequired)
        {
            Dispatcher.Dispatch(() => MyImage.Source = ImageSource.FromStream(() => e.Media));
            return;
        }

        MyImage.Source = ImageSource.FromStream(() => e.Media);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            if (photo == null)
                return;
            byte[] imageData;
            string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using Stream stream = await photo.OpenReadAsync();
            using (FileStream localFileStream = File.OpenWrite(localFilePath))
            {

                await stream.CopyToAsync(localFileStream);
            }
            imageData = File.ReadAllBytes(localFilePath);
            Console.WriteLine(imageData);
            Vm.Image = imageData;
        }
    }
}
