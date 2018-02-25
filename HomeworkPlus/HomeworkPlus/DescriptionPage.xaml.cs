using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeworkPlus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DescriptionPage : ContentPage
	{
		public DescriptionPage ()
		{
			InitializeComponent ();

            AskButton.Clicked += delegate
            {
                Navigation.PushAsync(new AskQuestionPagexaml());
            };

            QuestionsButton.Clicked += delegate
            {
                Navigation.PushAsync(new ViewQuestions());
            };
        }
	}
}