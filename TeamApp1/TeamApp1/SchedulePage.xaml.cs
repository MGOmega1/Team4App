using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public ObservableCollection<Schedule> schedules {get; set;}
        public SchedulePage()
        {
            InitializeComponent();
            this.schedules = new ObservableCollection<Schedule>();
            this.schedules.Add(new Schedule { weekDay = "Mon", workShift= "8:00 AM - 5:00 PM", workDetail = "Shred the files", workCompletionDate = "12/24/18"});
            this.schedules.Add(new Schedule { weekDay = "Tues", workShift = "9:00 AM - 6:00 PM", workDetail = "Deposit Money Into Bank", workCompletionDate = "11/13/18" });
            this.schedules.Add(new Schedule { weekDay = "Wed", workShift = "8:30 AM - 5:30 PM", workDetail = "Check Inventory", workCompletionDate = "12/01/18" });
            this.schedules.Add(new Schedule { weekDay = "Thurs", workShift = "Off", workDetail = "Enjoy the Day", workCompletionDate = "12/24/18" });
            this.schedules.Add(new Schedule { weekDay = "Fri", workShift = "7:00 AM - 3:00 PM", workDetail = "Shred the files", workCompletionDate = "11/30/18" });
            this.scheduleListView.ItemsSource = this.schedules;
        }

        private void scheduleListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            Schedule selectedSchedule = e.SelectedItem as Schedule;
            (sender as ListView).SelectedItem = null;
            DisplayAlert("Hello Worker", "Here is your schedule for " + selectedSchedule.weekDay, " Shift: " + selectedSchedule.workShift + " Detail: " + selectedSchedule.workDetail + " Work to be completed by: " + selectedSchedule.workCompletionDate, "ok");
        }
    }
    public class Schedule
    {
        public string weekDay { get; set; }
        public string workShift { get; set; }
        public string workDetail { get; set; }
        public string workCompletionDate { get; set; }
    }
}