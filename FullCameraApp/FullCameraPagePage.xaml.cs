using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FullCameraApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FullCameraPagePage : ContentPage
	{
	    public FullCameraPagePage()
	    {
	        InitializeComponent();
	        TakePhotoButton.Clicked += TakePhotoButton_Clicked;
	    }

	    async void TakePhotoButton_Clicked(object sender, System.EventArgs e)
	    {
	        var cameraPage = new CameraPage();
	        cameraPage.OnPhotoResult += CameraPage_OnPhotoResult;
	        await Navigation.PushModalAsync(cameraPage);
	    }

	    async void CameraPage_OnPhotoResult(FullCameraApp.PhotoResultEventArgs result)
	    {
	        await Navigation.PopModalAsync();
	        if (!result.Success)
	            return;

	        Photo.Source = ImageSource.FromStream(() => new MemoryStream(result.Image));
	    }
	}
}