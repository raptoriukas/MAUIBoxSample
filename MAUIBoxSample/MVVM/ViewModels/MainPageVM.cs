using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIBoxSample.MVVM.Views;


namespace MAUIBoxSample.MVVM.ViewModels;


public partial class MainPageVM : ObservableObject
{
    [ObservableProperty]
    public byte[] image = null;

    [ObservableProperty]
    private string name = "Arnold";


    [RelayCommand]
    private void GoToFormPage()
    {
        Shell.Current.GoToAsync(nameof(FormPage));
    }

    [RelayCommand]
    private async void TakePhoto()
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
            Image = imageData;
        }
    }

}
