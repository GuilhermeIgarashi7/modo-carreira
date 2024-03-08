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
		
	private void OpenTutorial(object sender, EventArgs args)
			{
			frameTutorial.IsVisible = true;
			}

	private void BackButton(object sender, EventArgs args)

  	 	 {
		frameTutorial.IsVisible = false;
	 	 }

	private void OpenAbout(object sender, EventArgs args)
		{
			frameAbout.IsVisible = true;
		}

	private void BackAboutButton(object sender, EventArgs args)

  	 	 {
		frameAbout.IsVisible = false;
	 	 }




}










