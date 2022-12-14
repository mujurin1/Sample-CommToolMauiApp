using CommToolMauiApp.ViewModels;

namespace CommToolMauiApp.Views;

public partial class DetailPage : ContentPage
{
    /// <summary>x</summary>
    /// <param name="vm"></param>
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}