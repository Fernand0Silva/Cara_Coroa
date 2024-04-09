using System.Runtime.CompilerServices;

namespace Teste
{
    public partial class MainPage : ContentPage
    {
        int coin = 0;
        string valor = "";

        public MainPage()
        {
            InitializeComponent();
            MoedaPicker.SelectedItem = 0;
        }

        private void JogaBtn_Clicked_1(object sender, EventArgs e)
        {
            //Pegar a opção escolhida e armazenar
            valor = MoedaPicker.SelectedItem.ToString(); // chamar a variavel valor, depois chamar o nome do Picker, depois o selecteItem e por fim converter a variavel para string
            int choice = 0;
            if (valor == "Cara")
            {
                choice = 1;
            }
            int rnd = new Random().Next(0, 2);
            string resulatado = "Cara";

            if (rnd == 0) 
            {
                resulatado = "Coroa";
            }

            if (rnd == choice)
            {
                ResultLabel.Text = $"Voce {resulatado}, venceu";
            }

            else
            {
                ResultLabel.Text = $"Voce {resulatado}, perdeu";
            }

            switch (rnd) 
            {
                case 0:
                   Imagem1.Source = "cara.jpeg";
                break;
                 case 1:
                    Imagem1.Source = "coroa.jpg";
                    break;
                default:
                    Imagem1.Source = "coroa.jpeg";
                    break;
            }          
        }
    }

}
