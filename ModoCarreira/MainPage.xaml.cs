namespace ModoCarreira;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OpenStart(object sender, EventArgs args)

		{
			if (Application.Current !=null)
		Application.Current.MainPage = new MCPage();
		}
		
	






}










