

using Greece.ViewModels;

namespace Greece.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		InitializeComponent();
		BindingContext = new CartaViewModel();

    }
}