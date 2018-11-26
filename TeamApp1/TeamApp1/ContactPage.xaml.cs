using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TeamApp1
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NameEntry.Text))
            {
                DisplayAlert("Error", "Please enter Name!", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                DisplayAlert("Error", "Please enter E-mail!", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(MessageEntry.Text))
            {
                DisplayAlert("Error", "Please enter Message!", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(DepartmentEntry.Text))
            {
                DisplayAlert("Error", "Please enter your Department!", "Ok");
                return;
            }

            DisplayAlert("Alert", "Message sent successfully!", "Ok");
        }
    }
}
