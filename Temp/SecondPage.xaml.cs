namespace Temp;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

		this.BindingContext = new SecondPageVM();
    }

	protected override void OnDisappearing()
    {
        base.OnDisappearing();

		this.BindingContext = null;
    }
}