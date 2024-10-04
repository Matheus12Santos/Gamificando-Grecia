using CommunityToolkit.Mvvm.ComponentModel;
using Greece.Models;
using Greece.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Greece.ViewModels
{
    internal partial class CartaViewModel:ObservableObject
    {
        [ObservableProperty]
        int id;

        [ObservableProperty]
        Carta carta; //substituir listas em observal collection

        [ObservableProperty]
        string texto;

        [ObservableProperty]
        string image;

        CartaService cartaService;
        
        public ICommand getCartasCommand { get; }//nao tem set

        public CartaViewModel()
        {
            getCartasCommand = new Command(getCarta);
            cartaService = new CartaService();//instanciando o post service

        }




        public async void getCarta()
        {

            Carta = await cartaService.GetCartaByIdAsync(id);// chamando o metodo assincrono do service
            image = Carta.image;
        }
    }
}
