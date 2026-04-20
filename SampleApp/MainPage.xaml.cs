namespace SampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Loaded+=MainPage_Loaded;
	}

	private void MainPage_Loaded(object? sender,EventArgs args)
	{
		var xx=AgoraRtcKitBinding.AgoraRtcEngineKit.SharedEngineWithAppId("",new MAUIAgoraRtcEngineDelegate());
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
