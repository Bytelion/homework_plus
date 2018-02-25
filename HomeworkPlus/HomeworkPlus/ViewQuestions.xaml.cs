using Newtonsoft.Json;
using Plugin.Settings;
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
	public partial class ViewQuestions : ContentPage
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

        public ViewQuestions ()
		{
			InitializeComponent ();

            string subject = CrossSettings.Current.GetValueOrDefault("subject", "");
            SubjectLabel.Text = subject;

            List<Question> questions = new List<Question>();
            var postsJson = CrossSettings.Current.GetValueOrDefault(subject, "");
            if (postsJson != null && postsJson != "" && postsJson != "[]")
            {
                questions = JsonConvert.DeserializeObject<List<Question>>(postsJson);                
                QuestionList.ItemsSource = questions;
            }
        }
	}
}