namespace Temp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		this.BindingContext = new MainPageVM();
    }

	protected override void OnDisappearing()
    {
        base.OnDisappearing();

		this.BindingContext = null;
    }
}

