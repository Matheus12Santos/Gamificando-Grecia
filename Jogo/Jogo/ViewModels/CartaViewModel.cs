using Jogo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Jogo.Services;

namespace Jogo.ViewModels
{
    internal partial class CartaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id = 0;

        [ObservableProperty]
        private Carta carta;

        [ObservableProperty]
        private string texto;

        [ObservableProperty]
        private string image = "image1.png";

        [ObservableProperty]
        private string name = "Princesa Leiya";

        CartaService cartaService;

        public ICommand GetCartaCommand { get; }
        public ICommand TrocarCartaCommand { get; }

        public CartaViewModel()
        {
            GetCartaCommand = new Command(GetCarta);
            TrocarCartaCommand = new Command(TrocarCarta);
            cartaService = new CartaService();
        }

        public async void GetCarta()
        {   
            Carta = await cartaService.GetCartaByIdAsync(Id);
            Image = "reigns_character_exemplo.png";
            Id += 1;
        }

        public void TrocarCarta()
        {           
            Id += 1;
            // Essa parte ainda será mudada;
            if (Id <= 3) {
                Image = "image" + Id + ".png";
                if (Image == "image1.png")
                {
                    Name = "Princesa Leiya";
                }
                if (Image == "image2.png")
                {
                    Name = "Guerreira Mary";
                }
                if (Image == "image3.png")
                {
                    Name = "Lorde Kraven";
                }
            }
            else
            {
                Id = 0;
            }                           
        }
    }
}
