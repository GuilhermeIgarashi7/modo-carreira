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
			IdLevelResposta1 = 1,
			IdLevelResposta2 = 1,
			IdLevelResposta3 = 1,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 1,
			Texto ="Parabéns! você jogou tão bem o draft da sua temporada que três times estão querendo em seus elencos e como nao ouve um consenso entre eles abriram uma exceção e deixaram você escolher. Qual time deseja ir ?",
			TemResposta = true,
			TextodaResposta1 = "GSW",
			TextodaResposta2 = "NYP",
			TextodaResposta3 = "MB",
			IdLevelResposta1 = 2,
			IdLevelResposta2 = 2,
			IdLevelResposta3 = 2,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 2,
			Texto ="Porém o técnico não gostou muito da escolha pois disso que 'Ele só jogou bem por causa do nivel dos jogadores dessa temporada' prove ao contrario a ele!",
			TemResposta = false,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 3,
			Texto ="Logo o seu primeiro jogo você esta no banco de reservas, estão jogando contra o Los Angeles Lakers e o jogo esta no segundo quarto faltando dois minutos e trinta e sete segundos e os Lakers estão com 16 pontos de vantagem, o tecnico olha para você e fala 'preciso de você seu estilo de jogo é oque esta faltando no time' o que você faz?",
			TemResposta = true,
			TextodaResposta1 = "Entro e mudo o jogo",
			TextodaResposta2 = "Entro e não faço muita coisa porém o time ganha",
			TextodaResposta3 = "Me recuso a entrar e repito a fala dele",
			IdLevelResposta1 = 4,
			IdLevelResposta2 = 5,
			IdLevelResposta3 = 1000,
		 });

		carreira.Add(new CareerStep()
		 {
			Id = 4,
			Texto ="Parabéns! fez uma partida incrivel com 28 pontos 7 assistencias e 4 roubos de bolas",
			TemResposta = false,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 5,
			Texto ="Você fez  uma sequencia incrivel de 5 partidas com mais de 20 pontos, 10 assistncia e 5 roubos de bola !",
			TemResposta = false,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 6,
			Texto ="Você fez  uma sequencia incrivel de 5 partidas com mais de 20 pontos, 10 assistncia e 5 roubos de bola ",
			TemResposta = false,
		 });
		carreira.Add(new CareerStep()
		 {
			Id = 7,
			Texto =" Seu time esta na final da liga contra os Los Angeles Clippers o jogo esta 127 a 125 e você recebe a bola faltando 5 segundos para o fim do jogo você",
			TemResposta = true,
			TextodaResposta1 = "Tenta uma bola de 3 pontos do meio da quadra",
			TextodaResposta2 = "Faz o passe para seu colega que esta melhor posicionado",
			TextodaResposta3 = "Infiltra e tenta uma bandeja para levar o jogo para a prorrogação",
			IdLevelResposta1 = 1001,
			IdLevelResposta2 = 8,
			IdLevelResposta3 = 69,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 8,
			Texto ="Seu colega faz a cesta e seu time é campeão. Bom trabalho !",
			TemResposta = false,
		 });




		 






		Iniciar();

		 

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

		if (CareerStepAtual.YouWin)
		 frameYouWin.IsVisible = true;
		else
		 frameYouWin.IsVisible = false;
	

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
