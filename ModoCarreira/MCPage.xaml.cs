using Microsoft.Maui.Controls;

namespace ModoCarreira;

public partial class MCPage : ContentPage
{
	List<CareerStep> carreira = new List<CareerStep>();
	CareerStep CareerStepAtual;
	public MCPage()
	{
		InitializeComponent();
	
		carreira.Add(new CareerStep()
		 {
			Id = 0,
			Texto ="Escolha sua posição:",
			TemResposta = true,
			TextodaResposta1 = "Armador",
			TextodaResposta2 = "Ala",
			TextodaResposta3 = "Pivo",
			IdLevelResposta1 = 2,
			IdLevelResposta2 = 2,
			IdLevelResposta3 = 2,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 2,
			Texto ="Parabéns! você jogou tão bem o draft da sua temporada que três times estão querendo em seus elencos e como nao ouve um consenso entre eles abriram uma exceção e deixaram você escolher. Qual time deseja ir ?",
			TemResposta = true,
			TextodaResposta1 = "GSW",
			TextodaResposta2 = "NYP",
			TextodaResposta3 = "MB",
			IdLevelResposta1 = 3,
			IdLevelResposta2 = 3,
			IdLevelResposta3 = 3,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 3,
			Texto ="Porém o técnico não gostou muito da escolha pois disso que 'Ele só jogou bem por causa do nivel dos jogadores dessa temporada' prove ao contrario a ele!",
			TemResposta = false,
		 });

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
		labelTexto.Text = CareerStepAtual.Texto;

		if (CareerStepAtual.YouLost)
		 frameYouLost.IsVisible = true;
		else
		 frameYouLost.IsVisible = false;
	

		if (CareerStepAtual.TemResposta)
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
