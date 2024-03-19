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
			IdLevelResposta2 = 50,
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
			Texto =" Seu time esta na final da liga contra os Los Angeles Clippers o jogo esta 127 a 125 e você recebe a bola faltando 5 segundos para o fim do jogo você",
			TemResposta = true,
			TextodaResposta1 = "Tenta uma bola de 3 pontos do meio da quadra",
			TextodaResposta2 = "Faz o passe para seu colega que esta melhor posicionado",
			TextodaResposta3 = "Infiltra e tenta uma bandeja para levar o jogo para a prorrogação",
			IdLevelResposta1 = 1001,
			IdLevelResposta2 = 7,
			IdLevelResposta3 = 69,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 7,
			Texto ="Seu colega faz a cesta e seu time é campeão. Bom trabalho !",
			TemResposta = false,
			YouWin = true,
		 });

		 carreira.Add(new CareerStep()
		 {
			Id = 50,
			Texto ="Mesmo não jogando seu máximo você fez 10 pontos 3 assistencias e 1 roubo de bola e seu time ganhou",
			TemResposta = false,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 51,
			Texto ="Você fez uma sequencia mediana de 7 partidas com mais de 10 pontos, 5 assistencia e 2 roubos de bola",
			TemResposta = false,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 52,
			Texto ="Seu time foi para as semi-finais da temporada contra o Dallas Mavericks",
			TemResposta = false,

		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 53,
			Texto ="O jogo esta no terceiro quarto aos 01:25 do jogo e você esta no banco e o técnico decide coloca-lo com seu time ganhando de 101 a 95, mas por ser. Entretanto você está muito nervoso e acaba sendo expulso do jogo por cometer mais de 5 faltas individuais",
			TemResposta = false,

		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 54,
			Texto ="Seu time acaba sofrendo uma virada historia e o jogo vai para a prorrogação com o jogo 130 a 130. O técnico olha para você e te dá outra chance de mudar a historia do jogo. O que você faz ? ",
			TemResposta = true,
			TextodaResposta1 ="Entro no jogo ",
			TextodaResposta2 ="Falo que é melhor eu não entrar e reconhecer que esta meio nervoso",
			TextodaResposta3 ="",
			IdLevelResposta1 = 55,
			IdLevelResposta2 = 1002,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 55,
			Texto ="Você jogou muito bem a prorrogação e seu time foi para as finais",
			TemResposta = false,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 56,
			Texto ="O técnico decidiu te colocar como titular em um jogo contra os Los Angeles Lakers",
			TemResposta = true,

		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 57,
			Texto ="O jogo esta muito intenso e seu time esta perdendo de 120 a 118, os 2 times já estouraram as faltas e faltando 07 segundos para o jogo acabar você recebe a bola na lateral e de costas para a cesta, o que você faz?",
			TemResposta = true,
			TextodaResposta1 = "Arremesso para fazer uma cesta 2 pontos e cavar uma falta ",
			TextodaResposta2 = "Giro no meu marcador e arremesso de 3 pontos ",
			TextodaResposta3 = "Tento uma ponte aérea para o pivo que esta chegando",
			IdLevelResposta1 = 1003,
			IdLevelResposta2 = 58,
			IdLevelResposta3 = 1004,

		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 58,
			Texto ="MINHA NOSSA !!! QUE JOGADA INCRÍVEL. Depois dessa cesta o seu time ganha com o relógio estourando. Meus parabéns !",
			TemResposta = true,

		 });




		 carreira.Add(new CareerStep()
		 {
			Id = 1000,
			Texto ="Você foi demitido",
			TemResposta = false,
			YouLost = true,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 1001,
			Texto ="Você erra a bola e seu time perdeu",
			TemResposta = false,
			YouLost = true,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 1002,
			Texto ="Seu time nao se classificou para as finais tenta na temporada seguinte",
			TemResposta = false,
			YouLost = true,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 1003,
			Texto ="Você toma o toco mais humilhante da sua vida e seu time perde",
			TemResposta = false,
			YouLost = true,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 1003,
			Texto ="Você toma o toco mais humilhante da sua vida e seu time perde",
			TemResposta = false,
			YouLost = true,
		 });
		 carreira.Add(new CareerStep()
		 {
			Id = 1004,
			Texto ="Você deu uma passe horrível e a bola foi para fora seu time perdeu!",
			TemResposta = false,
			YouLost = true,
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

	

		if (CareerStepAtual.TemResposta)
		{
			NextStep.IsVisible = false;
			FirstOption.IsVisible = true;
			SecondOption.IsVisible = true;
			ThirdOption.IsVisible = true;
			FirstOption.Text = CareerStepAtual.TextodaResposta1;
			SecondOption.Text = CareerStepAtual.TextodaResposta2;
			ThirdOption.Text = CareerStepAtual.TextodaResposta3;

				if(FirstOption.Text =="")
                    FirstOption.IsVisible = false;
                else
                    FirstOption.IsVisible = true;

                if(SecondOption.Text =="")
                    SecondOption.IsVisible = false;
                else
                    SecondOption.IsVisible = true;

                if(ThirdOption.Text =="")
                    ThirdOption.IsVisible = false;
                else
                    ThirdOption.IsVisible = true;
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
