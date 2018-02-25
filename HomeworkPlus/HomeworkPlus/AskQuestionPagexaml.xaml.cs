using Plugin.Settings;
using Newtonsoft.Json;
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
	public partial class AskQuestionPagexaml : ContentPage
	{
        enum Subjects
        {
            English,
            Science,
            SocialStudies,
            Math,
            LanguageArts,
            Electives,
            Other
        };

        public int Subject { get; set; }

		public AskQuestionPagexaml ()
		{
			InitializeComponent ();

            string subject = CrossSettings.Current.GetValueOrDefault("subject", "");
            SubjectLabel.Text = subject;
            
            PostButton.Clicked += delegate
            {                
                if (PostText.Text != "Please enter a question.")
                {
                    List<Question> questions = new List<Question>();
                    var postsJson = CrossSettings.Current.GetValueOrDefault(subject, "");
                    if (postsJson != null && postsJson != "" && postsJson != "[]")
                    {
                        questions = JsonConvert.DeserializeObject<List<Question>>(postsJson);
                    }

                    questions.Add(new Question(ClassName.Text, PostText.Text, DateTime.Now));
                    string jsonResult = JsonConvert.SerializeObject(questions);
                    
                    CrossSettings.Current.AddOrUpdateValue(subject, jsonResult);
                    Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    PostText.Text = "Must enter text before submitting!";
                }
            };

            PostText.Unfocused += delegate
            {
                if (PostText.Text == String.Empty)
                {
                    PostText.Text = "Please enter a question.";
                    PostText.TextColor = Color.DarkGray;
                }
            };

            PostText.Focused += delegate
            {
                if (PostText.Text == "Please enter a question.")
                {
                    PostText.TextColor = Color.Black;
                    PostText.Text = "";
                }
            };
		}
	}
}