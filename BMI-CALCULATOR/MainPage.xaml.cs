namespace BMI_CALCULATOR
{
    public partial class MainPage : ContentPage
    {
        string gender = "";
        string ResultLabel = "";
        string recommendations = "";

        public MainPage()
        {
            InitializeComponent();
        }

        void HeightValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            HeightLabel.Text = Math.Ceiling(value).ToString();
        }

        void WeightValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            WeightLabel.Text =  Math.Ceiling(value).ToString();
        }
        void MaleTapped(object sender, TappedEventArgs args)
        {
            gender = "Male";
            MaleImageLayout.Opacity = 1;
            FemaleImageLayout.Opacity = 0.3;
        }

        void FemaleTapped(object sender, TappedEventArgs args)
        {
            gender = "Female";
            FemaleImageLayout.Opacity = 1;
            MaleImageLayout.Opacity = 0.3;
        }


        async private void CalculateBMI(object sender, EventArgs e)
        {
            var height = Int32.Parse(this.HeightLabel.Text);
            var weight = Int32.Parse(this.WeightLabel.Text);
            var bmi = Math.Floor((weight / Math.Pow(height, 2)) * 703);
            if (gender == "Male")
            {
                if (bmi < 18.5)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Underweight \n ";
                    recommendations = "Reccomendations: Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Statuss: Normal Weight \n ";
                    recommendations = "Reccomendations:  Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep\r\nregular check-ups to monitor overall health.";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Overweight \n ";
                    recommendations = "Reccomendations: Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink\r\nplenty of water and track your progress. ";
                }
                else if (bmi >= 30)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Obese \n ";
                    recommendations = "Reccomendations: Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary\r\ndrinks and maintain a consistent sleep schedule.";
                }
                else
                {
                    ResultLabel = "Please enter valid values";
                }
            }
            else if (gender == "Female")
            {
                if (bmi < 18)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Underweight \n";
                    recommendations = "Reccomendations: Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";

                }
                else if (bmi >= 18 && bmi < 24)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Normal Weight \n ";
                    recommendations = "Reccomendations:  Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep\r\nregular check-ups to monitor overall health.";

                }
                else if (bmi >= 24 && bmi < 29)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Overweight \n  ";
                    recommendations = "Reccomendations: Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink\r\nplenty of water and track your progress. ";

                }
                else if (bmi >= 29)
                {
                    ResultLabel = $" Gender: {gender} \n  BMI: {bmi.ToString()} Status: Obese \n ";
                    recommendations = "Reccomendations: Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary\r\ndrinks and maintain a consistent sleep schedule.";

                }
                else
                {
                    ResultLabel = "Please enter valid values";
                }
            }

            await Navigation.PushAsync(new BMIResults(ResultLabel, recommendations));
        }

  
   
    }

}
