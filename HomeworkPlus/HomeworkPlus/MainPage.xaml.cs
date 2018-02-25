using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeworkPlus
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();

            EnglishButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "English");
                Navigation.PushAsync(new DescriptionPage());                
            };

            ScienceButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Science");
                Navigation.PushAsync(new DescriptionPage());                
            };

            SocialStudiesButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Social Studies");
                Navigation.PushAsync(new DescriptionPage());                
            };

            MathButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Mathematics");
                Navigation.PushAsync(new DescriptionPage());
            };

            LanguageArtsButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Language Arts");
                Navigation.PushAsync(new DescriptionPage());                
            };

            ElectivesButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Electives");
                Navigation.PushAsync(new DescriptionPage());               
            };

            OtherButton.Clicked += delegate
            {
                CrossSettings.Current.AddOrUpdateValue("subject", "Other");
                Navigation.PushAsync(new DescriptionPage());                
            };
        }
	}
}
