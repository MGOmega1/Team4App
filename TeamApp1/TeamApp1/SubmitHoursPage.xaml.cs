using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubmitHoursPage : ContentPage
	{
		public SubmitHoursPage ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PastHoursPage(mondayEntry.Text, tuesdayEntry.Text, wednesdayEntry.Text, thursdayEntry.Text, fridayEntry.Text));
        }
    }
}