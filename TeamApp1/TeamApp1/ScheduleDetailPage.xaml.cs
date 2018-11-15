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
	public partial class ScheduleDetailPage : ContentPage
	{
		public ScheduleDetailPage (Schedule incomingSchedule)
		{
			InitializeComponent ();

            weekdayLabel.Text = incomingSchedule.weekDay;
            workshiftLabel.Text = incomingSchedule.workShift;
            workDetailLabel.Text = incomingSchedule.workDetail;
            workCompletionLabel.Text = incomingSchedule.workCompletionDate;
		}
	}
}