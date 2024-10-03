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
        ObservableCollection<Carta> cartas; //substituir listas em observal collection
        CartaService cartaService;
        public ICommand getCartasCommand { get; }//nao tem set

        public CartaViewModel()
        {
            getCartasCommand = new Command(getPostagens);
            cartaService = new CartaService();//instanciando o post service

        }




        public async void getPostagens()
        {

            Cartas = await cartaService.GetCartasAsync();// chamando o metodo assincrono do service
        }
    }
}
