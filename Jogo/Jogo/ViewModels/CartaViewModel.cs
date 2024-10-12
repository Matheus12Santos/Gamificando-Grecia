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
        int id = 0;

        [ObservableProperty]
        Carta carta; 

        [ObservableProperty]
        string texto;

        [ObservableProperty]
        string image = "image1.png";

        CartaService cartaService;

        public ICommand getCartaCommand { get; }
        public ICommand trocarCartaCommand { get; }

        public CartaViewModel()
        {
            getCartaCommand = new Command(getCarta);
            trocarCartaCommand = new Command(trocarCarta);
            cartaService = new CartaService();

        }



       
        public async void getCarta()
        {   
            Carta = await cartaService.GetCartaByIdAsync(id);
            image = "reigns_character_exemplo.png";
            id = id + 1;
        }

        public async void trocarCarta()
        {
           
            Id = id + 1;
           if (id <= 3) {
                Image = "image" + id + ".png";
            }
            else
            {
                Id = 0;
            }
           
            
        }


    }
}
