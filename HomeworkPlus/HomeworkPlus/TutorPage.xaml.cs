﻿using Plugin.Settings;
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
	public partial class TutorPage : ContentPage
	{
		public TutorPage ()
		{
			InitializeComponent ();

            string subject = CrossSettings.Current.GetValueOrDefault("subject", "");
            SubjectLabel.Text = subject;

            SubmitButton.Clicked += delegate
            {
                Application.Current.MainPage.Navigation.PopAsync();
            };
        }
	}
}