namespace App.Views;

public partial class SchedulePage : ContentPage
{
	public SchedulePage()
	{
		InitializeComponent();
		BindingContext = new ScheduleViewModel();
	}
}