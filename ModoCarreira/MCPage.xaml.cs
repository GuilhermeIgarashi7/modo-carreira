using Microsoft.Maui.Controls;

namespace ModoCarreira;

public partial class MCPage : ContentPage
{
	List<CareerStep> carreira = new List<CareerStep>();
	CareerStep CareerStepAtual;
	public MCPage()
	{
		InitializeComponent();
	}

	void Iniciar()
	{
		TrocaCareerStepAtual(0);
	}

	void TrocaCareerStepAtual(int id)
	{
		CareerStepAtual = carreira.Where(d => d.Id == id).First();
		PreencherPagina();
	}

	void PreencherPagina()
	{
		labelTexto.Text;

		if (CareerStepAtual.YouLost)
		 frameYouLost.IsVisible = true;
		else
		 frameYouLost.IsVisible = false;
	

	if (CareerStep.TemResposta)
	 {
		NextStep.IsVisible = false;
		FirstOption.IsVisible = true;
		SecondOption.IsVisible = true;
		ThirdOption.IsVisible = true;
		FirstOption.Text = CareerStepAtual.TextodaResposta1;
		SecondOption.Text = CareerStepAtual.TextodaResposta2;
		ThirdOption.Text = CareerStepAtual.TextodaResposta3;

	 }
	else
	 {
		NextStep.IsVisible = true;
		FirstOption.IsVisible = false;
		SecondOption.IsVisible = false;
		ThirdOption.IsVisible = false;
	 }

	void NextStepClicked(object sender, EventArgs args)
	{
		var nextId = CareerStepAtual.Id + 1;
		TrocaCareerStepAtual(nextId);
	}


	void FirstOptionClicked(object sender, EventArgs args)
	{
		TrocaCareerStepAtual(CareerStepAtual.IdLevelResposta1);
	}

	void SecondOptionOptionClicked(object sender, EventArgs args)
	{
		TrocaCareerStepAtual(CareerStepAtual.IdLevelResposta2);
	}

	void ThirdOptionOptionClicked(object sender, EventArgs args)
	{
		TrocaCareerStepAtual(CareerStepAtual.IdLevelResposta3);
	}

	void TryAgain(object sender, EventArgs args)
	{
		Iniciar();
	}


	}
	
}