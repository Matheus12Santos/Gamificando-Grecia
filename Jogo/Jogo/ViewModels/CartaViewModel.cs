using Jogo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Jogo.Services;
using System.Runtime.Intrinsics.X86;

namespace Jogo.ViewModels
{
    internal partial class CartaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id=1;

        [ObservableProperty]
        private Carta carta;

        [ObservableProperty]
        private Medidor medidor;

        [ObservableProperty]
        private string texto = "General, uma tempestade se aproxima, deveriamos esperar ela passar?";

        [ObservableProperty]
        private string image = "image1.png";

        [ObservableProperty]
        private string name = "Eryx";

        [ObservableProperty]
        private int idMedidor = 1;


        [ObservableProperty]
        private int estatisMantimentos = 100;
        
        [ObservableProperty]
        private int estatisExercito = 100;
        
        [ObservableProperty]
        private int estatisConfianca = 100;

        [ObservableProperty]
        private int diasGuerra = 15;

        [ObservableProperty]
        private string textoGuerra;

        [ObservableProperty]
        private int count = 0;



        CartaService cartaService;
        MedidorService medidorService;

        public ICommand GetCartaCommand { get; }
        public ICommand TrocarCartaCommand { get; }

        public ICommand Opcao1 { get; }
        public ICommand Opcao2 { get; }

        public CartaViewModel()
        {
           
            cartaService = new CartaService();
            medidorService = new MedidorService();
            Opcao1 = new Command(() =>
            {
                ModificarMedidor(1);
                TrocarCarta();
                contadorDias();
            });
            Opcao2 = new Command(() =>
            {
                ModificarMedidor(2);
                TrocarCarta();
                contadorDias();
            });
            
        }

       

        public async void ModificarMedidor(int opcao)
        {
           
            Medidor = await medidorService.GetMedidorByIdAsync(id);
            if (opcao == 1)
            {
                EstatisExercito = EstatisExercito + Medidor.EstatisExercito;
                EstatisConfianca = EstatisConfianca +  Medidor.EstatisConfiaca;
                EstatisMantimentos = EstatisMantimentos + Medidor.EstatisMantimentos;
                Convert.ToString(estatisExercito);
                Convert.ToString(estatisConfianca);
                Convert.ToString(estatisMantimentos);
                IdMedidor += 1;
            }
            else if (opcao == 2 )
            {
                IdMedidor += 1;
                EstatisExercito = EstatisExercito + Medidor.EstatisExercito;
                EstatisConfianca = EstatisConfianca + Medidor.EstatisConfiaca;
                EstatisMantimentos = EstatisMantimentos + Medidor.EstatisMantimentos;
                Convert.ToString(EstatisExercito);
                Convert.ToString(EstatisConfianca);
                Convert.ToString(EstatisMantimentos);

            }

            if (EstatisConfianca>100 || EstatisExercito>100 || EstatisMantimentos > 100)
            {
                EstatisMantimentos = 100;
                EstatisExercito = 100;
                EstatisExercito = 100;

            }

            if(IdMedidor >= 6)
            {
                IdMedidor = 1;
            }

        }
       
        public async void TrocarCarta()
        {
            Id += 1;
           
            if (Id <= 3) {
                Image = "image" + Id + ".png";
                Carta = await cartaService.GetCartaByIdAsync(Id);
                Name = Carta.personName;
                Texto = Carta.personTexto;
               


            }
            else
            {
                Id = 1;
                Image = "image" + Id + ".png";
                Name = "Eryx";
                Texto = "General, uma tempestade se aproxima, deveriamos esperar ela passar ?";
                
            }     
            
        }

        public async void contadorDias()
        {
           
           
            DiasGuerra = DiasGuerra -  1;
            Convert.ToString(DiasGuerra);
            if (Count == 0 && DiasGuerra == 0) {
                Count = 1;
                DiasGuerra = 5;
            }
            if(DiasGuerra == 0 && Count == 1)
            {
                DiasGuerra = 0;
                Application.Current.MainPage.DisplayAlert("PARABÉNS", "VOCÊ SOBREVIVEU A GUERRA FINALIZOU O JOGO!", "Voltar do Começo");
                Id = 1;
                Image = "image" + Id + ".png";
                Name = "Eryx";
                Texto = "General, uma tempestade se aproxima, deveriamos esperar ela passar ?";


            }
            
        }

        

    }
}
