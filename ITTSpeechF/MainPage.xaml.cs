namespace ITTSpeechF;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		//imgButton.Source = "C:\\Users\\sinoa\\Documents\\development\\web\\Icons\\menu-button-of-three-horizontal-lines-white.png";

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

