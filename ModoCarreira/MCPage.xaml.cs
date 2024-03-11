namespace ModoCarreira;

public partial class MCPage : ContentPage
{

	public MCPage()
	{
		InitializeComponent();
	}

	private void TryAgain(object sender, EventArgs args)

		{
			if (Application.Current !=null)
		Application.Current.MainPage = new MainPage();
		}

}