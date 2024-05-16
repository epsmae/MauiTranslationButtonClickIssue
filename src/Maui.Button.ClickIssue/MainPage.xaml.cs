namespace Maui.Button.ClickIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        if (width > TranslationLayout.ColumnDefinitions[0].Width.Value)
        {
            TranslationLayout.ColumnDefinitions[0] = new ColumnDefinition { Width = width };
            TranslationLayout.ColumnDefinitions[1] = new ColumnDefinition { Width = 0.8 * width };
        }
    }


    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OnTranslateClicked(object? sender, EventArgs e)
    {
        TranslationLayout.TranslationX = -TranslationLayout.ColumnDefinitions[1].Width.Value;
    }
}

