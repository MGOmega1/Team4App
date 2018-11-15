﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TeamApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void MeetingsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendaPage());
        }

        private void ScheduleButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }

        private void NewsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewsPage());
        }

        private void HoursButton_Clicked(object sender, EventArgs e)
        {
          //  Navigation.PushAsync(new SubmitHoursPage());
        }
    }
}
