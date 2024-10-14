using Jogo.ViewModels;

namespace Jogo.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		InitializeComponent();
        BindingContext = new CartaViewModel();
    }

   

    
}