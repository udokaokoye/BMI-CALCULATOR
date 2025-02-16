namespace BMI_CALCULATOR;

public partial class HealthRecommendations : ContentPage
{

    public HealthRecommendations(string recommendations)
	{
		InitializeComponent();
        recommendationsLabel.Text = recommendations;

    }

    private void NavigateToUserInput(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void NavigateBack(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}