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
        private string texto = "General, uma tempestade se aproxima, deveriamos esperar ela passar?";

        [ObservableProperty]
        private string image = "image1.png";

        [ObservableProperty]
        private string name = "Eryx";

        [ObservableProperty]
        private string textoHover; // Texto exibido ao passar o mouse sobre o botão

        [ObservableProperty]
        private bool isHovering;  // Controle de exibição do texto

        CartaService cartaService;

        public ICommand GetCartaCommand { get; }
        public ICommand TrocarCartaCommand { get; }

        public CartaViewModel()
        {
           
            TrocarCartaCommand = new Command(TrocarCarta);
            cartaService = new CartaService();
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


        

    }
}
