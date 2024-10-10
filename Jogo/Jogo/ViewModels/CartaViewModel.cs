using Jogo.Models;
using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Jogo.Services;

namespace Jogo.ViewModels
{
    internal partial class CartaViewModel:ObservableObject
    {
        [ObservableProperty]
        int id;

        [ObservableProperty]
        Carta carta; 

        [ObservableProperty]
        string texto;

        [ObservableProperty]
        string image;

        CartaService cartaService;

        public ICommand getCartaCommand { get; }

        public CartaViewModel()
        {
            getCartaCommand = new Command(getCarta);
            cartaService = new CartaService();

        }




        public async void getCarta()
        {
            Carta = await cartaService.GetCartaByIdAsync(id);
            image = "reigns_character_exemplo.png";
        }
    }
}
