using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TeamApp1
{
    public partial class AgendaPage2 : ContentPage
    {
        public AgendaPage2()
        {
            InitializeComponent();

            Day.Text = DateTime.Today.ToString("dddd");

            if (DateTime.Today.ToString("dddd") == "Monday")
            {
                Line1.Text = "10:00pm - Meeting with the CEO";
                Line2.Text = "12:00pm - Lunch with Client";
                Line3.Text = "5:00pm - Have Project Finished";
                Line4.Text = "- New app launch party! Today at 3:30!";
                Line5.Text = "- Browse new 2019 sustainability goals";
            }
            else if (DateTime.Today.ToString("dddd") == "Tuesday")
            {
                Line1.Text = "10:00pm - Meeting with the CEO";
                Line2.Text = "12:00pm - Lunch with Client";
                Line3.Text = "5:00pm - Have Project Finished";
                Line4.Text = "- New app launch party! Today at 3:30!";
                Line5.Text = "- Browse new 2019 sustainability goals";
            }
            else if (DateTime.Today.ToString("dddd") == "Wednesday")
            {
                Line1.Text = "10:00pm - Meeting with the CEO";
                Line2.Text = "12:00pm - Lunch with Client";
                Line3.Text = "5:00pm - Have Project Finished";
                Line4.Text = "- New app launch party! Today at 3:30!";
                Line5.Text = "- Browse new 2019 sustainability goals";
            }
            else if (DateTime.Today.ToString("dddd") == "Thursday")
            {
                Line1.Text = "10:00pm - Meeting with the CEO";
                Line2.Text = "12:00pm - Lunch with Client";
                Line3.Text = "5:00pm - Have Project Finished";
                Line4.Text = "- New app launch party! Today at 3:30!";
                Line5.Text = "- Browse new 2019 sustainability goals";
            }
            else if (DateTime.Today.ToString("dddd") == "Friday")
            {
                Line1.Text = "10:00pm - Meeting with the CEO";
                Line2.Text = "12:00pm - Lunch with Client";
                Line3.Text = "5:00pm - Have Project Finished";
                Line4.Text = "- New app launch party! Today at 3:30!";
                Line5.Text = "- Browse new 2019 sustainability goals";
            }

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}
