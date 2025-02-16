namespace BMI_CALCULATOR;

public partial class BMIResults : ContentPage
{
    private string recommendations;
    private string results;
    public BMIResults(string results, string recommendations)
	{
		InitializeComponent();

        ResultLabel.Text = results;
        this.recommendations = recommendations;
        this.results = results;

    }

    private void NavigatetoHealthRecommendationsPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HealthRecommendations(recommendations));
    }

    private void NavigateBack(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}