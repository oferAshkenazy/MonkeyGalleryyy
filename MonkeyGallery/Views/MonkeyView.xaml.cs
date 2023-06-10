using MonkeyGallery.ViewModels;
using MonkeyGallery.Models;
namespace MonkeyGallery.Views;

public partial class MonkeyView : ContentPage
{
	
	public MonkeyView( MonkeysPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


}